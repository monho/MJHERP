using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Oracle.ManagedDataAccess.Client;

namespace Demo
{
    public partial class GroupCode : Form
    {
        String notice = "입력모드가 활성화되어 조회버튼이 비활성화 되었습니다.";
        String notice2 = "등록이 완료되었습니다.";
        public Label noticeMessage;
        private bool query_sw = false;
        private bool select_sw = false;
        private OracleConnection con = null;
        public GroupCode()
        {
            InitializeComponent();
        }
        private void GroupCode_Load(object sender, EventArgs e)
        {
            string connectString = "Data Source=/ora7;User Id=;Password=";
            //            string connectString = "Data Source=.../;User Id=charm_user;Password=";
            con = new OracleConnection(connectString);
            con.Open();
            this.dataGridView2.DefaultCellStyle.ForeColor = Color.Black;
        }
        private void reload() {
            /*JyrSub015 OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "TAB");
            dataGridView.DataSource = ds.Tables["TAB"]; */

            query_sw = true;
            dataGridView2.Rows.Clear();
            int rowIdx = 0;
            DataGridViewRow row;

            OracleCommand cmd = con.CreateCommand();
            String sql = " select CDG_GRPCD,CDG_GRPNM, CDG_DIGIT,  CDG_LENGTH, CDG_USE , CDG_KIND   from MJH_TINSA_CDG ";
            cmd.CommandText = sql;

            OracleDataReader dr = cmd.ExecuteReader();//데이터어뎁터말고 데이터리더
            while (dr.Read())//하나씩 가져오는거(next)
            {
                rowIdx = dataGridView2.Rows.Add();
                row = dataGridView2.Rows[rowIdx];
                row.Cells["GRPCD"].Value = dr["CDG_GRPCD"].ToString();
                row.Cells["GRPNM"].Value = dr["CDG_GRPNM"].ToString();
                row.Cells["DIGIT"].Value = dr["CDG_DIGIT"].ToString();
                row.Cells["LENGTH"].Value = dr["CDG_LENGTH"].ToString();
                row.Cells["USE"].Value = dr["CDG_USE"].ToString();
                row.Cells["KIND"].Value = dr["CDG_KIND"].ToString();
                row.Cells["HiddenCode"].Value = dr["CDG_GRPCD"].ToString();
                row.Cells["status"].Value = "";
            }
            dr.Close();
            query_sw = false;
            // 조회된 그리드에 첫번째로 row행으로 이동
            try
            {
                dataGridView2.CurrentCell = dataGridView2.Rows[0].Cells[0];
            }
            catch (Exception sibal)
            {




            }

            //첫번째 row행의 data를 text박스에 display();
            this.dataGridView2_SelectionChanged(null, null);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            /*JyrSub015 OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "TAB");
            dataGridView.DataSource = ds.Tables["TAB"]; */

            query_sw = true;
            dataGridView2.Rows.Clear();
            int rowIdx = 0;
            DataGridViewRow row;

            OracleCommand cmd = con.CreateCommand();
            String sql = " select CDG_GRPCD,CDG_GRPNM, CDG_DIGIT,  CDG_LENGTH, CDG_USE , CDG_KIND   from MJH_TINSA_CDG ";
            cmd.CommandText = sql;
           
            OracleDataReader dr = cmd.ExecuteReader();//데이터어뎁터말고 데이터리더
            while (dr.Read())//하나씩 가져오는거(next)
            {
                rowIdx = dataGridView2.Rows.Add();
                row = dataGridView2.Rows[rowIdx];
                row.Cells["GRPCD"].Value = dr["CDG_GRPCD"].ToString();
                row.Cells["GRPNM"].Value = dr["CDG_GRPNM"].ToString();
                row.Cells["DIGIT"].Value = dr["CDG_DIGIT"].ToString();
                row.Cells["LENGTH"].Value = dr["CDG_LENGTH"].ToString();
                row.Cells["USE"].Value = dr["CDG_USE"].ToString();
                row.Cells["KIND"].Value = dr["CDG_KIND"].ToString();
                row.Cells["HiddenCode"].Value = dr["CDG_GRPCD"].ToString();
                row.Cells["status"].Value = "";
            }
            dr.Close();
            query_sw = false;
            // 조회된 그리드에 첫번째로 row행으로 이동
            try
            {
                dataGridView2.CurrentCell = dataGridView2.Rows[0].Cells[0];


            }
            catch (Exception sibal)
            {
             



            }

            //첫번째 row행의 data를 text박스에 display();
            this.dataGridView2_SelectionChanged(null, null);

        }

        private Control GetControlByName(Control control, String col_name)
        {
            string ctl_name = "CDG_" + col_name;

            Control[] ctl = control.Controls.Find(ctl_name, true);
            return ctl.Length == 0 ? null : ctl[0];
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            // row선택할때마다 이벤트 발생
            // 조회버튼을 클릭하고 첫번째가 선택되었을때는 수행않음
            if (query_sw) return;
            //그리드뷰에 행이 없을때는 수행않음
            if (dataGridView2.Rows.Count == 0) return;
            //그리드뷰에 선택된 행이 없을때는 수행않음
            if (dataGridView2.SelectedRows.Count == 0) return;

            select_sw = true;
            Type type;
            PropertyInfo pi;
            Control ctl;
            for (int col = 0; col < dataGridView2.ColumnCount; col++)
            {
                ctl = GetControlByName(panel3, dataGridView2.Columns[col].Name);

                if (ctl == null) continue;

                type = ctl.GetType();
                pi = null;

                pi = type.GetProperty("Text");
                if (pi != null)
                {
                    pi.SetValue(ctl, dataGridView2.SelectedRows[0].Cells[col].Value?.ToString()); // Cell이 Number Format일때 Control에 String으로 Assign
                }

            }
            select_sw = false;
        }


        
        private void button3_Click(object sender, EventArgs e)
        {
            
            noticeMessage.Text = notice;
            //그리드 뷰에 AllowUserToAddRows =flase ;
            // selectionMode = FullRowSelect;
            //현재 위치에 있는 row위치의 인덱스 값을 이용해서 row 삽입
            var rowIdx = dataGridView2.CurrentRow == null ? 0 : dataGridView2.CurrentRow.Index;

            if (dataGridView2.Rows.Count == 0)
            {
                rowIdx = dataGridView2.Rows.Add();
            }
            else
            {
                rowIdx++;
                dataGridView2.Rows.Insert(rowIdx);
            }
            dataGridView2.Rows[rowIdx].Cells["status"].Value = "A";
            //---추가된 Row로 Focus 이동-------------------------------- 
            dataGridView2.CurrentCell = dataGridView2.Rows[rowIdx].Cells[0];
            // ct_dept_code.Focus();
            button4.Enabled = false;


            //textBox3.Text = "입력모드가 활성화되어 조회버튼이 비활성화 됩니다.";





            //label7.Visible = false;
            //Button.ForeColor = sender.enabled == false ? Color.Blue : Color.Red;
        }
        private string _strConn = ";";

        private void Updatedate()
        {
            DataGridViewRow row = dataGridView2.CurrentRow;

            MessageBox.Show("ff");

            OracleConnection conn2 = new OracleConnection(_strConn);
            conn2.Open();

            // 명령 객체 생성
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn2;

            // SQL문 지정 및 INSERT 실행
            cmd2.CommandText = "UPDATE MJH_TINSA_CDG SET " +
            "CDG_GRPCD = :CDG_GRPCD, " +
            "CDG_GRPNM = :CDG_GRPNM, " +
            "CDG_DIGIT = :CDG_DIGIT, " +
            "CDG_LENGTH =:CDG_LENGTH , " +
            "CDG_USE = :CDG_USE, " +
            "CDG_KIND = :CDG_KIND  " +
            "WHERE CDG_GRPCD = '" + CDG_HiddenCode.Text + "' ";

            cmd2.Parameters.Add(new OracleParameter("CDG_GRPCD", CDG_GRPCD.Text));
            cmd2.Parameters.Add(new OracleParameter("CDG_GRPNM", CDG_GRPNM.Text));
            cmd2.Parameters.Add(new OracleParameter("CDG_DIGIT", CDG_DIGIT.Text));
            cmd2.Parameters.Add(new OracleParameter("CDG_LENGTH", CDG_LENGTH.Text));
            cmd2.Parameters.Add(new OracleParameter("CDG_USE", CDG_USE.Text));
            cmd2.Parameters.Add(new OracleParameter("CDG_KIND", CDG_KIND.Text));
          //  cmd2.Parameters.Add(new OracleParameter("CDG_GRPCD", CDG_HiddenCode.Text));





         



            try
            {
                cmd2.ExecuteNonQuery();


                MessageBox.Show("수정이 완료되었습니다.");
            }

            catch (OracleException ex)
            {
                if (ex.Number == 1)
                {
                    MessageBox.Show(row.Cells["GRPCD"].Value + "코드가 중복 되었습니다.",
                "중복된 코드 입력",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);  //!로 표시
                }

                else

                {
                    MessageBox.Show(ex.Message);
                }
            }

            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message);
            }

            finally
            {
                conn2.Close();
            }
        }

        private void Checkstate()
        { 


            DataGridViewRow row = dataGridView2.CurrentRow;
            //신규 입력중인 자료는 단순하게 Grid에서 제거만 한다.
            if ((String)row.Cells["status"].Value == "A")
            {
                   OracleConnection conn2 = new OracleConnection(_strConn);
                            conn2.Open();

                            // 명령 객체 생성
                            OracleCommand cmd2 = new OracleCommand();
                            cmd2.Connection = conn2;

                            // SQL문 지정 및 INSERT 실행
                            cmd2.CommandText = "INSERT INTO MJH_TINSA_CDG(CDG_GRPCD , CDG_GRPNM , CDG_DIGIT, CDG_LENGTH,CDG_USE, CDG_KIND ) VALUES('" + CDG_GRPCD.Text + "','" + CDG_GRPNM.Text + "' , '" + CDG_DIGIT.Text + "', '" + CDG_LENGTH.Text + "', '" + CDG_USE.SelectedItem + "' , '" + CDG_KIND.Text + "')";



                            try
                            {
                                cmd2.ExecuteNonQuery();
                                 noticeMessage.Text = notice2;
                }

                            catch (OracleException ex)
                            {
                                if (ex.Number == 1)
                                {
                                    MessageBox.Show(row.Cells["GRPCD"].Value + "코드가 중복 되었습니다.",
                                "중복된 코드 입력",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);  //!로 표시
                                }

                                else

                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }

                            catch (Exception ex2)
                            {
                                MessageBox.Show(ex2.Message);
                            }

                            finally
                            {
                                conn2.Close();
                            }



            }
        }
            private void button6_Click(object sender, EventArgs e)
            {
            if (CDG_GRPCD.Text.Length == 0)
            {
                MessageBox.Show(label1.Text + "의 내용이 비어있습니다.");
                return;
            }
            else if (CDG_GRPNM.Text.Length == 0)
            {
                MessageBox.Show(label2.Text + "의 내용이 비어있습니다.");
                return;
            }
            else if (CDG_DIGIT.Text.Length == 0)
            {
                MessageBox.Show(label4.Text + "의 내용이 비어있습니다.");
                return;
            }
            else if (CDG_LENGTH.Text.Length == 0)
            {
                MessageBox.Show(label3.Text + "의 내용이 비어있습니다.");
                return;
            }
            else if (CDG_DIGIT.Text.Length == 0)
            {
                MessageBox.Show(label9.Text + "의 내용이 비어있습니다.");
                return;
            }
            else if (CDG_KIND.Text.Length == 0)
            {
                MessageBox.Show(label8.Text + "의 내용이 비어있습니다.");
                return;
            }
            Checkstate();
                button4.Enabled = true;


            DataGridViewRow row = dataGridView2.CurrentRow;
            if ((String)row.Cells["status"].Value == "U")
            {
                Updatedate();


                reload();
            }

            }

        private void CDG_GRPCD_TextChanged(object sender, EventArgs e)
        {
            //행이 선택되어 값이 바뀐경우에는 return ;

            if (select_sw) return; //GridView 선택 시 최초값 설정에 따른 이벤트는 무시

            if (dataGridView2.SelectedRows.Count <= 0) return; //선택된게 없을때 컨트롤 바꿔도 무시


            Control ctl = sender as Control;
            DataGridViewRow row = dataGridView2.CurrentRow;

            if (row == null) return;

            string col_name = ctl.Name.Substring(4);

            Type type = ctl.GetType();
            PropertyInfo pi = null;

            pi = type.GetProperty("Text");
            if (pi != null)
            {
                row.Cells[col_name].Value = 0;
                row.Cells[col_name].Value = pi.GetValue(ctl);

            }
            //*--Data Status = "수정"  설정-------------------

            if ((String)row.Cells["status"].Value == "")
            {
                row.Cells["status"].Value = "U";
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (dataGridView2.SelectedRows.Count < 1)
                {
                    MessageBox.Show("삭제할 자료를 먼저 선택하세요.", "삭제확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DataGridViewRow row = dataGridView2.CurrentRow;
                //신규 입력중인 자료는 단순하게 Grid에서 제거만 한다.
                if ((String)row.Cells["status"].Value == "A")
                {
                    dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
                    return;
                }
                DialogResult result = MessageBox.Show(row.Cells["GRPNM"].Value +
                                      " 자료를 삭제하시겠습니까.", "삭제확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No) return;

                //--DB Handling(Start)-------------------------------------
                try
                {
                    string value1 = row.Cells[1].Value.ToString();
                    OracleConnection conn = new OracleConnection(_strConn);
                    conn.Open();

                    // 명령 객체 생성
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;

                    // SQL문 지정 및 INSERT 실행
                    cmd.CommandText = "DELETE FROM" +
                        " MJH_TINSA_CDG " +
                        "WHERE CDG_GRPCD = :CDG_GRPCD";

                    cmd.Parameters.Add(new OracleParameter("CDG_GRPCD", value1.ToString()));
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    // db에서 직접 날리기
                    dataGridView2.Rows.RemoveAt(row.Index);
                    MessageBox.Show("자료가 정상적으로 삭제 되었습니다.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                finally
                {
                    //if (con != null) con.Close();
                }
                if (dataGridView2.RowCount != 0) return;

                // select_sw = true;
                // Utility.SetTextNull(data_panel);
                // select_sw = false;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            /*JyrSub015 OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "TAB");
            dataGridView.DataSource = ds.Tables["TAB"]; */

            query_sw = true;
            dataGridView2.Rows.Clear();
            int rowIdx = 0;
            DataGridViewRow row;

            OracleCommand cmd = con.CreateCommand();
            String sql = " select CDG_GRPCD,CDG_GRPNM, CDG_DIGIT,  CDG_LENGTH, CDG_USE , CDG_KIND   from MJH_TINSA_CDG " +
                         " where CDG_GRPCD like :CDG_GRPCD " +
                         "AND CDG_GRPNM like :CDG_GRPNM";
            cmd.CommandText = sql;
            cmd.Parameters.Add("CDG_GRPCD", OracleDbType.Varchar2).Value = "%" + textBox1.Text + "%";
            cmd.Parameters.Add("CDG_GRPNM", OracleDbType.Varchar2).Value = "%" + textBox2.Text + "%";
            OracleDataReader dr = cmd.ExecuteReader();//데이터어뎁터말고 데이터리더
            while (dr.Read())//하나씩 가져오는거(next)
            {
                rowIdx = dataGridView2.Rows.Add();
                row = dataGridView2.Rows[rowIdx];
                row.Cells["GRPCD"].Value = dr["CDG_GRPCD"].ToString();
                row.Cells["GRPNM"].Value = dr["CDG_GRPNM"].ToString();
                row.Cells["DIGIT"].Value = dr["CDG_DIGIT"].ToString();
                row.Cells["LENGTH"].Value = dr["CDG_LENGTH"].ToString();
                row.Cells["USE"].Value = dr["CDG_USE"].ToString();
                row.Cells["KIND"].Value = dr["CDG_KIND"].ToString();
                row.Cells["status"].Value = "";
            }
            dr.Close();
            query_sw = false;
            // 조회된 그리드에 첫번째로 row행으로 이동
            try
            {
                dataGridView2.CurrentCell = dataGridView2.Rows[0].Cells[0];
            }
            catch (Exception sibal)
            {
                MessageBox.Show("다시 검색 ㄱ");



            }

            //첫번째 row행의 data를 text박스에 display();
            this.dataGridView2_SelectionChanged(null, null);

            button4.Enabled = true;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
