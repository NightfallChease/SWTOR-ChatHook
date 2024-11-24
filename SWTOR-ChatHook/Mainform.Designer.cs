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
            this.btn_about = new MaterialSkin.Controls.MaterialButton();
            this.lbl_chat = new MaterialSkin.Controls.MaterialLabel();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtbox_chat = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.SuspendLayout();
            // 
            // btn_about
            // 
            this.btn_about.AutoSize = false;
            this.btn_about.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_about.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_about.Depth = 0;
            this.btn_about.HighEmphasis = true;
            this.btn_about.Icon = null;
            this.btn_about.Location = new System.Drawing.Point(271, 505);
            this.btn_about.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_about.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_about.Name = "btn_about";
            this.btn_about.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_about.Size = new System.Drawing.Size(80, 37);
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
            // txtbox_chat
            // 
            this.txtbox_chat.AnimateReadOnly = false;
            this.txtbox_chat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtbox_chat.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtbox_chat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_chat.Depth = 0;
            this.txtbox_chat.HideSelection = true;
            this.txtbox_chat.Location = new System.Drawing.Point(6, 95);
            this.txtbox_chat.MaxLength = 32767;
            this.txtbox_chat.MouseState = MaterialSkin.MouseState.OUT;
            this.txtbox_chat.Name = "txtbox_chat";
            this.txtbox_chat.PasswordChar = '\0';
            this.txtbox_chat.ReadOnly = true;
            this.txtbox_chat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbox_chat.SelectedText = "";
            this.txtbox_chat.SelectionLength = 0;
            this.txtbox_chat.SelectionStart = 0;
            this.txtbox_chat.ShortcutsEnabled = true;
            this.txtbox_chat.Size = new System.Drawing.Size(616, 401);
            this.txtbox_chat.TabIndex = 5;
            this.txtbox_chat.TabStop = false;
            this.txtbox_chat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbox_chat.UseSystemPasswordChar = false;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 551);
            this.Controls.Add(this.txtbox_chat);
            this.Controls.Add(this.lbl_chat);
            this.Controls.Add(this.btn_about);
            this.Name = "Mainform";
            this.Text = "SWTOR Chat Hook";
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btn_about;
        private MaterialSkin.Controls.MaterialLabel lbl_chat;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtbox_chat;
    }
}

