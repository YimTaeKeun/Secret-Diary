namespace Project_Jack
{
    partial class SecretDiary_Writing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecretDiary_Writing));
            this.Body = new System.Windows.Forms.RichTextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.BodyBox = new System.Windows.Forms.GroupBox();
            this.Save = new System.Windows.Forms.Button();
            this.TitleBox = new System.Windows.Forms.GroupBox();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.Panel = new System.Windows.Forms.Panel();
            this.Save_Label = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Encrypt_CheckBox = new System.Windows.Forms.CheckBox();
            this.BodyBox.SuspendLayout();
            this.TitleBox.SuspendLayout();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Body
            // 
            this.Body.BackColor = System.Drawing.Color.MintCream;
            this.Body.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Body.Location = new System.Drawing.Point(21, 20);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(413, 448);
            this.Body.TabIndex = 0;
            this.Body.Text = "";
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.MintCream;
            this.Title.Location = new System.Drawing.Point(23, 20);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(389, 21);
            this.Title.TabIndex = 1;
            this.Title.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BodyBox
            // 
            this.BodyBox.BackColor = System.Drawing.Color.White;
            this.BodyBox.Controls.Add(this.Save);
            this.BodyBox.Controls.Add(this.Body);
            this.BodyBox.Location = new System.Drawing.Point(0, 100);
            this.BodyBox.Name = "BodyBox";
            this.BodyBox.Size = new System.Drawing.Size(453, 503);
            this.BodyBox.TabIndex = 2;
            this.BodyBox.TabStop = false;
            this.BodyBox.Text = "내용";
            // 
            // Save
            // 
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Location = new System.Drawing.Point(17, 474);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(413, 23);
            this.Save.TabIndex = 1;
            this.Save.Text = "저장";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // TitleBox
            // 
            this.TitleBox.BackColor = System.Drawing.Color.White;
            this.TitleBox.Controls.Add(this.Title);
            this.TitleBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleBox.Location = new System.Drawing.Point(0, 33);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(453, 61);
            this.TitleBox.TabIndex = 3;
            this.TitleBox.TabStop = false;
            this.TitleBox.Text = "제목";
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.Text = "notifyIcon1";
            this.NotifyIcon.Visible = true;
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.Cyan;
            this.Panel.Controls.Add(this.Save_Label);
            this.Panel.Location = new System.Drawing.Point(0, 603);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(453, 19);
            this.Panel.TabIndex = 4;
            // 
            // Save_Label
            // 
            this.Save_Label.AutoSize = true;
            this.Save_Label.Font = new System.Drawing.Font("굴림", 9F);
            this.Save_Label.Location = new System.Drawing.Point(189, 5);
            this.Save_Label.Name = "Save_Label";
            this.Save_Label.Size = new System.Drawing.Size(85, 12);
            this.Save_Label.TabIndex = 0;
            this.Save_Label.Text = "자동 저장 완료";
            this.Save_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Encrypt_CheckBox
            // 
            this.Encrypt_CheckBox.AutoSize = true;
            this.Encrypt_CheckBox.Checked = true;
            this.Encrypt_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Encrypt_CheckBox.Location = new System.Drawing.Point(38, 22);
            this.Encrypt_CheckBox.Name = "Encrypt_CheckBox";
            this.Encrypt_CheckBox.Size = new System.Drawing.Size(60, 16);
            this.Encrypt_CheckBox.TabIndex = 5;
            this.Encrypt_CheckBox.Text = "암호화";
            this.Encrypt_CheckBox.UseVisualStyleBackColor = true;
            this.Encrypt_CheckBox.CheckStateChanged += new System.EventHandler(this.Encrypt_CheckBox_CheckStateChanged);
            // 
            // SecretDiary_Writing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 623);
            this.Controls.Add(this.Encrypt_CheckBox);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.BodyBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SecretDiary_Writing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SecretDiary_Writing_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SecretDiary_Writing_FormClosed);
            this.Load += new System.EventHandler(this.SecretDiary_Writing_Load);
            this.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.SecretDiary_Writing_ControlRemoved);
            this.Resize += new System.EventHandler(this.SecretDiary_Writing_Resize);
            this.StyleChanged += new System.EventHandler(this.SecretDiary_Writing_StyleChanged);
            this.BodyBox.ResumeLayout(false);
            this.TitleBox.ResumeLayout(false);
            this.TitleBox.PerformLayout();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Body;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.GroupBox BodyBox;
        private System.Windows.Forms.GroupBox TitleBox;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Label Save_Label;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.CheckBox Encrypt_CheckBox;
    }
}