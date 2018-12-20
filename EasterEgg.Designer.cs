namespace Project_Jack
{
    partial class EasterEgg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EasterEgg));
            this.Announcer = new System.Windows.Forms.Label();
            this.Number_INPUT = new System.Windows.Forms.TextBox();
            this.Check = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Minimize_Button = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Announcer
            // 
            this.Announcer.AutoSize = true;
            this.Announcer.Location = new System.Drawing.Point(208, 98);
            this.Announcer.Name = "Announcer";
            this.Announcer.Size = new System.Drawing.Size(249, 12);
            this.Announcer.TabIndex = 0;
            this.Announcer.Text = "숫자 맞추기 게임을 시작합니다.(2초 뒤 시작)";
            // 
            // Number_INPUT
            // 
            this.Number_INPUT.Location = new System.Drawing.Point(238, 138);
            this.Number_INPUT.Name = "Number_INPUT";
            this.Number_INPUT.Size = new System.Drawing.Size(175, 21);
            this.Number_INPUT.TabIndex = 1;
            this.Number_INPUT.Visible = false;
            // 
            // Check
            // 
            this.Check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Check.Location = new System.Drawing.Point(238, 165);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(175, 21);
            this.Check.TabIndex = 2;
            this.Check.Text = "확인";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Visible = false;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Minimize_Button);
            this.panel1.Controls.Add(this.Exit_Button);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 31);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // Exit_Button
            // 
            this.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Button.Location = new System.Drawing.Point(629, 2);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(26, 26);
            this.Exit_Button.TabIndex = 0;
            this.Exit_Button.Text = "X";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Minimize_Button
            // 
            this.Minimize_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_Button.Location = new System.Drawing.Point(597, 2);
            this.Minimize_Button.Name = "Minimize_Button";
            this.Minimize_Button.Size = new System.Drawing.Size(26, 26);
            this.Minimize_Button.TabIndex = 1;
            this.Minimize_Button.Text = "_";
            this.Minimize_Button.UseVisualStyleBackColor = true;
            this.Minimize_Button.Click += new System.EventHandler(this.Minimize_Button_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // EasterEgg
            // 
            this.AcceptButton = this.Check;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 309);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.Number_INPUT);
            this.Controls.Add(this.Announcer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EasterEgg";
            this.Text = "EasterEgg";
            this.Load += new System.EventHandler(this.EasterEgg_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Announcer;
        private System.Windows.Forms.TextBox Number_INPUT;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Button Minimize_Button;
        private System.Windows.Forms.Timer Timer;
    }
}