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
using YTKLib;
using Microsoft.Win32;
using System.Security.Cryptography;
#endregion
#region code
namespace Project_Jack
{
    public partial class SecretDiary_Writing : MetroFramework.Forms.MetroForm
    {
        bool Close1 = true;
        private int c = 0;
        private string change;
        public string Path;
        public string KEY = "ytk030305";
        public bool Premium = false;

        string Am;

        public SecretDiary_Writing()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SecretDiary_Writing_Load(object sender, EventArgs e)
        {
            RegistryKey keyreader1 = Registry.CurrentUser.OpenSubKey(@"Secret Diary\Data");
            Path = keyreader1.GetValue("DiaryPath").ToString();
            keyreader1.Close();

            ComputerInformation computer = new ComputerInformation();
            string UserName = computer.UserName;

            string value;
            string id;

            FileStream fs = new FileStream(Path + @"\SecretDiary\LatelySave.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            value = sr.ReadLine();
            sr.Close();
            fs.Close();

            FileStream fs2 = new FileStream(Path + @"\SecretDiary\log.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr2 = new StreamReader(fs2);
            id = sr2.ReadLine();
            sr2.Close();
            fs2.Close();

            FileStream tr = new FileStream(Path + @"\SecretDiary\" + id + @"_Diary\" + value + @"\title.txt", FileMode.Open, FileAccess.Read);
            StreamReader trr = new StreamReader(tr);
            Title.Text = trr.ReadLine();

            trr.Close();
            tr.Close();

            //FileStream tr2 = new FileStream(@"C:\Program Files\SecretDiary\" + id + @"_Diary\" + value + @"\diary.txt", FileMode.Open, FileAccess.Read);
            //StreamReader trr2 = new StreamReader(tr2);
            //Body.Text = trr2.ReadLine();
            //trr2.Close();
            //tr2.Close();
            FileInfo ae = new FileInfo(Path + @"\SecretDiary\" + id + @"_Diary\" + value + @"\diary.rtf");
            if(ae.Exists == false)
            {
                Body.SaveFile(Path + @"\SecretDiary\" + id + @"_Diary\" + value + @"\diary.rtf");
            }

            try
            {
                Body.LoadFile(Path + @"\SecretDiary\" + id + @"_Diary\" + value + @"\diary.rtf");
            }
            catch (IOException)
            {
                MessageBox.Show("열려는 파일이 외부 프로세스에서 사용중이거나 파일을 로드하는 동안 오류가 발생 했습니다.\n프로그램을 다시 실행해주십시오.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Secret Diary\Data");
                Am = key.GetValue("Premium").ToString();
                key.Close();

                if (Am == "true")
                {
                    Premium = true;
                }
            }
            catch (Exception)
            {

            }
            

            try
            {
                if (!(Body.Text == ""))
                {
                    if(Premium == true)
                    {
                        for (int i = 1; i <= 10; i++)
                            Body.Text = Decrypt(Body.Text, KEY);
                    }
                    else
                    {
                        Body.Text = Decrypt(Body.Text, KEY);
                    }
                }
            }catch(Exception)
            {
                Encrypt_CheckBox.CheckState = CheckState.Unchecked;
            }
            change = Body.Text;
            Timer.Start();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            //Close1 = false;
            //ComputerInformation computer = new ComputerInformation();
            //string UserName = computer.UserName;
            //string value;
            //string id;

            //FileStream fs = new FileStream(@"C:\Users\" + UserName + @"\AppData\Local\SecretDiary\LatelySave.txt", FileMode.Open, FileAccess.Read);
            //StreamReader sr = new StreamReader(fs);
            //value = sr.ReadLine();
            //sr.Close();
            //fs.Close();

            //FileStream fs2 = new FileStream(@"C:\Users\" + UserName + @"\AppData\Local\SecretDiary\log.txt", FileMode.Open, FileAccess.Read);
            //StreamReader sr2 = new StreamReader(fs2);
            //id = sr2.ReadLine();
            //sr2.Close();
            //fs2.Close();

            //FileStream tr = new FileStream(@"C:\Users\" + UserName + @"\AppData\Local\SecretDiary\" + id + @"_Diary\" + value + @"\title.txt", FileMode.Create);
            //StreamWriter trs = new StreamWriter(tr);
            //trs.Write(Title.Text);

            //trs.Close();
            //tr.Close();

            ////FileStream tr2 = new FileStream(@"C:\Program Files\SecretDiary\" + id + @"_Diary\" + value + @"\diary.txt", FileMode.Create);//Tester
            ////StreamWriter trs2 = new StreamWriter(tr2);
            ////trs2.Write(Body.Text);

            ////trs2.Close();
            ////tr2.Close();
            //Body.SaveFile(@"C:\Users\" + UserName + @"\AppData\Local\SecretDiary\" + id + @"_Diary\" + value + @"\diary.rtf");

            this.Close();
        }

        private void SecretDiary_Writing_ControlRemoved(object sender, ControlEventArgs e)
        {
            
        }

        private void SecretDiary_Writing_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void SecretDiary_Writing_FormClosing(object sender, FormClosingEventArgs e)
        {
            RegistryKey keyreader1 = Registry.CurrentUser.OpenSubKey(@"Secret Diary\Data");
            Path = keyreader1.GetValue("DiaryPath").ToString();
            keyreader1.Close();

            if (!(change == Body.Text))
            {
                if ((MessageBox.Show("저장 하시겠습니까? 확인 버튼을 누르면 저장이 되고, 취소 버튼을 누르면 작업 내용이 손실됩니다.", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK) && Close1 == true)
                {
                    ComputerInformation computer = new ComputerInformation();
                    string UserName = computer.UserName;
                    string value;
                    string id;

                    FileStream fs = new FileStream(Path + @"\SecretDiary\LatelySave.txt", FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);
                    value = sr.ReadLine();
                    sr.Close();
                    fs.Close();

                    FileStream fs2 = new FileStream(Path + @"\SecretDiary\log.txt", FileMode.Open, FileAccess.Read);
                    StreamReader sr2 = new StreamReader(fs2);
                    id = sr2.ReadLine();
                    sr2.Close();
                    fs2.Close();

                    FileStream tr = new FileStream(Path + @"\SecretDiary\" + id + @"_Diary\" + value + @"\title.txt", FileMode.Create);
                    StreamWriter trs = new StreamWriter(tr);
                    trs.Write(Title.Text);

                    trs.Close();
                    tr.Close();

                    //FileStream tr2 = new FileStream(@"C:\Program Files\SecretDiary\" + id + @"_Diary\" + value + @"\diary.txt", FileMode.Create);//Tester
                    //StreamWriter trs2 = new StreamWriter(tr2);
                    //trs2.Write(Body.Text);

                    //trs2.Close();
                    //tr2.Close();
                    if(Encrypt_CheckBox.CheckState == CheckState.Checked)
                    {
                        if (Premium == true)
                        {
                            for(int i = 1; i <= 10; i++)
                            Body.Text = Encrypt(Body.Text, KEY);
                        }
                        else
                        {
                            Body.Text = Encrypt(Body.Text, KEY);
                        }
                    }
                    
                    Body.SaveFile(Path + @"\SecretDiary\" + id + @"_Diary\" + value + @"\diary.rtf");
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var SP = 0;
            RegistryKey keyreader1 = Registry.CurrentUser.OpenSubKey(@"Secret Diary\Data");
            Path = keyreader1.GetValue("DiaryPath").ToString();
            keyreader1.Close();

            if (c == 300)
            {
                Panel.BackColor = System.Drawing.Color.Red;
                Save_Label.Text = "자동 저장중.....";
                c++;
            }
            else if(c == 330)
            {
                ComputerInformation computer = new ComputerInformation();
                string UserName = computer.UserName;
                string value;
                string id;

                SP = Body.SelectionStart;
                FileStream fs = new FileStream(Path + @"\SecretDiary\LatelySave.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                value = sr.ReadLine();
                sr.Close();
                fs.Close();

                FileStream fs2 = new FileStream(Path + @"\SecretDiary\log.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr2 = new StreamReader(fs2);
                id = sr2.ReadLine();
                sr2.Close();
                fs2.Close();

                FileStream tr = new FileStream(Path + @"\SecretDiary\" + id + @"_Diary\" + value + @"\title.txt", FileMode.Create);
                StreamWriter trs = new StreamWriter(tr);
                trs.Write(Title.Text);

                trs.Close();
                tr.Close();

                if (Encrypt_CheckBox.CheckState == CheckState.Checked)
                {
                    if(Premium == true)
                    {
                        for (int i = 1; i <= 10; i++)
                            Body.Text = Encrypt(Body.Text, KEY);
                    }
                    else
                    {
                        Body.Text = Encrypt(Body.Text, KEY);
                    }

                    try
                    {
                        Body.SaveFile(Path + @"\SecretDiary\" + id + @"_Diary\" + value + @"\diary.rtf");
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("외부의 프로세스에서 같은 파일이 열려 있으므로 파일을 저장할 수 없습니다.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    

                    if (Premium == true)
                    {
                        for (int i = 1; i <= 10; i++)
                            Body.Text = Decrypt(Body.Text, KEY);
                    }
                    else
                    {
                        Body.Text = Decrypt(Body.Text, KEY);
                    }
                }
                else
                {
                    try
                    {
                        if (Premium == true)
                        {
                            for (int i = 1; i <= 10; i++)
                                Body.Text = Decrypt(Body.Text, KEY);
                        }
                        else
                        {
                            Body.Text = Decrypt(Body.Text, KEY);
                        }
                        Body.SaveFile(Path + @"\SecretDiary\" + id + @"_Diary\" + value + @"\diary.rtf");
                        if (Premium == true)
                        {
                            for (int i = 1; i <= 10; i++)
                                Body.Text = Encrypt(Body.Text, KEY);
                        }
                        else
                        {
                            Body.Text = Encrypt(Body.Text, KEY);
                        }
                    }
                    catch (Exception)
                    {
                        Body.SaveFile(Path + @"\SecretDiary\" + id + @"_Diary\" + value + @"\diary.rtf");
                    }
                }

                Panel.BackColor = System.Drawing.Color.Cyan;
                Save_Label.Text = "자동 저장 완료";
                Body.Select(SP, 0);
                c = 0;
                change = Body.Text;
            }
            else
            {
                c++;
            }
        }

        public static string Decrypt(string textToDecrypt, string key)

        {

            RijndaelManaged rijndaelCipher = new RijndaelManaged();

            rijndaelCipher.Mode = CipherMode.CBC;

            rijndaelCipher.Padding = PaddingMode.PKCS7;



            rijndaelCipher.KeySize = 128;

            rijndaelCipher.BlockSize = 128;

            byte[] encryptedData = Convert.FromBase64String(textToDecrypt);

            byte[] pwdBytes = Encoding.UTF8.GetBytes(key);

            byte[] keyBytes = new byte[16];

            int len = pwdBytes.Length;

            if (len > keyBytes.Length)

            {

                len = keyBytes.Length;

            }

            Array.Copy(pwdBytes, keyBytes, len);

            rijndaelCipher.Key = keyBytes;

            rijndaelCipher.IV = keyBytes;

            byte[] plainText = rijndaelCipher.CreateDecryptor().TransformFinalBlock(encryptedData, 0, encryptedData.Length);

            return Encoding.UTF8.GetString(plainText);

        }



        public static string Encrypt(string textToEncrypt, string key)

        {

            RijndaelManaged rijndaelCipher = new RijndaelManaged();

            rijndaelCipher.Mode = CipherMode.CBC;

            rijndaelCipher.Padding = PaddingMode.PKCS7;



            rijndaelCipher.KeySize = 128;

            rijndaelCipher.BlockSize = 128;

            byte[] pwdBytes = Encoding.UTF8.GetBytes(key);

            byte[] keyBytes = new byte[16];

            int len = pwdBytes.Length;

            if (len > keyBytes.Length)

            {

                len = keyBytes.Length;

            }

            Array.Copy(pwdBytes, keyBytes, len);

            rijndaelCipher.Key = keyBytes;

            rijndaelCipher.IV = keyBytes;

            ICryptoTransform transform = rijndaelCipher.CreateEncryptor();

            byte[] plainText = Encoding.UTF8.GetBytes(textToEncrypt);

            return Convert.ToBase64String(transform.TransformFinalBlock(plainText, 0, plainText.Length));

        }

        private void Encrypt_CheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            change = "";
        }

        private void SecretDiary_Writing_StyleChanged(object sender, EventArgs e)
        {
        }

        private void SecretDiary_Writing_Resize(object sender, EventArgs e)
        {
            TitleBox.Width = this.Width;
            Title.Width = this.Width - 64;
            BodyBox.Width = this.Width;
            Body.Width = this.Width - 40;
            Save.Width = this.Width - 40;
            Panel.Width = this.Width;
            BodyBox.Height = this.Height - 120;
            Body.Height = this.Height - 180;
            if (WindowState == FormWindowState.Maximized)
            {
                Panel.Location = new Point(0, 1018);
                Save_Label.Location = new Point(Panel.Location.X / 2, 5);
                Save.Location = new Point(17, 880);
            }
            else if (WindowState == FormWindowState.Normal)
            {
                Panel.Location = new Point(0, 603);
                Save_Label.Location = new Point(189, 5);
                Save.Location = new Point(17, 474);
            }
        }

    }
}
#endregion
