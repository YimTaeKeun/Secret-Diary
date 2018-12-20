#region using문
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using YTKLib;
using Microsoft.Win32;
#endregion
#region code
namespace Project_Jack
{
    public partial class SecretDiary_Main : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Administrator\Documents\ServerForProjectJack.mdf;Integrated Security = True; Connect Timeout = 30");
        private Point mousePoint;
        public string Path;

        public SecretDiary_Main()
        {
            InitializeComponent();
        }

        private void ADDButton_Click(object sender, EventArgs e)
        {
            ComputerInformation computer = new ComputerInformation();
            string UserName = computer.UserName;

            RegistryKey keyreader1 = Registry.CurrentUser.OpenSubKey(@"Secret Diary\Data");
            Path = keyreader1.GetValue("DiaryPath").ToString();
            keyreader1.Close();

            if (!(ADDTextbox.TextLength == 0))
            {
                FileStream fs = new FileStream(Path + @"\SecretDiary\log.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string value = sr.ReadLine();

                string WhereSave = Path + @"\SecretDiary\" + value + @"_Diary";
                DirectoryInfo dir = new DirectoryInfo(WhereSave + @"\" + ADDTextbox.Text);

                if (dir.Exists == false)
                {
                    dir.Create();
                }

                string WhereSave2 = Path + @"\SecretDiary\" + value + @"_Diary" + @"\" + ADDTextbox.Text;
                DirectoryInfo dir2 = new DirectoryInfo(WhereSave2 + @"\cache");

                if (dir2.Exists == false)
                {
                    dir2.Create();
                    DiaryCollection.Items.Add(ADDTextbox.Text);

                    FileStream title = new FileStream(Path + @"\SecretDiary\" + value + @"_Diary" + @"\" + ADDTextbox.Text + @"\title.txt", FileMode.Create);
                    title.Close();

                    //FileStream diary = new FileStream(@"C:\Program Files\SecretDiary\" + value + @"_Diary" + @"\" + ADDTextbox.Text + @"\diary.rtf", FileMode.Create);
                    //diary.Close();

                }
                else
                {
                    MessageBox.Show("이미 같은 이름을 가진 파일이 있습니다.");
                }
                if(DiaryCollection.Height < 460)
                {
                    DiaryCollection.Height = DiaryCollection.ItemHeight * (DiaryCollection.Items.Count + 1);
                }
                sr.Close();
                fs.Close();

                ADDTextbox.Clear();
                
            }
            else
            {
                MessageBox.Show("다이어리 제목을 입력해주세요");
            }
        }

        private void DiaryCollection_DoubleClick(object sender, EventArgs e)
        {
            RegistryKey keyreader1 = Registry.CurrentUser.OpenSubKey(@"Secret Diary\Data");
            Path = keyreader1.GetValue("DiaryPath").ToString();
            keyreader1.Close();

            ComputerInformation computer = new ComputerInformation();
            string UserName = computer.UserName;
            if (DiaryCollection.SelectedIndex > -1)
            {
                FileStream final = new FileStream(Path + @"\SecretDiary\LatelySave.txt", FileMode.Create);
                StreamWriter fine = new StreamWriter(final);
                fine.Write((string)DiaryCollection.SelectedItem);
                fine.Close();
                SecretDiary_Writing sew = new SecretDiary_Writing();
                sew.Show();
            }
            else
            {
                MessageBox.Show("원하는 다이어리를 선택해주세요.");
            }
        }

        private void DiaryCollection_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void SecretDiary_Main_Load(object sender, EventArgs e)
        {
            
        }

        private void DiaryCollection_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.AcceptButton = this.Open_Diary;
        }

        private void SecretDiary_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            ComputerInformation computer = new ComputerInformation();
            string UserName = computer.UserName;

            RegistryKey keyreader1 = Registry.CurrentUser.OpenSubKey(@"Secret Diary\Data");
            Path = keyreader1.GetValue("DiaryPath").ToString();
            keyreader1.Close();

            if (!(DiaryCollection.Items.Count == 0))
            {
                
                FileStream fs = new FileStream(Path + @"\SecretDiary\log.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string value = sr.ReadLine();
                fs.Close();
                sr.Close();

                for (int i = 0; i < DiaryCollection.Items.Count; i++)
                {
                    FileStream fs2 = new FileStream(Path + @"\SecretDiary\" + value + @"_Diary\" + i + ".txt", FileMode.Create);
                    StreamWriter sw2 = new StreamWriter(fs2);
                    DiaryCollection.SetSelected(i, true);
                    sw2.Write(DiaryCollection.GetItemText(DiaryCollection.SelectedItem).ToString());
                    sw2.Close();
                }

                FileStream save = new FileStream(Path + @"\SecretDiary\" + value + @"_Diary\ItemsCount.txt", FileMode.Create);
                StreamWriter skw = new StreamWriter(save);
                skw.WriteLine(DiaryCollection.Items.Count.ToString());
                skw.Close();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            ComputerInformation computer = new ComputerInformation();
            string UserName = computer.UserName;

            RegistryKey keyreader1 = Registry.CurrentUser.OpenSubKey(@"Secret Diary\Data");
            Path = keyreader1.GetValue("DiaryPath").ToString();
            keyreader1.Close();

            if (DiaryCollection.SelectedIndex > -1)
            {
                if (MessageBox.Show("삭제 하시겠습니까? 확인 버튼을 누르면 삭제됩니다.", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    FileStream fs = new FileStream(Path + @"\SecretDiary\log.txt", FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);
                    string value = sr.ReadLine();

                    string wheredelete = Path + @"\SecretDiary\" + value + "_Diary";
                    DirectoryInfo di2 = new DirectoryInfo(wheredelete + @"\" + (string)DiaryCollection.SelectedItem);
                    if (di2.Exists == false)
                    {
                        MessageBox.Show("파일이 시스템상에서 이미 사라져있습니다.");
                        DiaryCollection.Items.RemoveAt(DiaryCollection.SelectedIndex);
                        if (DiaryCollection.Items.Count > 0)
                            DiaryCollection.SetSelected(0, true);
                    }
                    else
                    {
                        di2.Delete(true);
                        DiaryCollection.Items.RemoveAt(DiaryCollection.SelectedIndex);
                        if (DiaryCollection.Items.Count > 0)
                            DiaryCollection.SetSelected(0, true);
                    }
                }
            }
            else
            {
                MessageBox.Show("삭제할 다이어리 제목을 선택해주세요");
            }
        }

        private void SecretDiary_Main_Shown(object sender, EventArgs e)
        {
            ComputerInformation computer = new ComputerInformation();
            string UserName = computer.UserName;

            RegistryKey keyreader1 = Registry.CurrentUser.OpenSubKey(@"Secret Diary\Data");
            Path = keyreader1.GetValue("DiaryPath").ToString();
            keyreader1.Close();

            FileStream fs = new FileStream(Path + @"\SecretDiary\log.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string value = sr.ReadLine();
            fs.Close();
            sr.Close();

            FileStream fs2 = new FileStream(Path + @"\SecretDiary\" + value + @"_Diary\ItemsCount.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr2 = new StreamReader(fs2);
            int count = Convert.ToInt32(sr2.ReadLine());
            fs2.Close();
            sr2.Close();
            if (!(count == ' '))
            {
                for (int i = 0; i < count; i++)
                {
                    FileStream ge = new FileStream(Path + @"\SecretDiary\" + value + @"_Diary\" + i + ".txt", FileMode.Open, FileAccess.Read);
                    StreamReader reader = new StreamReader(ge);
                    string item = reader.ReadToEnd();
                    reader.Close();
                    DirectoryInfo check = new DirectoryInfo(Path + @"\SecretDiary\" + value + @"_Diary\" + item);
                    if(!(check.Exists == false))
                    {
                        DiaryCollection.Items.Add(item);
                        DiaryCollection.SetSelected(0, true);
                    }
                }
            }
            DiaryCollection.Height = DiaryCollection.ItemHeight * (DiaryCollection.Items.Count + 1);
        }

        private void DiaryCollection_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Open_Diary_Click(object sender, EventArgs e)
        {

            RegistryKey keyreader1 = Registry.CurrentUser.OpenSubKey(@"Secret Diary\Data");
            Path = keyreader1.GetValue("DiaryPath").ToString();
            keyreader1.Close();

            ComputerInformation computer = new ComputerInformation();
            string UserName = computer.UserName;
            if(DiaryCollection.SelectedIndex > -1)
            {
                FileStream final = new FileStream(Path + @"\SecretDiary\LatelySave.txt", FileMode.Create);
                StreamWriter fine = new StreamWriter(final);
                fine.Write((string)DiaryCollection.SelectedItem);
                fine.Close();
                SecretDiary_Writing sew = new SecretDiary_Writing();
                sew.Show();
            }
            else
            {
                MessageBox.Show("원하는 다이어리를 선택해주세요.");
            }
        }

        private void ADDTextbox_MouseDown(object sender, MouseEventArgs e)
        {
            this.AcceptButton = this.ADDButton;
        }

        private void SecretDiary_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void DiaryCollection_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void DiaryCollection_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                this.Top - (mousePoint.Y - e.Y));
            }
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

        private void BackToHome_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Close();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void SecretDiary_Main_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void SecretDiary_Main_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                this.Top - (mousePoint.Y - e.Y));
            }
        }
    }
}
#endregion
