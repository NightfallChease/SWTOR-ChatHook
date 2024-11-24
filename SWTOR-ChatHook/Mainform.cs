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
        StringBuilder originalTextBuilder = new StringBuilder(); // Use StringBuilder for better handling
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
            txtbox_chat.ForeColor = Color.White;
            txtbox_search.BackColor = Color.Black;
            txtbox_search.ForeColor = Color.White;
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(funcs.OnProcessExit);
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            funcs.attachToProc();
            chatMsgAddr = funcs.initHook();
            if (chatMsgAddr == "00")
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

            // If the message is the same as the previous one, do nothing
            if (msgBuffer == chatMessage)
            {
                return;
            }
            else
            {
                msgBuffer = chatMessage;

                // Ignore if the message is empty
                if (msgBuffer == "0")
                {
                    return;
                }

                // Check if there's a search term in the filter
                if (txtbox_search.Text != "")
                {
                    // Check if the message contains the search term (case-insensitive)
                    if (msgBuffer.IndexOf(txtbox_search.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        // If it matches the search filter, log it into the filtered text
                        logText(msgBuffer);
                    }
                    else
                    {
                        // If it doesn't match, log it into the original (unfiltered) text
                        originalTextBuilder.AppendLine($"[{DateTime.Now}]>  {msgBuffer}");
                    }
                }
                else
                {
                    // If the search box is empty, display the message normally
                    logText(msgBuffer);
                }
            }

            // Handle notification sound
            if (notificationsEnabled)
            {
                try
                {
                    // Play notification sound (if any)
                }
                catch
                {
                    logText("No notification sound present. Please add a Notification.wav to the folder.");
                }

                string soundPath = "Notification.wav";
                SoundPlayer soundPlayer = new SoundPlayer(soundPath);
                soundPlayer.Play();
            }

            // Log to file if enabled
            if (logToFile)
            {
                funcs.saveTextToFile(txtbox_chat.Text);
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
            txtbox_chat.Clear();
            originalTextBuilder.Clear(); // Clear the stored chat as well
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
            this.TopMost = !this.TopMost;
            alwaysOnTop = this.TopMost;
        }
        #endregion

        #region localmethods
        private void logText(string textToLog)
        {
            // Log to the builder (maintains full chat text)
            originalTextBuilder.AppendLine($"[{DateTime.Now}]>  {textToLog}");

            // Also append to the TextBox for UI display
            txtbox_chat.AppendText($"[{DateTime.Now}]>  {textToLog}\r\n\r\n");
        }

        private void txtbox_search_TextChanged(object sender, EventArgs e)
        {
            // Get the search term
            string searchText = txtbox_search.Text;

            // Get all lines from the dynamically updated originalText
            string[] lines = originalTextBuilder.ToString().Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            // If the search text is empty, restore the original text
            if (string.IsNullOrEmpty(searchText))
            {
                txtbox_chat.Text = originalTextBuilder.ToString();
            }
            else
            {
                // Filter the lines that contain the search text
                var filteredLines = lines.Where(line =>
                    line.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToArray();

                // Update txtbox_chat with the filtered lines
                txtbox_chat.Text = string.Join(Environment.NewLine, filteredLines);
            }

            // Keep the caret position intact after updating the text
            int caretPosition = txtbox_chat.SelectionStart;
            txtbox_chat.SelectionStart = caretPosition;
            txtbox_chat.SelectionLength = 0; // Reset the selection
        }

        #endregion
    }

}

