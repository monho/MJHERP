using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Net;
using Oracle.ManagedDataAccess.Client;
namespace Demo
{
    public partial class MainView : Form
    {


        PersonnelbasicsForm child2 = new PersonnelbasicsForm();

        Personnelcodemanagement child3 = new Personnelcodemanagement();
        femilystate child4 = new femilystate();
        SchoolState child5 = new SchoolState();
        Rewardandpunishment child6 = new Rewardandpunishment();
        Experienceinformation child7 = new Experienceinformation();
        LicenseState child8 = new LicenseState();
        Foreignlanguageskills child9 = new Foreignlanguageskills();
        Greetinglist child10 = new Greetinglist();
        GreetingaddForm child11 = new GreetingaddForm();
        Checkgreetingcard child12 = new Checkgreetingcard();
        GreetingStatecs child13 = new GreetingStatecs();
        Employmenttypecode child14 = new Employmenttypecode();
        Certificateissued child18 = new Certificateissued();
        Certificateissuancestatus child19 = new Certificateissuancestatus();
        Statisticsofpeople child20 = new Statisticsofpeople();
        Currentstatusofthenumberofpeople child21 = new Currentstatusofthenumberofpeople();
        GroupCode child22 = new GroupCode();


        public static string notice;
        public static string sabun = "";
        int mdiID = 1;
        int testID = 1;
        int comID = 1;
        private Point point = new Point();
        //슬라이딩 메뉴의 최대, 최소 폭 크기
        const int MAX_SLIDING_WIDTH = 218;
        const int MIN_SLIDING_WIDTH = 40;
        //슬라이딩 메뉴가 보이는/접히는 속도 조절
        const int STEP_SLIDING = 10;
        //최초 슬라이딩 메뉴 크기
        int _posSliding = 200;


        
        public MainView()
        {

            InitializeComponent();
            //for (int i = 0; i < 5; i++)
            //{
            //    MDIView tv = new MDIView();
            //    tv.Text = i.ToString();
            //    this.dragDropTabControl1.AddDragDropControls(new DragDropTabPage(tv));
            //}
        }


        public MainView(string data) {

            InitializeComponent();
            label7.Text = data;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MainView_Load(object sender, EventArgs e)
        {

           
            new LoginForm().ShowDialog();
            IPHostEntry IPHost = Dns.GetHostByName(Dns.GetHostName());
            connectIp.Text = IPHost.AddressList[0].ToString();

            string title = "BsksErpSystem";
            DateTime buildDate = Convert.ToDateTime("2022-02-9");
            Version version = Assembly.GetEntryAssembly().GetName().Version;

            label6.Text = string.Format("{0} Ver {1}.{2} / Build Time ({3})",
                title,
                version.Major, version.Minor,
                buildDate.ToString("yyyy-MM-dd")
                );
            DateTime hwTime = DateTime.UtcNow;

            ConnectTime.Text = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(hwTime, "Korea Standard Time").ToString();
            child2.TopLevel = false;
            child3.TopLevel = false;
            child4.TopLevel = false;
            child5.TopLevel = false;
            child6.TopLevel = false;
            child7.TopLevel = false;
            child8.TopLevel = false;
            child9.TopLevel = false;
            child10.TopLevel = false;
            child11.TopLevel = false;
            child12.TopLevel = false;
            child13.TopLevel = false;
            child14.TopLevel = false;
            child18.TopLevel = false;
            child19.TopLevel = false;
            child20.TopLevel = false;
            child21.TopLevel = false;
            child22.TopLevel = false;


            this.Controls.Add(child2);
            this.Controls.Add(child3);
            this.Controls.Add(child4);
            this.Controls.Add(child5);
            this.Controls.Add(child6);
            this.Controls.Add(child7);
            this.Controls.Add(child8);
            this.Controls.Add(child9);
            this.Controls.Add(child10);
            this.Controls.Add(child11);
            this.Controls.Add(child12);
            this.Controls.Add(child13);
            this.Controls.Add(child14);
            this.Controls.Add(child18);
            this.Controls.Add(child19);
            this.Controls.Add(child20);
            this.Controls.Add(child21);
            this.Controls.Add(child22);


            child2.Parent = this.panel1;
            child3.Parent = this.panel1;
            child4.Parent = this.panel1;
            child5.Parent = this.panel1;
            child6.Parent = this.panel1;
            child7.Parent = this.panel1;
            child8.Parent = this.panel1;
            child9.Parent = this.panel1;
            child10.Parent = this.panel1;
            child11.Parent = this.panel1;
            child12.Parent = this.panel1;
            child13.Parent = this.panel1;
            child14.Parent = this.panel1;
            child18.Parent = this.panel1;
            child19.Parent = this.panel1;
            child20.Parent = this.panel1;
            child21.Parent = this.panel1;
            child22.Parent = this.panel1;

            Idsabun.Text = sabun;
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

        private void toolStripMenuItem36_Click(object sender, EventArgs e)
        {
            child4.Show();
            child3.Hide();
            child2.Hide();
            child5.Hide();
            child12.Hide();
            child13.Hide();
            child14.Hide();
            child18.Hide();
            child19.Hide();
            child20.Hide();
            child21.Hide();
            child22.Hide();
        }

        private void toolStripMenuItem37_Click(object sender, EventArgs e)
        {
            child5.Show();
            child4.Hide();
            child3.Hide();
            child2.Hide();
            child12.Hide();
            child13.Hide();
            child14.Hide();
            child18.Hide();
            child19.Hide();
            child20.Hide();
            child21.Hide();
            child22.Hide();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            child3.Hide();
            child2.Hide();
            child10.Hide();
            child11.Hide();
            child12.Hide();
            child13.Hide();
            child14.Show();
            child18.Hide();
            child19.Hide();
            child20.Hide();
            child21.Hide();
            child22.Hide();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            child3.Show();
            child2.Hide();
            child10.Hide();
            child12.Hide();
            child13.Hide();
            child14.Hide();
            child18.Hide();
            child19.Hide();
            child20.Hide();
            child21.Hide();
            child22.Hide();
        }
        private void toolStripMenuItem31_Click(object sender, EventArgs e)
        {

        }


        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            child3.Hide();
            child2.Hide();
            child10.Show();
            child12.Hide();
            child13.Hide();
            child14.Hide();
            child18.Hide();
            child19.Hide();
            child20.Hide();
            child21.Hide();
            child22.Hide();
        }
        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            child3.Hide();
            child2.Hide();
            child10.Hide();
            child11.Show();
            child12.Hide();
            child13.Hide();
            child14.Hide();
            child18.Hide();
            child19.Hide();
            child20.Hide();
            child21.Hide();
        }
        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            child3.Hide();
            child2.Hide();
            child10.Hide();
            child11.Hide();
            child12.Show();
            child13.Hide();
            child14.Hide();
            child18.Hide();
            child19.Hide();
            child20.Hide();
            child21.Hide();
            child22.Hide();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            child3.Hide();
            child2.Hide();
            child10.Hide();
            child11.Hide();
            child12.Hide();
            child13.Show();
            child14.Hide();
            child18.Hide();
            child19.Hide();
            child20.Hide();
            child21.Hide();
            child22.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
        private void toolStripMenuItem14_Click(object sender, EventArgs e) //입사형태
        {
            
        }
        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)//부서코드
        {
            child3.Hide();
            child2.Hide();
            child10.Hide();
            child11.Hide();
            child12.Hide();
            child13.Hide();
            child14.Hide();
            child18.Hide();
            child19.Hide();
            child20.Hide();
            child21.Hide();
            child22.Hide();
        }
        private void toolStripMenuItem11_Click(object sender, EventArgs e)//직급코드
        {
            child3.Hide();
            child2.Hide();
            child10.Hide();
            child11.Hide();
            child12.Hide();
            child13.Hide();
            child14.Hide();
            child18.Hide();
            child19.Hide();
            child20.Hide();
            child21.Hide();
            child22.Hide();
        }
        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            child3.Hide();
            child2.Hide();
            child10.Hide();
            child11.Hide();
            child12.Hide();
            child13.Hide();
            child14.Hide();
            child18.Hide();
            child19.Hide();
            child20.Hide();
            child21.Hide();
            child22.Hide();
        }
        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            child3.Hide();
            child2.Hide();
            child10.Hide();
            child11.Hide();
            child12.Hide();
            child13.Hide();
            child14.Hide();
            child18.Show();
            child19.Hide();
            child20.Hide();
            child21.Hide();
            child22.Hide();
        }
        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            child3.Hide();
            child2.Hide();
            child10.Hide();
            child11.Hide();
            child12.Hide();
            child13.Hide();
            child14.Hide();
            child18.Hide();
            child19.Show();
            child20.Hide();
            child21.Hide();
            child22.Hide();

        }
        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {

            child3.Hide();
            child2.Hide();
            child10.Hide();
            child11.Hide();
            child12.Hide();
            child13.Hide();
            child14.Hide();
            child18.Hide();
            child19.Hide();
            child20.Show();
            child21.Hide();
            child22.Hide();
        }
        private void toolStripMenuItem27_Click(object sender, EventArgs e)
        {
            child3.Hide();
            child2.Hide();
            child10.Hide();
            child11.Hide();
            child12.Hide();
            child13.Hide();
            child14.Hide();
            child18.Hide();
            child19.Hide();
            child20.Hide();
            child21.Show();
            child22.Hide();
        }
        private void toolStripMenuItem25_Click(object sender, EventArgs e)
        {

        }
        private void toolStripMenuItem25_Click_1(object sender, EventArgs e)
        {
            child3.Hide();
            child2.Hide();
            child10.Hide();
            child11.Hide();
            child12.Hide();
            child13.Hide();
            child14.Hide();
            child18.Hide();
            child19.Hide();
            child20.Hide();
            child21.Show();
            child22.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            child3.Hide();
            child2.Hide();
            child10.Hide();
            child11.Hide();
            child12.Hide();
            child13.Hide();
            child14.Hide();
            child18.Hide();
            child19.Hide();
            child20.Hide();
            child21.Hide();

            child22.noticeMessage = label7;
            child22.Show();

        }
    }
}
