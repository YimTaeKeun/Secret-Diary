namespace Project_Jack
{
    partial class LoginForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.IDTextbox = new System.Windows.Forms.TextBox();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.Account = new System.Windows.Forms.Button();
            this.Copyright = new System.Windows.Forms.Label();
            this.ServerChecker = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AcountWindow = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PasswordAgain_pwb = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.Mininmize = new System.Windows.Forms.Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Server_Change_Button = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Password_Check_Panel = new System.Windows.Forms.Panel();
            this.Password_Panel = new System.Windows.Forms.Panel();
            this.UserID_Panel = new System.Windows.Forms.Panel();
            this.Premium_Label = new System.Windows.Forms.Label();
            this.FileLocation_Label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 40F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(210)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(161, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Secret Diary Login";
            this.ToolTip.SetToolTip(this.label1, "Title");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.Text = "notifyIcon1";
            this.NotifyIcon.Visible = true;
            // 
            // IDTextbox
            // 
            this.IDTextbox.Location = new System.Drawing.Point(307, 138);
            this.IDTextbox.Name = "IDTextbox";
            this.IDTextbox.Size = new System.Drawing.Size(223, 22);
            this.IDTextbox.TabIndex = 1;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(307, 174);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '*';
            this.PasswordTextbox.Size = new System.Drawing.Size(223, 22);
            this.PasswordTextbox.TabIndex = 2;
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Transparent;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(210)))), ((int)(((byte)(84)))));
            this.Login.Location = new System.Drawing.Point(307, 243);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(223, 23);
            this.Login.TabIndex = 3;
            this.Login.Text = "로그인";
            this.ToolTip.SetToolTip(this.Login, "로그인");
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Account
            // 
            this.Account.BackColor = System.Drawing.Color.Transparent;
            this.Account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Account.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(210)))), ((int)(((byte)(84)))));
            this.Account.Location = new System.Drawing.Point(307, 272);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(223, 23);
            this.Account.TabIndex = 4;
            this.Account.Text = "회원가입";
            this.ToolTip.SetToolTip(this.Account, "회원가입");
            this.Account.UseVisualStyleBackColor = false;
            this.Account.Visible = false;
            this.Account.Click += new System.EventHandler(this.Account_Click);
            // 
            // Copyright
            // 
            this.Copyright.AutoSize = true;
            this.Copyright.BackColor = System.Drawing.Color.Transparent;
            this.Copyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(210)))), ((int)(((byte)(84)))));
            this.Copyright.Location = new System.Drawing.Point(562, 341);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(259, 12);
            this.Copyright.TabIndex = 4;
            this.Copyright.Text = "Copyright (C) 2017 임태근 all rights reserved.";
            // 
            // ServerChecker
            // 
            this.ServerChecker.AutoSize = true;
            this.ServerChecker.BackColor = System.Drawing.Color.Transparent;
            this.ServerChecker.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ServerChecker.ForeColor = System.Drawing.Color.Red;
            this.ServerChecker.Location = new System.Drawing.Point(305, 123);
            this.ServerChecker.Name = "ServerChecker";
            this.ServerChecker.Size = new System.Drawing.Size(103, 12);
            this.ServerChecker.TabIndex = 5;
            this.ServerChecker.Text = "OFFLINE Mode";
            this.ToolTip.SetToolTip(this.ServerChecker, "서버 상태를 알립니다.");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AcountWindow);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 362);
            this.panel1.TabIndex = 6;
            // 
            // AcountWindow
            // 
            this.AcountWindow.BackColor = System.Drawing.Color.Transparent;
            this.AcountWindow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AcountWindow.FlatAppearance.BorderSize = 0;
            this.AcountWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcountWindow.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcountWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(210)))), ((int)(((byte)(84)))));
            this.AcountWindow.Location = new System.Drawing.Point(0, 184);
            this.AcountWindow.Name = "AcountWindow";
            this.AcountWindow.Size = new System.Drawing.Size(147, 178);
            this.AcountWindow.TabIndex = 0;
            this.AcountWindow.Text = "회원가입";
            this.ToolTip.SetToolTip(this.AcountWindow, "회원가입 모드로 변경합니다.");
            this.AcountWindow.UseVisualStyleBackColor = false;
            this.AcountWindow.Click += new System.EventHandler(this.AcountWindow_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(210)))), ((int)(((byte)(84)))));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 178);
            this.button1.TabIndex = 0;
            this.button1.Text = "로그인";
            this.ToolTip.SetToolTip(this.button1, "로그인 모드로 변경합니다.");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Location = new System.Drawing.Point(153, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 178);
            this.panel2.TabIndex = 7;
            // 
            // PasswordAgain_pwb
            // 
            this.PasswordAgain_pwb.Location = new System.Drawing.Point(307, 210);
            this.PasswordAgain_pwb.Name = "PasswordAgain_pwb";
            this.PasswordAgain_pwb.PasswordChar = '*';
            this.PasswordAgain_pwb.Size = new System.Drawing.Size(223, 22);
            this.PasswordAgain_pwb.TabIndex = 3;
            this.PasswordAgain_pwb.Visible = false;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(210)))), ((int)(((byte)(84)))));
            this.Exit.Location = new System.Drawing.Point(806, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(24, 20);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "X";
            this.ToolTip.SetToolTip(this.Exit, "닫기");
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Mininmize
            // 
            this.Mininmize.BackColor = System.Drawing.Color.Transparent;
            this.Mininmize.FlatAppearance.BorderSize = 0;
            this.Mininmize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mininmize.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Mininmize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(210)))), ((int)(((byte)(84)))));
            this.Mininmize.Location = new System.Drawing.Point(775, 0);
            this.Mininmize.Name = "Mininmize";
            this.Mininmize.Size = new System.Drawing.Size(25, 20);
            this.Mininmize.TabIndex = 9;
            this.Mininmize.Text = "-";
            this.ToolTip.SetToolTip(this.Mininmize, "최소화");
            this.Mininmize.UseVisualStyleBackColor = false;
            this.Mininmize.Click += new System.EventHandler(this.Mininmize_Click);
            // 
            // Server_Change_Button
            // 
            this.Server_Change_Button.BackColor = System.Drawing.Color.Transparent;
            this.Server_Change_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Server_Change_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(210)))), ((int)(((byte)(84)))));
            this.Server_Change_Button.Location = new System.Drawing.Point(414, 114);
            this.Server_Change_Button.Name = "Server_Change_Button";
            this.Server_Change_Button.Size = new System.Drawing.Size(130, 21);
            this.Server_Change_Button.TabIndex = 10;
            this.Server_Change_Button.Text = "OFFLINE 모드 전환";
            this.Server_Change_Button.UseVisualStyleBackColor = false;
            this.Server_Change_Button.Visible = false;
            this.Server_Change_Button.Click += new System.EventHandler(this.Server_Change_Button_Click);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.FileName = "Secret Diary File";
            this.SaveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog_FileOk);
            // 
            // FolderBrowserDialog
            // 
            this.FolderBrowserDialog.Description = "*지정된 폴더를 없애거나, 폴더의 이름 절대 변경을 하지 마십시오.";
            this.FolderBrowserDialog.HelpRequest += new System.EventHandler(this.FolderBrowserDialog_HelpRequest);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Project_Jack.Properties.Resources.NotePNG;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(746, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(75, 73);
            this.panel3.TabIndex = 12;
            // 
            // Password_Check_Panel
            // 
            this.Password_Check_Panel.BackgroundImage = global::Project_Jack.Properties.Resources.password_check;
            this.Password_Check_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Password_Check_Panel.Location = new System.Drawing.Point(268, 207);
            this.Password_Check_Panel.Name = "Password_Check_Panel";
            this.Password_Check_Panel.Size = new System.Drawing.Size(33, 33);
            this.Password_Check_Panel.TabIndex = 11;
            // 
            // Password_Panel
            // 
            this.Password_Panel.BackgroundImage = global::Project_Jack.Properties.Resources.Password;
            this.Password_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Password_Panel.Location = new System.Drawing.Point(268, 171);
            this.Password_Panel.Name = "Password_Panel";
            this.Password_Panel.Size = new System.Drawing.Size(33, 33);
            this.Password_Panel.TabIndex = 11;
            // 
            // UserID_Panel
            // 
            this.UserID_Panel.BackgroundImage = global::Project_Jack.Properties.Resources.User_ID;
            this.UserID_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UserID_Panel.Location = new System.Drawing.Point(269, 134);
            this.UserID_Panel.Name = "UserID_Panel";
            this.UserID_Panel.Size = new System.Drawing.Size(33, 33);
            this.UserID_Panel.TabIndex = 11;
            // 
            // Premium_Label
            // 
            this.Premium_Label.AutoSize = true;
            this.Premium_Label.Font = new System.Drawing.Font("Century Gothic", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Premium_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(210)))), ((int)(((byte)(84)))));
            this.Premium_Label.Location = new System.Drawing.Point(559, 87);
            this.Premium_Label.Name = "Premium_Label";
            this.Premium_Label.Size = new System.Drawing.Size(128, 27);
            this.Premium_Label.TabIndex = 13;
            this.Premium_Label.Text = "Premium";
            this.Premium_Label.Visible = false;
            // 
            // FileLocation_Label
            // 
            this.FileLocation_Label.AutoSize = true;
            this.FileLocation_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(210)))), ((int)(((byte)(84)))));
            this.FileLocation_Label.Location = new System.Drawing.Point(168, 322);
            this.FileLocation_Label.Name = "FileLocation_Label";
            this.FileLocation_Label.Size = new System.Drawing.Size(113, 12);
            this.FileLocation_Label.TabIndex = 14;
            this.FileLocation_Label.Text = "다이어리 저장위치: ";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(829, 362);
            this.Controls.Add(this.FileLocation_Label);
            this.Controls.Add(this.Premium_Label);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Password_Check_Panel);
            this.Controls.Add(this.Password_Panel);
            this.Controls.Add(this.UserID_Panel);
            this.Controls.Add(this.Server_Change_Button);
            this.Controls.Add(this.Mininmize);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ServerChecker);
            this.Controls.Add(this.Copyright);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.PasswordAgain_pwb);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.IDTextbox);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secret Diary - Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        public System.Windows.Forms.TextBox IDTextbox;
        public System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Account;
        private System.Windows.Forms.Label Copyright;
        private System.Windows.Forms.Label ServerChecker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AcountWindow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox PasswordAgain_pwb;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Mininmize;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Button Server_Change_Button;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.Panel UserID_Panel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel Password_Panel;
        private System.Windows.Forms.Panel Password_Check_Panel;
        private System.Windows.Forms.Label Premium_Label;
        private System.Windows.Forms.Label FileLocation_Label;
    }
}

