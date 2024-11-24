using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Memory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SWTOR_ChatHook
{
    public partial class Mainform : MaterialForm
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern int MessageBoxW(IntPtr hWnd, string lpText, string lpCaption, uint uType);

        Funcs funcs = new Funcs();
        string chatMsgAddr;
        string msgBuffer;
        bool paused;
        bool alwaysOnTop;
        bool notificationsEnabled;
        bool logToFile;


        public Mainform()
        {
            InitializeComponent();
            MaterialSkinManager.Instance.Theme = MaterialSkinManager.Themes.DARK;
            MaterialSkinManager.Instance.ColorScheme = new ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple900, Accent.Purple700, TextShade.WHITE);
            Color fColor = Color.FromArgb(220, 220, 220);
            Color bColor = Color.FromArgb(50, 50, 50);
            this.BackColor = bColor;
            this.ForeColor = fColor;
            txtbox_chat.BackColor = Color.Black;
            txtbox_chat.ForeColor = Color.Red;
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(funcs.OnProcessExit);
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            funcs.attachToProc();
            chatMsgAddr = funcs.initHook();
            if(chatMsgAddr == "00")
            {
                logText("Hook failed. Please restart the game and tool");
                return;
            }
            logText("Chat hooked successfully!\r\n");
            mainTimer.Start();
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            string chatMessage = funcs.readChat(chatMsgAddr);
            if(msgBuffer == chatMessage)
            {
                return;
            }
            else
            {
                msgBuffer = chatMessage;
                if(msgBuffer == "0")
                { return; }
                logText(msgBuffer);
            }

            if (notificationsEnabled)
            {
                string soundPath = "Notification.wav";
                SoundPlayer soundPlayer = new SoundPlayer(soundPath);

                soundPlayer.Play();
            }

            if (logToFile)
            {
                funcs.saveTextToFile(txtbox_chat.Text + "\n\r");
            }
        }

        #region buttons
        private void btn_about_Click(object sender, EventArgs e)
        {
            int[] en = { 77, 97, 100, 101, 32, 98, 121, 32, 110, 105, 103, 104, 116, 102, 97, 108, 108, 99, 116 };
            char[] decodedChars = new char[en.Length];
            for (int i = 0; i < en.Length; i++)
            {
                decodedChars[i] = (char)en[i];
            }
            string mg = new string(decodedChars);
            MessageBoxW(IntPtr.Zero, mg, "", 0);
        }
        private void btn_clearChat_Click(object sender, EventArgs e)
        {
            txtbox_chat.Text = string.Empty;
        }
        #endregion

        #region switches
        private void swt_fileLogging_CheckedChanged(object sender, EventArgs e)
        {
            logToFile = !logToFile;
        }
        private void swt_pingSound_CheckedChanged(object sender, EventArgs e)
        {
            notificationsEnabled = !notificationsEnabled;
        }
        private void swt_pause_CheckedChanged(object sender, EventArgs e)
        {
            if (!paused)
            {
                funcs.restoreOriginalBytes();
                paused = true;
            }
            else
            {
                funcs.restorePatchedBytes();
                paused = false;
            }
        }
        private void swt_onTop_CheckedChanged(object sender, EventArgs e)
        {
            if (!alwaysOnTop)
            {
                this.TopMost = true;
                alwaysOnTop = true;
            }
            else
            {
                this.TopMost = false;
                alwaysOnTop = false;
            }
        }
        #endregion

        private void logText(string textToLog)
        {
            txtbox_chat.AppendText($"[{DateTime.Now}]>  " + textToLog + $"\r\n\r\n");
            return;
        }

    }
}
