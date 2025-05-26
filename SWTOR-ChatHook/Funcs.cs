using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Windows.Forms;
using Memory;

namespace SWTOR_ChatHook
{
    internal class Funcs
    {
        Mem m = new Mem();
        byte[] originalBytes;
        byte[] patchedBytes;
        string aobAddrStr;
        UIntPtr aobUintPtr;
        bool hooked = false;
        private string filePath;

        public int attachToProc()
        {
            int PID = m.GetProcIdFromName("swtor");
            m.OpenProcess(PID);

            return PID;
        }

        public string initHook()
        {
            try
            {
                string targetAOB = "25 ?? ?? ?? ?? CC CC CC CC CC CC CC 48 83 EC 18 BA 0C 00 FE 7F"; //+0C
                byte[] patchedBytes = { 0x50, 0x53, 0x51, 0x52, 0x56, 0x57, 0x48, 0x8B, 0x02, 0x48, 0x85, 0xC0, 0x0F, 0x84, 0x17, 0x00, 0x00, 0x00, 0x48, 0x8D, 0x32, 0x48, 0x8D, 0x3D, 0x1B, 0x00, 0x00, 0x00, 0xB9, 0x20, 0x01, 0x00, 0x00, 0xF3, 0xA4, 0x5F, 0x5E, 0x5A, 0x59, 0x5B, 0x58, 0x48, 0x83, 0xEC, 0x18, 0xBA, 0x0C, 0x00, 0xFE, 0x7F };

                aobAddrStr = m.AoBScan(targetAOB).Result.Sum().ToString("X2");

                if (aobAddrStr == "00")
                {
                    return aobAddrStr;
                }

                aobUintPtr = m.Get64BitCode(aobAddrStr);

                originalBytes = m.ReadBytes(aobAddrStr, 37);

                UIntPtr addrStrUint = aobUintPtr + 0x0C;

                string functionStartStr = convertUintToHexString(addrStrUint);

                UIntPtr caveAddr = m.CreateCodeCave(functionStartStr, patchedBytes, 9, 1024);

                hooked = true;

                UIntPtr chatMsgAddr = caveAddr + 0x37;

                string chatMsgAddrStr = convertUintToHexString(chatMsgAddr);

                return chatMsgAddrStr;

            }
            catch (Exception e)
            {
                MessageBox.Show($"Init failed ERROR: {e.Message}");
                return "0";
            }


        }

        public string readChat(string chatMsgAddrStr)
        {
            string chatMessage = m.ReadString(chatMsgAddrStr, length: 600);

            if (chatMessage.Length > 1)
            {
                return chatMessage;
            }
            else
            {
                return "0";
            }
        }

        private string convertUintToHexString(UIntPtr uintToConvert)
        {
            string placeholder1 = uintToConvert.ToString();
            long placeholder2 = long.Parse(placeholder1);
            string hexstring = placeholder2.ToString("X2");
            return hexstring;
        }

        public void OnProcessExit(object sender, EventArgs e)
        {
            if (hooked)
            {
                m.WriteBytes(aobUintPtr, originalBytes);
            }
        }

        public void restoreOriginalBytes()
        {
            patchedBytes = m.ReadBytes(aobAddrStr, 37);
            m.WriteBytes(aobUintPtr, originalBytes);
        }

        public void restorePatchedBytes()
        {
            m.WriteBytes(aobUintPtr, patchedBytes);
        }

        public void saveTextToFile(string msgToSave)
        {
            if (filePath == null)
            {
                string baseFileName = "MessageLog";
                string extension = ".txt";
                string directory = Environment.CurrentDirectory;

                int fileNumber = 0;
                string fileName;

                // Find a unique file name only once
                do
                {
                    fileNumber++;
                    fileName = Path.Combine(directory, $"{baseFileName}{(fileNumber == 1 ? "" : fileNumber.ToString())}{extension}");
                } while (File.Exists(fileName));

                filePath = fileName;
                Console.WriteLine($"File created: {filePath}");
            }

            // Append the message to the persistent file
            using (StreamWriter outputFile = new StreamWriter(filePath, append: true))
            {
                outputFile.WriteLine(msgToSave);
            }
        }

        public async void updateCheck()
        {
            string urlUpdate = "https://github.com/NightfallChease/s/blob/main/chatVer5.sw";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(urlUpdate).Result;

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Your tool is outdated. Please download a new version from the discord");
                    Environment.Exit(1);
                }
            }
        }

    }
}