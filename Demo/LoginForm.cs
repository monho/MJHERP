using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Demo.Properties;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Demo
{
    public partial class LoginForm : Form
    {
        private Point point = new Point();
        int EXIT = Convert.ToInt32(Console.ReadLine());
        public LoginForm()
        {
            InitializeComponent();


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Location = new Point(this.Left - (point.X - e.X), this.Top - (point.Y - e.Y));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            //pictureBox4.Image = System.Drawing.Image.FromFile("C:\\Users\\MTPC4-01\\Desktop\\Myerpsystem\\Demo\\Resources\\hoverbtn.png");
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            // pictureBox4.Image = System.Drawing.Image.FromFile("C:\\Users\\MTPC4-01\\Desktop\\Myerpsystem\\Demo\\Resources\\loginbtn.png");
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private string _strConn = "Data Source=222.237.134.74:1522/Ora7;User Id=edu;Password=edu1234;";




        private void LockLogin()
        {
           
        }




        private void CheckFailCount()
        {
            using (OracleConnection conn = new OracleConnection(_strConn))
            {

                // 연결
                conn.Open();

                // 명령 객체 생성
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;

                // 파라미터 바인딩
                cmd.CommandText = "SELECT USER_NOMBER , USER_LOGIN_FAL_COUNT , USER_LOGIN_LOCK  " +
                    "FROM MJH_TINSA_USER" +
                    " WHERE USER_NOMBER = :SA AND USER_LOGIN_FAL_COUNT = 3";
                cmd.Parameters.Add(new OracleParameter("SA", IdNumber.Text));
                // 결과 리더 객체를 리턴
                OracleDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {

                    OracleConnection conn2 = new OracleConnection(_strConn);
                    conn2.Open();

                    // 명령 객체 생성
                    OracleCommand cmd2 = new OracleCommand();
                    cmd2.Connection = conn2;

                    // SQL문 지정 및 INSERT 실행
                    cmd2.CommandText = "UPDATE MJH_TINSA_USER" +
                        " SET USER_LOGIN_LOCK = 'Y'," +
                        " USER_LOCK_COUNT = USER_LOCK_COUNT + 1 " +
                        "WHERE USER_NOMBER = '" + IdNumber.Text + "'";

                    
                    cmd2.ExecuteNonQuery();

                    conn2.Close();
                    LockLogin();
                }

                else
                {

                }
            }
        }


        private void LoginUnlock()  //차단 해제
        {
            DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            string datetime = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");


            using (OracleConnection conn = new OracleConnection(_strConn))
            {

                // 연결
                conn.Open();

                // 명령 객체 생성
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;

                // 파라미터 바인딩
                cmd.CommandText = "SELECT TO_CHAR  (USER_LAST_LOGINTRY_DATE  + 1 ) AS LOCK_DATE" +
                    " , USER_LOGIN_LOCK  FROM MJH_TINSA_USER" +
                    " WHERE USER_NOMBER = :SA  " +
                    "AND USER_LOGIN_LOCK = 'Y' ";

                cmd.Parameters.Add(new OracleParameter("SA", IdNumber.Text));
                // 결과 리더 객체를 리턴
                OracleDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    if (datetime == rdr["LOCK_DATE"].ToString())
                    {
                        OracleConnection conn2 = new OracleConnection(_strConn);
                        conn2.Open();

                        // 명령 객체 생성
                        OracleCommand cmd2 = new OracleCommand();
                        cmd2.Connection = conn2;

                        // SQL문 지정 및 INSERT 실행
                        cmd2.CommandText = "UPDATE MJH_TINSA_USER SET USER_LOGIN_LOCK = 'N' WHERE USER_NOMBER  = '" + IdNumber.Text + "'";


                        cmd2.ExecuteNonQuery();

                        conn2.Close();

                    }
                    
                }

                else
                {

                }
            }
        }




        private void plusLoginFailCount()   //로그인 실패 횟수 추가
        {

            // 연결
            OracleConnection conn = new OracleConnection(_strConn);
            conn.Open();

            // 명령 객체 생성
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            // SQL문 지정 및 INSERT 실행
            cmd.CommandText = "UPDATE MJH_TINSA_USER SET " +
                "USER_LOGIN_FAL_COUNT = USER_LOGIN_FAL_COUNT + 1 , " +
                "USER_LAST_LOGINTRY_DATE  = SYSDATE  " +
                "WHERE  USER_NOMBER = '" + IdNumber.Text + "'";
            cmd.ExecuteNonQuery();

            conn.Close();

            CheckFailCount();

        }

        
        private void ResetFalCount()
        {


            // 연결
            OracleConnection conn = new OracleConnection(_strConn);
            conn.Open();

            // 명령 객체 생성
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            // SQL문 지정 및 INSERT 실행
            cmd.CommandText = "UPDATE MJH_TINSA_USER" +
                " SET USER_LOGIN_FAL_COUNT ='0'" +
               "WHERE  USER_NOMBER = '" + IdNumber.Text + "'";
            cmd.ExecuteNonQuery();

            conn.Close();

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            // LoginFailCheack();

            // return;

            
            if (IdSave.Checked == true)
            {
                Settings.Default["login_id"] = IdNumber.Text;

                Settings.Default["ckd_id"] = IdSave.Checked;
                Settings.Default.Save();
            }
            else
            {
                Settings.Default["login_id"] = "";

                Settings.Default["ckd_id"] = IdSave.Checked;
                Settings.Default.Save();
            }



            if (this.IdNumber.Text == "")
            {
                Login_Text.Text = "사번을 입력하세요.";
                //MessageBox.Show("사번을 입력하세요.", "사번 미입력", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.IdNumber.Focus();
                return;
            }

            else if (this.Pwarea.Text == "")
            {
                Login_Text.Text = "패스워드를 입력하세요.";
                //MessageBox.Show("패스워드를 입력하세요.", "패스워드 미입력", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Pwarea.Focus();
                return;
            }


            // System.DateTime.Now.ToString("yyyy");
            DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            string datetime = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            using (OracleConnection conn = new OracleConnection(_strConn))
            {
                // LoginUnlock();



                String che = "Y";
                // 연결
                conn.Open();
                // 명령 객체 생성
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                // 파라미터 바인딩
                cmd.CommandText = "SELECT " +
                    "USER_LOGIN_FAL_COUNT , USER_LOGIN_LOCK " +
                    "FROM MJH_TINSA_USER " +
                    "WHERE USER_LOGIN_LOCK ='Y'" +
                    "AND USER_NOMBER = :SA";
                cmd.Parameters.Add(new OracleParameter("SA", IdNumber.Text));
                // 결과 리더 객체를 리턴
                OracleDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    if (che == rdr["USER_LOGIN_LOCK"].ToString())
                    {
                        Login_Text.Text = "반복적인 로그인 실패로 로그인을 차단합니다. 관리자에게 문의하세요.";
                    }
                    // break;
                }
                else
                {
                    using (OracleConnection conn2 = new OracleConnection(_strConn))
                    {

                        // 연결
                        conn2.Open();

                        // 명령 객체 생성
                        OracleCommand cmd2 = new OracleCommand();
                        cmd2.Connection = conn2;

                        // 파라미터 바인딩
                        cmd2.CommandText = "SELECT USER_NOMBER , USER_LOGIN_FAL_COUNT , USER_NOMBER , USER_PW " +
                            "FROM MJH_TINSA_USER " +
                            "WHERE USER_NOMBER =  :HAk ";
                        cmd2.Parameters.Add(new OracleParameter("HAk", IdNumber.Text));
                        //cmd.Parameters.Add(new OracleParameter("PW", Pwarea.Text));
                        // 결과 리더 객체를 리턴
                        OracleDataReader rdr2 = cmd2.ExecuteReader();

                        if (rdr2.Read())
                        {
                            if (Pwarea.Text == rdr2["USER_PW"].ToString())
                            {
                                MessageBox.Show(IdNumber.Text + "님 반갑습니다.", "로그인 성공");
                                MainView.sabun = IdNumber.Text;
                                ResetFalCount();
                                this.Close();
                            }
                            else
                            {
                                plusLoginFailCount();
                                Login_Text.Text = "로그인 실패";
                                Pwarea.Clear();
                            }
                        }
                        else
                        {
                            //
                        }
                    }
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            string userName = null;
            using (System.Security.Principal.WindowsIdentity wi = System.Security.Principal.WindowsIdentity.GetCurrent())
            {
                userName = wi.Name;
            }
            //MessageBox.Show(userName);
            IdNumber.Text = Settings.Default["login_id"].ToString();
            IdSave.Checked = Settings.Default.ckd_id;
            Login_Text.Enabled = false;
        }
        private void Pwarea_KeyDown(object sender, KeyEventArgs e)
        {  
        }
    }
}
