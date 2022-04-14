using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace Demo
{
    public partial class AddInfo : Form
    {
        public static string data;
        private string Form2_value;
        public string Passvalue
        {
            get { return this.Form2_value; } // Form2에서 얻은(get) 값을 다른폼(Form1)으로 전달 목적
            set { this.Form2_value = value; }  // 다른폼(Form1)에서 전달받은 값을 쓰기
        }


        private Point point = new Point();
        public AddInfo()
        {
            InitializeComponent();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Location = new Point(this.Left - (point.X - e.X), this.Top - (point.Y - e.Y));
            }
        }
        private void textBox21_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string query = textBox21.Text;
                string url = "https://openapi.naver.com/v1/krdict/romanization?query=" + query;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Headers.Add("X-Naver-Client-Id", "eUoGnOs7Y1U_tuQRRsUY"); // 개발자센터에서 발급받은 Client ID
                request.Headers.Add("X-Naver-Client-Secret", "PZq_xY6fEg"); // 개발자센터에서 발급받은 Client Secret
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                string text = reader.ReadToEnd();

                JObject json = JObject.Parse(text);
                JToken data = json["aResult"][0]["aItems"];
                comboBox11.Items.Clear();
                for (int i = 0; i < data.Count(); i++)
                {

                    // textBox28.Text += data[i].ToString() + "\n";
                    comboBox11.Text = data[i]["name"].ToString();

                    comboBox11.Items.Add(data[i]["name"].ToString());


                    comboBox11.SelectedIndex = 0;
                }

            }
        }
        private void AddInfo_Load(object sender, EventArgs e)
        {
            textBox26.Text = Passvalue;
        }
        private void 사원변경ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeNum cnf = new ChangeNum();
            cnf.Show();
        }
        private void 변경이력ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfochangState inf = new InfochangState();
            inf.Show(); 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DepartmentSearch def = new DepartmentSearch();
            def.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            RankSearch rsf = new RankSearch();
            rsf.Show();
        }
        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {


        }
        public string autoHyphen(string tel)
        {
            string tmpTel = tel.Replace("-", "");
            string tel1 = string.Empty;
            string tel2 = string.Empty;
            string tel3 = string.Empty;
            string tel_total = string.Empty;

            if (tmpTel.Length >= 2 && tmpTel.Length < 8)
            {
                if (tmpTel.Substring(0, 2) != "02")
                {
                    if (tmpTel.Length == 3)
                    {
                        tel_total = tmpTel + "-";
                    }
                    else if (tmpTel.Length > 3 && tmpTel.Length < 6)
                    {
                        tel1 = tmpTel.Substring(0, 3);
                        tel2 = tmpTel.Substring(3, tmpTel.Length - 3);
                        tel_total = tel1 + "-" + tel2;
                    }
                    else if (tmpTel.Length > 3 && tmpTel.Length > 6)
                    {
                        tel1 = tmpTel.Substring(0, 3);
                        tel2 = tmpTel.Substring(3, 3);
                        tel3 = tmpTel.Substring(6, tmpTel.Length - 6);
                        tel_total = tel1 + "-" + tel2 + "-" + tel3;
                    }
                    else
                    {
                        tel_total = tel;
                    }
                }
                else
                {
                    if (tmpTel.Length == 2)
                    {
                        tel_total = tmpTel + "-";
                    }
                    else if (tmpTel.Length > 2 && tmpTel.Length < 6)
                    {
                        tel1 = tmpTel.Substring(0, 2);
                        tel2 = tmpTel.Substring(2, tmpTel.Length - 2);
                        tel_total = tel1 + "-" + tel2;
                    }
                    else if (tmpTel.Length > 2 && tmpTel.Length > 5)
                    {
                        tel1 = tmpTel.Substring(0, 2);
                        tel2 = tmpTel.Substring(2, 3);
                        tel3 = tmpTel.Substring(5, tmpTel.Length - 5);
                        tel_total = tel1 + "-" + tel2 + "-" + tel3;
                    }
                }
            }
            else if (tmpTel.Length == 8 && tmpTel.Substring(0, 2) == "02")
            {
                tel1 = tmpTel.Substring(0, 2);
                tel2 = tmpTel.Substring(2, 3);
                tel3 = tmpTel.Substring(3, 3);
                tel_total = tel1 + "-" + tel2 + "-" + tel3;
            }
            else if (tmpTel.Length == 8 && tmpTel.Substring(0, 2) != "02")
            {
                tel1 = tmpTel.Substring(0, 4);
                tel2 = tmpTel.Substring(4, 4);
                tel_total = tel1 + "-" + tel2;
            }
            else if (tmpTel.Length == 9 && tmpTel.Substring(0, 2) == "02")
            {
                tel1 = tmpTel.Substring(0, 2);
                tel2 = tmpTel.Substring(2, 3);
                tel3 = tmpTel.Substring(5, 4);
                tel_total = tel1 + "-" + tel2 + "-" + tel3;
            }
            else if (tmpTel.Length == 9 && tmpTel.Substring(0, 2) != "02")
            {
                tel1 = tmpTel.Substring(0, 3);
                tel2 = tmpTel.Substring(3, 4);
                tel3 = tmpTel.Substring(7, 2);
                tel_total = tel1 + "-" + tel2 + "-" + tel3;
            }
            else if (tmpTel.Length == 10 && tmpTel.Substring(0, 2) == "02")
            {
                tel1 = tmpTel.Substring(0, 2);
                tel2 = tmpTel.Substring(2, 4);
                tel3 = tmpTel.Substring(6, 4);
                tel_total = tel1 + "-" + tel2 + "-" + tel3;
            }
            else if (tmpTel.Length == 10 && tmpTel.Substring(0, 2) != "02")
            {
                tel1 = tmpTel.Substring(0, 3);
                tel2 = tmpTel.Substring(3, 3);
                tel3 = tmpTel.Substring(6, 4);
                tel_total = tel1 + "-" + tel2 + "-" + tel3;
            }
            else if (tmpTel.Length == 11)
            {
                tel1 = tmpTel.Substring(0, 3);
                tel2 = tmpTel.Substring(3, 4);
                tel3 = tmpTel.Substring(7, 4);
                tel_total = tel1 + "-" + tel2 + "-" + tel3;
            }
            else
            {
                tel_total = tmpTel;
            }
            return tel_total;
        }
        private void textBox11_KeyUp(object sender, KeyEventArgs e)
        {
            textBox11.Text = autoHyphen(textBox11.Text);
            textBox11.SelectionStart = textBox11.Text.Length;
        }
        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {
            textBox5.Text = autoHyphen(textBox5.Text);
            textBox5.SelectionStart = textBox5.Text.Length;
        }
       

        private void button4_Click(object sender, EventArgs e)
        {
            AddjicchaekForm ajcf = new AddjicchaekForm();
            ajcf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BankSearch bsh = new BankSearch();
            bsh.Show();
        }

        private void textBox37_KeyUp(object sender, KeyEventArgs e)
        {
            textBox37.Text = autoHyphen(textBox37.Text);
            textBox37.SelectionStart = textBox37.Text.Length;
        }

        private void textBox46_KeyUp(object sender, KeyEventArgs e)
        {
            textBox46.Text = autoHyphen(textBox46.Text);
            textBox46.SelectionStart = textBox46.Text.Length;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddressForm asf = new AddressForm();
            asf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            REgsteate rst = new REgsteate();
            rst.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ChangeNum cnf = new ChangeNum();
            cnf.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ChangeNum cnf = new ChangeNum();
            cnf.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            InfochangState inf = new InfochangState();
            inf.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            InfochangState inf = new InfochangState();
            inf.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            REgsteate rst = new REgsteate();
            rst.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DepartmentSearch def = new DepartmentSearch();
            def.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            RankSearch rsf = new RankSearch();
            rsf.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AddjicchaekForm ajcf = new AddjicchaekForm();
            ajcf.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string image_file = string.Empty;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"C:\";
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.* ";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fileFullName = dialog.FileName;
                image_file = dialog.FileName;
                //파일크기를 제한
                //확장자도 제어
                //이미지를 읽어서 bitmap객체를 만들어 그림을 picturebox에 이미지를 넣는다.
                //FromFile(String) = 지정된 파일에서 Image를 만듭니다.
                pictureBox1.BackgroundImage = Bitmap.FromFile(image_file);
                label24.Text = "File Path  : " + fileFullName;
            }
        }
        private string _strConn = "Data Source=222.237.134.74:1522/Ora7;User Id=edu;Password=edu1234;";
        private void button7_Click(object sender, EventArgs e)
        {
           
        }
    }
}
