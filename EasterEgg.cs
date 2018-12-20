using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Win32;

namespace Project_Jack
{
    public partial class EasterEgg : Form
    {
        private int c = 0, rd = 0;
        Random rnd = new Random();
        private Point mousePoint;
        public EasterEgg()
        {
            InitializeComponent();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(c == 20)
            {
                Timer.Stop();
                Announcer.Text = "컴퓨터가 1~1000까지의 숫자를 뽑았습니다. 이 숫자를 맞춰 보세요.";
                Number_INPUT.Visible = true;
                Check.Visible = true;
            }
            else
            {
                c++;
            }
        }

        private void EasterEgg_Load(object sender, EventArgs e)
        {
            Timer.Start();
            rd = rnd.Next(1, 1000);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void Check_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(Number_INPUT.Text == ""))
                {
                    if(Number_INPUT.Text == "cheat")
                    {
                        Number_INPUT.Text = rd.ToString();
                    }
                    else if(Number_INPUT.Text == "5061165")
                    {
                        TopMost = true;
                        MessageBox.Show("clear");
                        Announcer.Text = "Congratulation!!! You were PROMOTED!!!!\nYour Level is Premium.....Join your LEVEL!!!\n***기존의 다이어리의 암호화 체크박스가 해제됩니다.";
                        Number_INPUT.Visible = false;
                        Check.Visible = false;
                        LoginForm lf = new LoginForm();
                        RegistryKey rkey = Registry.CurrentUser.CreateSubKey("Secret Diary").CreateSubKey("Data");
                        rkey.SetValue("Premium", "true");
                        rkey.Close();
                        lf.Show();
                        TopMost = false;
                    }
                    else
                    {
                        if (Number_INPUT.Text == rd.ToString())
                        {
                            TopMost = true;
                            MessageBox.Show("clear");
                            Announcer.Text = "Administrator KEY ID is ytk030305\nPassword is ytk10122713";
                            Number_INPUT.Visible = false;
                            Check.Visible = false;
                            LoginForm lf = new LoginForm();
                            lf.IDTextbox.Text = "ytk030305";
                            lf.PasswordTextbox.Text = "ytk10122713";
                            RegistryKey rkey = Registry.CurrentUser.CreateSubKey("Secret Diary").CreateSubKey("Data");
                            rkey.SetValue("Administrator_Mode", "true");
                            rkey.Close();
                            lf.Show();
                            TopMost = false;

                        }
                        else
                        {
                            if (Convert.ToInt32(Number_INPUT.Text) > rd)
                            {
                                MessageBox.Show("당신이 뽑은 숫자가 더 큽니다.");
                            }
                            else if (Convert.ToInt32(Number_INPUT.Text) < rd)
                            {
                                MessageBox.Show("컴퓨터가 뽑은 숫자가 더 큽니다.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("숫자를 입력해주세요.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
        }
    }
}
