
namespace Demo
{
    partial class GroupCode
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRPCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRPNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIGIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LENGTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KIND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HiddenCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CDG_HiddenCode = new System.Windows.Forms.TextBox();
            this.CDG_KIND = new System.Windows.Forms.TextBox();
            this.CDG_USE = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CDG_DIGIT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CDG_LENGTH = new System.Windows.Forms.TextBox();
            this.CDG_GRPNM = new System.Windows.Forms.TextBox();
            this.CDG_GRPCD = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "코드명";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(175, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(72, 21);
            this.textBox2.TabIndex = 14;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.status,
            this.GRPCD,
            this.GRPNM,
            this.DIGIT,
            this.LENGTH,
            this.USE,
            this.KIND,
            this.HiddenCode});
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(916, 577);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // status
            // 
            this.status.HeaderText = "상태";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.status.Width = 50;
            // 
            // GRPCD
            // 
            this.GRPCD.HeaderText = "그룹코드";
            this.GRPCD.Name = "GRPCD";
            this.GRPCD.ReadOnly = true;
            this.GRPCD.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GRPCD.Width = 120;
            // 
            // GRPNM
            // 
            this.GRPNM.HeaderText = "그룹코드명";
            this.GRPNM.Name = "GRPNM";
            this.GRPNM.ReadOnly = true;
            this.GRPNM.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GRPNM.Width = 200;
            // 
            // DIGIT
            // 
            this.DIGIT.HeaderText = "단위 코드 자리수";
            this.DIGIT.Name = "DIGIT";
            this.DIGIT.Width = 120;
            // 
            // LENGTH
            // 
            this.LENGTH.HeaderText = "단위코드명(길이)";
            this.LENGTH.Name = "LENGTH";
            this.LENGTH.Width = 120;
            // 
            // USE
            // 
            this.USE.HeaderText = "사용여부";
            this.USE.Name = "USE";
            this.USE.ReadOnly = true;
            this.USE.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // KIND
            // 
            this.KIND.HeaderText = "분류";
            this.KIND.Name = "KIND";
            this.KIND.ReadOnly = true;
            this.KIND.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.KIND.Width = 150;
            // 
            // HiddenCode
            // 
            this.HiddenCode.HeaderText = "HiddenCode";
            this.HiddenCode.Name = "HiddenCode";
            this.HiddenCode.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "코드";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 51);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.RoyalBlue;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Noto Sans KR", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(1171, 10);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(68, 32);
            this.button7.TabIndex = 32;
            this.button7.Text = "취소";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.RoyalBlue;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Noto Sans KR", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(905, 10);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(68, 32);
            this.button6.TabIndex = 31;
            this.button6.Text = "저장";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Noto Sans KR", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(812, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 32);
            this.button4.TabIndex = 29;
            this.button4.Text = "조회";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Noto Sans KR", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(993, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 32);
            this.button3.TabIndex = 28;
            this.button3.Text = "입력";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Noto Sans KR", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1079, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 32);
            this.button2.TabIndex = 27;
            this.button2.Text = "삭제";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Noto Sans KR", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(271, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "검색하기";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(72, 21);
            this.textBox1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1248, 587);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.CDG_HiddenCode);
            this.panel3.Controls.Add(this.CDG_KIND);
            this.panel3.Controls.Add(this.CDG_USE);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.CDG_DIGIT);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.CDG_LENGTH);
            this.panel3.Controls.Add(this.CDG_GRPNM);
            this.panel3.Controls.Add(this.CDG_GRPCD);
            this.panel3.Location = new System.Drawing.Point(917, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(331, 578);
            this.panel3.TabIndex = 1;
            // 
            // CDG_HiddenCode
            // 
            this.CDG_HiddenCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CDG_HiddenCode.Location = new System.Drawing.Point(71, 426);
            this.CDG_HiddenCode.Name = "CDG_HiddenCode";
            this.CDG_HiddenCode.ReadOnly = true;
            this.CDG_HiddenCode.Size = new System.Drawing.Size(158, 14);
            this.CDG_HiddenCode.TabIndex = 31;
            this.CDG_HiddenCode.Visible = false;
            this.CDG_HiddenCode.TextChanged += new System.EventHandler(this.CDG_GRPCD_TextChanged);
            // 
            // CDG_KIND
            // 
            this.CDG_KIND.Location = new System.Drawing.Point(137, 361);
            this.CDG_KIND.Name = "CDG_KIND";
            this.CDG_KIND.Size = new System.Drawing.Size(158, 21);
            this.CDG_KIND.TabIndex = 30;
            this.CDG_KIND.TextChanged += new System.EventHandler(this.CDG_GRPCD_TextChanged);
            // 
            // CDG_USE
            // 
            this.CDG_USE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CDG_USE.FormattingEnabled = true;
            this.CDG_USE.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.CDG_USE.Location = new System.Drawing.Point(137, 304);
            this.CDG_USE.Name = "CDG_USE";
            this.CDG_USE.Size = new System.Drawing.Size(158, 20);
            this.CDG_USE.TabIndex = 29;
            this.CDG_USE.TextChanged += new System.EventHandler(this.CDG_GRPCD_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(32, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 28;
            this.label8.Text = "분류";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(32, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 27;
            this.label9.Text = "사용여부";
            // 
            // CDG_DIGIT
            // 
            this.CDG_DIGIT.Location = new System.Drawing.Point(137, 192);
            this.CDG_DIGIT.Name = "CDG_DIGIT";
            this.CDG_DIGIT.Size = new System.Drawing.Size(158, 21);
            this.CDG_DIGIT.TabIndex = 24;
            this.CDG_DIGIT.TextChanged += new System.EventHandler(this.CDG_GRPCD_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(32, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "단위코드명 길이";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(32, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "단위 코드 자릿수";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(32, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "그룹코드명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(32, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "그룹코드";
            // 
            // CDG_LENGTH
            // 
            this.CDG_LENGTH.Location = new System.Drawing.Point(137, 250);
            this.CDG_LENGTH.Name = "CDG_LENGTH";
            this.CDG_LENGTH.Size = new System.Drawing.Size(158, 21);
            this.CDG_LENGTH.TabIndex = 18;
            this.CDG_LENGTH.TextChanged += new System.EventHandler(this.CDG_GRPCD_TextChanged);
            // 
            // CDG_GRPNM
            // 
            this.CDG_GRPNM.Location = new System.Drawing.Point(137, 135);
            this.CDG_GRPNM.Name = "CDG_GRPNM";
            this.CDG_GRPNM.Size = new System.Drawing.Size(158, 21);
            this.CDG_GRPNM.TabIndex = 16;
            this.CDG_GRPNM.TextChanged += new System.EventHandler(this.CDG_GRPCD_TextChanged);
            // 
            // CDG_GRPCD
            // 
            this.CDG_GRPCD.Location = new System.Drawing.Point(137, 79);
            this.CDG_GRPCD.Name = "CDG_GRPCD";
            this.CDG_GRPCD.Size = new System.Drawing.Size(158, 21);
            this.CDG_GRPCD.TabIndex = 15;
            this.CDG_GRPCD.TextChanged += new System.EventHandler(this.CDG_GRPCD_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1248, 587);
            this.dataGridView1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.769231F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.23077F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1254, 650);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(75, 477);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 32;
            this.textBox3.Text = "안녕";
            this.textBox3.Visible = false;
            // 
            // GroupCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1254, 650);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GroupCode";
            this.Text = "GroupCode";
            this.Load += new System.EventHandler(this.GroupCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox CDG_KIND;
        private System.Windows.Forms.ComboBox CDG_USE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CDG_DIGIT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CDG_LENGTH;
        private System.Windows.Forms.TextBox CDG_GRPNM;
        private System.Windows.Forms.TextBox CDG_GRPCD;
        private System.Windows.Forms.TextBox CDG_HiddenCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRPCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRPNM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIGIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn LENGTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn USE;
        private System.Windows.Forms.DataGridViewTextBoxColumn KIND;
        private System.Windows.Forms.DataGridViewTextBoxColumn HiddenCode;
        private System.Windows.Forms.TextBox textBox3;
    }
}