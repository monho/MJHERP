using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Demo
{
    public partial class GroupcodeSearch : Form
    {



        private Point point = new Point();

        private bool query_sw = false;
        private bool select_sw = false;
        private OracleConnection con = null;
        public GroupcodeSearch()
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

        private void GroupcodeSearch_Load(object sender, EventArgs e)
        {
            string connectString = "Data Source=222.237.134.74:1522/ora7;User Id=edu;Password=edu1234";
            //            string connectString = "Data Source=218.236.176.6:1521/ora7;User Id=charm_user;Password=bsks1004";
            con = new OracleConnection(connectString);
            con.Open();


            /*JyrSub015 OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "TAB");
            dataGridView.DataSource = ds.Tables["TAB"]; */

            query_sw = true;
            dataGridView1.Rows.Clear();
            int rowIdx = 0;
            DataGridViewRow row;

            OracleCommand cmd = con.CreateCommand();
            String sql = " select CDG_GRPCD, CDG_GRPNM from MJH_TINSA_CDG ";
            cmd.CommandText = sql;
            OracleDataReader dr = cmd.ExecuteReader();//데이터어뎁터말고 데이터리더
            while (dr.Read())//하나씩 가져오는거(next)
            {
                rowIdx = dataGridView1.Rows.Add();
                row = dataGridView1.Rows[rowIdx];
                row.Cells["GRPCD"].Value = dr["CDG_GRPCD"].ToString();
                row.Cells["GRPNM"].Value = dr["CDG_GRPNM"].ToString();
            }
            dr.Close();
            query_sw = false;
            // 조회된 그리드에 첫번째로 row행으로 이동
            try
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
            }
            catch (Exception sibal)
            {




            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            Employmenttypecode frm2 = new Employmenttypecode(); // Form2형 frm2 인스턴스화(객체 생성)

            string data = row.Cells[0].Value.ToString(); // row의 컬럼
            frm2.Passvalue = data; // 전달자(Passvalue)를 통해서 Form2 로 전달
            Employmenttypecode.data = data;
            this.Close();

            frm2.Refresh();

        }
    }
}
