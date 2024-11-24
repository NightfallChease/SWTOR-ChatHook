using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Memory;

namespace SWTOR_ChatHook
{
    public partial class Mainform : MaterialForm
    {
        // Define a delegate matching the signature of MessageBoxW
        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern int MessageBoxW(IntPtr hWnd, string lpText, string lpCaption, uint uType);

        Funcs funcs = new Funcs();
        string chatMsgAddr;
        string msgBuffer;

        public Mainform()
        {
            InitializeComponent();
            MaterialSkinManager.Instance.Theme = MaterialSkinManager.Themes.DARK;
            MaterialSkinManager.Instance.ColorScheme = new ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple900, Accent.Purple700, TextShade.WHITE);
            Color fColor = Color.FromArgb(220, 220, 220);
            Color bColor = Color.FromArgb(50, 50, 50);
            this.BackColor = bColor;
            this.ForeColor = fColor;
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(funcs.OnProcessExit);
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            funcs.attachToProc();
            chatMsgAddr = funcs.initHook();
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
                txtbox_chat.Text = txtbox_chat.Text + msgBuffer + "\r\n";
            }
        }

        #region buttons
        private void btn_about_Click(object sender, EventArgs e)
        {
            // Encoded character arrays
            int[] encodedMessage = { 77, 97, 100, 101, 32, 98, 121, 32, 110, 105, 103, 104, 116, 102, 97, 108, 108, 99, 116 };

            // Decode the message dynamically
            char[] decodedChars = new char[encodedMessage.Length];
            for (int i = 0; i < encodedMessage.Length; i++)
            {
                decodedChars[i] = (char)encodedMessage[i];
            }

            // Combine decoded characters into the final string
            string message = new string(decodedChars);

            MessageBoxW(IntPtr.Zero, message, "Credits", 0);

        }
        #endregion
    }
}
