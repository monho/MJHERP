using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Net;


namespace Demo
{
    public partial class AddressForm : Form
    {
        public static string data;
        private string Form2_value;
        public string Passvalue
        {
            get { return this.Form2_value; } // Form2에서 얻은(get) 값을 다른폼(Form1)으로 전달 목적
            set { this.Form2_value = value; }  // 다른폼(Form1)에서 전달받은 값을 쓰기
        }


        string currentPage = "1";  //현재 페이지
        string countPerPage = "100"; //1페이지당 출력 갯수 (100개로 제한되어 있음)
        string confmKey = "devU01TX0FVVEgyMDIyMDQxMzE1NTg1NTExMjQ2MTE=";
        //테스트 Key (개발  사용기간 : 2019-11-08 ~ 2020-02-06 )
        string keyword = string.Empty;
        string apiurl = string.Empty;


        private Point point = new Point();
        public AddressForm()
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            try
            {
                keyword = search_text.Text.Trim();
                apiurl = "http://www.juso.go.kr/addrlink/addrLinkApi.do?currentPage=" + currentPage +
                         "&countPerPage=" + countPerPage + "&keyword=" + keyword + "&confmKey=" + confmKey;

                WebClient wc = new WebClient();

                XmlReader read = new XmlTextReader(wc.OpenRead(apiurl));

                DataSet ds = new DataSet();
                ds.ReadXml(read);

                DataRow[] rows = ds.Tables[0].Select();
                DataRow[] rows2 = ds.Tables[1].Select();
                int rowIdx = 0;
                DataGridViewRow row;
                if (rows[0]["totalCount"].ToString() != "0")
                {


                }
                foreach (DataRow rw in rows2)
                {

                    rowIdx = dataGridView1.Rows.Add();
                    row = dataGridView1.Rows[rowIdx];
                    dataGridView1.Rows[rowIdx].Cells["roadAddrPart1"].Value = rw["roadAddrPart1"].ToString();
                    dataGridView1.Rows[rowIdx].Cells["jibunAddr"].Value = rw["jibunAddr"].ToString();
                    dataGridView1.Rows[rowIdx].Cells["zipNo"].Value = rw["zipNo"].ToString();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            AddInfo frm2 = new AddInfo(); // Form2형 frm2 인스턴스화(객체 생성)

            string data = row.Cells[0].Value.ToString(); // row의 컬럼
            frm2.Passvalue = data; // 전달자(Passvalue)를 통해서 Form2 로 전달
            Employmenttypecode.data = data;
            this.Close();

            frm2.Refresh();
        }
    }
}
