namespace SWTOR_ChatHook
{
    partial class Mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.btn_about = new MaterialSkin.Controls.MaterialButton();
            this.lbl_chat = new MaterialSkin.Controls.MaterialLabel();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.swt_pause = new MaterialSkin.Controls.MaterialSwitch();
            this.txtbox_chat = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.swt_onTop = new MaterialSkin.Controls.MaterialSwitch();
            this.btn_clearChat = new MaterialSkin.Controls.MaterialButton();
            this.swt_pingSound = new MaterialSkin.Controls.MaterialSwitch();
            this.lbl_Notify = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_logToFile = new MaterialSkin.Controls.MaterialLabel();
            this.swt_fileLogging = new MaterialSkin.Controls.MaterialSwitch();
            this.lbl_search = new MaterialSkin.Controls.MaterialLabel();
            this.txtbox_search = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_about
            // 
            this.btn_about.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_about.AutoSize = false;
            this.btn_about.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_about.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_about.Depth = 0;
            this.btn_about.HighEmphasis = true;
            this.btn_about.Icon = null;
            this.btn_about.Location = new System.Drawing.Point(250, 486);
            this.btn_about.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_about.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_about.Name = "btn_about";
            this.btn_about.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_about.Size = new System.Drawing.Size(70, 32);
            this.btn_about.TabIndex = 1;
            this.btn_about.Text = "About";
            this.btn_about.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_about.UseAccentColor = false;
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // lbl_chat
            // 
            this.lbl_chat.AutoSize = true;
            this.lbl_chat.Depth = 0;
            this.lbl_chat.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_chat.Location = new System.Drawing.Point(6, 73);
            this.lbl_chat.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_chat.Name = "lbl_chat";
            this.lbl_chat.Size = new System.Drawing.Size(69, 19);
            this.lbl_chat.TabIndex = 2;
            this.lbl_chat.Text = "Chat Log:";
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 1;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // swt_pause
            // 
            this.swt_pause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.swt_pause.AutoSize = true;
            this.swt_pause.Depth = 0;
            this.swt_pause.Location = new System.Drawing.Point(9, 486);
            this.swt_pause.Margin = new System.Windows.Forms.Padding(0);
            this.swt_pause.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swt_pause.MouseState = MaterialSkin.MouseState.HOVER;
            this.swt_pause.Name = "swt_pause";
            this.swt_pause.Ripple = true;
            this.swt_pause.Size = new System.Drawing.Size(159, 37);
            this.swt_pause.TabIndex = 6;
            this.swt_pause.Text = "Pause logging";
            this.swt_pause.UseVisualStyleBackColor = true;
            this.swt_pause.CheckedChanged += new System.EventHandler(this.swt_pause_CheckedChanged);
            // 
            // txtbox_chat
            // 
            this.txtbox_chat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_chat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtbox_chat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_chat.Depth = 0;
            this.txtbox_chat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtbox_chat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtbox_chat.Location = new System.Drawing.Point(9, 95);
            this.txtbox_chat.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtbox_chat.Name = "txtbox_chat";
            this.txtbox_chat.ReadOnly = true;
            this.txtbox_chat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtbox_chat.Size = new System.Drawing.Size(455, 388);
            this.txtbox_chat.TabIndex = 7;
            this.txtbox_chat.Text = "";
            // 
            // swt_onTop
            // 
            this.swt_onTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.swt_onTop.AutoSize = true;
            this.swt_onTop.Depth = 0;
            this.swt_onTop.Location = new System.Drawing.Point(458, 485);
            this.swt_onTop.Margin = new System.Windows.Forms.Padding(0);
            this.swt_onTop.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swt_onTop.MouseState = MaterialSkin.MouseState.HOVER;
            this.swt_onTop.Name = "swt_onTop";
            this.swt_onTop.Ripple = true;
            this.swt_onTop.Size = new System.Drawing.Size(110, 37);
            this.swt_onTop.TabIndex = 8;
            this.swt_onTop.Text = "On Top";
            this.swt_onTop.UseVisualStyleBackColor = true;
            this.swt_onTop.CheckedChanged += new System.EventHandler(this.swt_onTop_CheckedChanged);
            // 
            // btn_clearChat
            // 
            this.btn_clearChat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clearChat.AutoSize = false;
            this.btn_clearChat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_clearChat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_clearChat.Depth = 0;
            this.btn_clearChat.HighEmphasis = true;
            this.btn_clearChat.Icon = null;
            this.btn_clearChat.Location = new System.Drawing.Point(482, 196);
            this.btn_clearChat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_clearChat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_clearChat.Name = "btn_clearChat";
            this.btn_clearChat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_clearChat.Size = new System.Drawing.Size(70, 32);
            this.btn_clearChat.TabIndex = 9;
            this.btn_clearChat.Text = "Clear";
            this.btn_clearChat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_clearChat.UseAccentColor = false;
            this.btn_clearChat.UseVisualStyleBackColor = true;
            this.btn_clearChat.Click += new System.EventHandler(this.btn_clearChat_Click);
            // 
            // swt_pingSound
            // 
            this.swt_pingSound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.swt_pingSound.AutoSize = true;
            this.swt_pingSound.Depth = 0;
            this.swt_pingSound.Location = new System.Drawing.Point(491, 275);
            this.swt_pingSound.Margin = new System.Windows.Forms.Padding(0);
            this.swt_pingSound.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swt_pingSound.MouseState = MaterialSkin.MouseState.HOVER;
            this.swt_pingSound.Name = "swt_pingSound";
            this.swt_pingSound.Ripple = true;
            this.swt_pingSound.Size = new System.Drawing.Size(58, 37);
            this.swt_pingSound.TabIndex = 10;
            this.swt_pingSound.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.swt_pingSound.UseVisualStyleBackColor = true;
            this.swt_pingSound.CheckedChanged += new System.EventHandler(this.swt_pingSound_CheckedChanged);
            // 
            // lbl_Notify
            // 
            this.lbl_Notify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Notify.AutoSize = true;
            this.lbl_Notify.Depth = 0;
            this.lbl_Notify.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Notify.Location = new System.Drawing.Point(474, 257);
            this.lbl_Notify.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Notify.Name = "lbl_Notify";
            this.lbl_Notify.Size = new System.Drawing.Size(92, 19);
            this.lbl_Notify.TabIndex = 11;
            this.lbl_Notify.Text = "Notify sound";
            // 
            // lbl_logToFile
            // 
            this.lbl_logToFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_logToFile.AutoSize = true;
            this.lbl_logToFile.Depth = 0;
            this.lbl_logToFile.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_logToFile.Location = new System.Drawing.Point(474, 314);
            this.lbl_logToFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_logToFile.Name = "lbl_logToFile";
            this.lbl_logToFile.Size = new System.Drawing.Size(91, 19);
            this.lbl_logToFile.TabIndex = 13;
            this.lbl_logToFile.Text = "Chat logging";
            // 
            // swt_fileLogging
            // 
            this.swt_fileLogging.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.swt_fileLogging.AutoSize = true;
            this.swt_fileLogging.Depth = 0;
            this.swt_fileLogging.Location = new System.Drawing.Point(491, 332);
            this.swt_fileLogging.Margin = new System.Windows.Forms.Padding(0);
            this.swt_fileLogging.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swt_fileLogging.MouseState = MaterialSkin.MouseState.HOVER;
            this.swt_fileLogging.Name = "swt_fileLogging";
            this.swt_fileLogging.Ripple = true;
            this.swt_fileLogging.Size = new System.Drawing.Size(58, 37);
            this.swt_fileLogging.TabIndex = 12;
            this.swt_fileLogging.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.swt_fileLogging.UseVisualStyleBackColor = true;
            this.swt_fileLogging.CheckedChanged += new System.EventHandler(this.swt_fileLogging_CheckedChanged);
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Depth = 0;
            this.lbl_search.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_search.Location = new System.Drawing.Point(201, 71);
            this.lbl_search.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(115, 19);
            this.lbl_search.TabIndex = 14;
            this.lbl_search.Text = "Filter for words: ";
            // 
            // txtbox_search
            // 
            this.txtbox_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtbox_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_search.Depth = 0;
            this.txtbox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtbox_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtbox_search.Location = new System.Drawing.Point(322, 71);
            this.txtbox_search.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtbox_search.Multiline = false;
            this.txtbox_search.Name = "txtbox_search";
            this.txtbox_search.Size = new System.Drawing.Size(125, 21);
            this.txtbox_search.TabIndex = 15;
            this.txtbox_search.Text = "";
            this.txtbox_search.TextChanged += new System.EventHandler(this.txtbox_search_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(530, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 526);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtbox_search);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.lbl_logToFile);
            this.Controls.Add(this.swt_fileLogging);
            this.Controls.Add(this.lbl_Notify);
            this.Controls.Add(this.swt_pingSound);
            this.Controls.Add(this.btn_clearChat);
            this.Controls.Add(this.swt_onTop);
            this.Controls.Add(this.txtbox_chat);
            this.Controls.Add(this.swt_pause);
            this.Controls.Add(this.lbl_chat);
            this.Controls.Add(this.btn_about);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Mainform";
            this.Text = "SWTOR Chat Hook";
            this.Load += new System.EventHandler(this.Mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btn_about;
        private MaterialSkin.Controls.MaterialLabel lbl_chat;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private MaterialSkin.Controls.MaterialSwitch swt_pause;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtbox_chat;
        private MaterialSkin.Controls.MaterialSwitch swt_onTop;
        private MaterialSkin.Controls.MaterialButton btn_clearChat;
        private MaterialSkin.Controls.MaterialSwitch swt_pingSound;
        private MaterialSkin.Controls.MaterialLabel lbl_Notify;
        private MaterialSkin.Controls.MaterialLabel lbl_logToFile;
        private MaterialSkin.Controls.MaterialSwitch swt_fileLogging;
        private MaterialSkin.Controls.MaterialLabel lbl_search;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtbox_search;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

