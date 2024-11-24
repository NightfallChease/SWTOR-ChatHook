using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace SWTOR_ChatHook
{
    internal class Funcs
    {
        Mem m = new Mem();
        byte[] originalBytes;
        string aobAddrStr;
        UIntPtr aobUintPtr;
        bool hooked = false;

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
                string targetAOB = "EF CC CC CC CC CC 48 83 EC 18 BA 0C 00 FE 7F"; //+6
                byte[] patchedBytes = { 0x50, 0x53, 0x51, 0x52, 0x56, 0x57, 0x48, 0x8B, 0x02, 0x48, 0x85, 0xC0, 0x0F, 0x84, 0x17, 0x00, 0x00, 0x00, 0x48, 0x8D, 0x32, 0x48, 0x8D, 0x3D, 0x1B, 0x00, 0x00, 0x00, 0xB9, 0x20, 0x01, 0x00, 0x00, 0xF3, 0xA4, 0x5F, 0x5E, 0x5A, 0x59, 0x5B, 0x58, 0x48, 0x83, 0xEC, 0x18, 0xBA, 0x0C, 0x00, 0xFE, 0x7F };

                aobAddrStr = m.AoBScan(targetAOB).Result.Sum().ToString("X2");

                if(aobAddrStr == "00")
                {
                    return aobAddrStr;
                }

                aobUintPtr = m.Get64BitCode(aobAddrStr);

                originalBytes = m.ReadBytes(aobAddrStr, 15);

                UIntPtr addrStrUint = aobUintPtr + 0x6;

                aobAddrStr = convertUintToHexString(addrStrUint);


                //MessageBox.Show(convertUintToHexString(addrStrUint));

                UIntPtr caveAddr = m.CreateCodeCave(aobAddrStr, patchedBytes, 9, 1024);

                hooked = true;

                UIntPtr chatMsgAddr = caveAddr + 0x37;

                string chatMsgAddrStr = convertUintToHexString(chatMsgAddr);

                //string chatMessage = m.ReadString(chatMsgAddrStr);

                //MessageBox.Show(chatMessage);

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

            if(chatMessage.Length > 1)
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
            if(hooked)
            {
                m.WriteBytes(aobUintPtr, originalBytes);
            }
        }

    }
}
