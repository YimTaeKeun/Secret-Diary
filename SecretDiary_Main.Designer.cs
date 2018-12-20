namespace Project_Jack
{
    partial class SecretDiary_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecretDiary_Main));
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ADDButton = new System.Windows.Forms.Button();
            this.Open_Diary = new System.Windows.Forms.Button();
            this.ADDTextbox = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.DiaryCollection = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BackToHome = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ADDButton
            // 
            this.ADDButton.FlatAppearance.BorderSize = 0;
            this.ADDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ADDButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(210)))), ((int)(((byte)(84)))));
            this.ADDButton.Location = new System.Drawing.Point(317, 3);
            this.ADDButton.Name = "ADDButton";
            this.ADDButton.Size = new System.Drawing.Size(133, 33);
            this.ADDButton.TabIndex = 1;
            this.ADDButton.Text = "추가";
            this.ToolTip.SetToolTip(this.ADDButton, "입력한 제목을 추가합니다.");
            this.ADDButton.UseVisualStyleBackColor = true;
            this.ADDButton.Click += new System.EventHandler(this.ADDButton_Click);
            // 
            // Open_Diary
            // 
            this.Open_Diary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Open_Diary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(210)))), ((int)(((byte)(84)))));
            this.Open_Diary.Location = new System.Drawing.Point(3, 74);
            this.Open_Diary.Name = "Open_Diary";
            this.Open_Diary.Size = new System.Drawing.Size(447, 23);
            this.Open_Diary.TabIndex = 3;
            this.Open_Diary.Text = "Diary 열기";
            this.ToolTip.SetToolTip(this.Open_Diary, "선택한 제목의 Diary를 엽니다.");
            this.Open_Diary.UseVisualStyleBackColor = true;
            this.Open_Diary.Click += new System.EventHandler(this.Open_Diary_Click);
            // 
            // ADDTextbox
            // 
            this.ADDTextbox.BackColor = System.Drawing.Color.White;
            this.ADDTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ADDTextbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ADDTextbox.Location = new System.Drawing.Point(3, 3);
            this.ADDTextbox.Multiline = true;
            this.ADDTextbox.Name = "ADDTextbox";
            this.ADDTextbox.Size = new System.Drawing.Size(308, 33);
            this.ADDTextbox.TabIndex = 2;
            this.ToolTip.SetToolTip(this.ADDTextbox, "추가할 제목을 입력해주세요.");
            this.ADDTextbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ADDTextbox_MouseDown);
            // 
            // Delete
            // 
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(210)))), ((int)(((byte)(84)))));
            this.Delete.Location = new System.Drawing.Point(3, 42);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(447, 26);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "삭제하기";
            this.ToolTip.SetToolTip(this.Delete, "삭제");
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Exit
            // 
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(210)))), ((int)(((byte)(84)))));
            this.Exit.Location = new System.Drawing.Point(425, 3);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(22, 20);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "X";
            this.ToolTip.SetToolTip(this.Exit, "닫기");
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Minimize
            // 
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(210)))), ((int)(((byte)(84)))));
            this.Minimize.Location = new System.Drawing.Point(396, 3);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(23, 20);
            this.Minimize.TabIndex = 0;
            this.Minimize.Text = "-";
            this.ToolTip.SetToolTip(this.Minimize, "최소화");
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // DiaryCollection
            // 
            this.DiaryCollection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.DiaryCollection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiaryCollection.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DiaryCollection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(210)))), ((int)(((byte)(84)))));
            this.DiaryCollection.FormattingEnabled = true;
            this.DiaryCollection.ItemHeight = 16;
            this.DiaryCollection.Location = new System.Drawing.Point(0, 32);
            this.DiaryCollection.Name = "DiaryCollection";
            this.DiaryCollection.Size = new System.Drawing.Size(453, 464);
            this.DiaryCollection.TabIndex = 0;
            this.DiaryCollection.SelectedIndexChanged += new System.EventHandler(this.DiaryCollection_SelectedIndexChanged);
            this.DiaryCollection.SelectedValueChanged += new System.EventHandler(this.DiaryCollection_SelectedValueChanged);
            this.DiaryCollection.DoubleClick += new System.EventHandler(this.DiaryCollection_DoubleClick);
            this.DiaryCollection.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DiaryCollection_MouseDoubleClick);
            this.DiaryCollection.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DiaryCollection_MouseDown);
            this.DiaryCollection.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DiaryCollection_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Open_Diary);
            this.panel1.Controls.Add(this.ADDTextbox);
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.ADDButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 509);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 114);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.BackToHome);
            this.panel2.Controls.Add(this.Exit);
            this.panel2.Controls.Add(this.Minimize);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 26);
            this.panel2.TabIndex = 3;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // BackToHome
            // 
            this.BackToHome.FlatAppearance.BorderSize = 0;
            this.BackToHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(210)))), ((int)(((byte)(84)))));
            this.BackToHome.Location = new System.Drawing.Point(376, 3);
            this.BackToHome.Name = "BackToHome";
            this.BackToHome.Size = new System.Drawing.Size(23, 20);
            this.BackToHome.TabIndex = 2;
            this.BackToHome.Text = "<";
            this.BackToHome.UseVisualStyleBackColor = true;
            this.BackToHome.Click += new System.EventHandler(this.BackToHome_Click);
            // 
            // SecretDiary_Main
            // 
            this.AcceptButton = this.Delete;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(453, 623);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DiaryCollection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SecretDiary_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecretDiary_Diary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SecretDiary_Main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SecretDiary_Main_FormClosed);
            this.Load += new System.EventHandler(this.SecretDiary_Main_Load);
            this.Shown += new System.EventHandler(this.SecretDiary_Main_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecretDiary_Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SecretDiary_Main_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.ListBox DiaryCollection;
        private System.Windows.Forms.Button ADDButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ADDTextbox;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Open_Diary;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button BackToHome;
    }
}