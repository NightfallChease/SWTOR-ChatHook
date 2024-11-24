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
            this.swt_pause = new MaterialSkin.Controls.MaterialSwitch();
            this.txtbox_chat = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.swt_onTop = new MaterialSkin.Controls.MaterialSwitch();
            this.SuspendLayout();
            // 
            // btn_about
            // 
            this.btn_about.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_about.AutoSize = false;
            this.btn_about.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_about.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_about.Depth = 0;
            this.btn_about.HighEmphasis = true;
            this.btn_about.Icon = null;
            this.btn_about.Location = new System.Drawing.Point(285, 523);
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
            this.swt_pause.AutoSize = true;
            this.swt_pause.Depth = 0;
            this.swt_pause.Location = new System.Drawing.Point(9, 523);
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
            this.txtbox_chat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtbox_chat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_chat.Depth = 0;
            this.txtbox_chat.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtbox_chat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtbox_chat.Location = new System.Drawing.Point(9, 95);
            this.txtbox_chat.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtbox_chat.Name = "txtbox_chat";
            this.txtbox_chat.Size = new System.Drawing.Size(626, 425);
            this.txtbox_chat.TabIndex = 7;
            this.txtbox_chat.Text = "";
            // 
            // swt_onTop
            // 
            this.swt_onTop.AutoSize = true;
            this.swt_onTop.Depth = 0;
            this.swt_onTop.Location = new System.Drawing.Point(528, 522);
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
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 563);
            this.Controls.Add(this.swt_onTop);
            this.Controls.Add(this.txtbox_chat);
            this.Controls.Add(this.swt_pause);
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
        private MaterialSkin.Controls.MaterialSwitch swt_pause;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtbox_chat;
        private MaterialSkin.Controls.MaterialSwitch swt_onTop;
    }
}

