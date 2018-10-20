namespace simulation
{
    partial class Form1
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.PersonAmount = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.SeatsfilledLbl = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tb_disablePercentage = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lbl_malePercentage = new System.Windows.Forms.Label();
			this.tb_femalePercentage = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_resetSimulation = new System.Windows.Forms.Button();
			this.btn_stopSimulation = new System.Windows.Forms.Button();
			this.btn_startSimulation = new System.Windows.Forms.Button();
			this.panel_cinemaCampus = new System.Windows.Forms.Panel();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.pnlLayout1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.rbA = new System.Windows.Forms.RadioButton();
			this.timerStart = new System.Windows.Forms.Timer(this.components);
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.panel_cinemaCampus.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox3);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Location = new System.Drawing.Point(731, 10);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(259, 383);
			this.panel1.TabIndex = 0;
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Khaki;
			this.groupBox3.Controls.Add(this.PersonAmount);
			this.groupBox3.Controls.Add(this.groupBox4);
			this.groupBox3.Controls.Add(this.groupBox6);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Location = new System.Drawing.Point(-1, 227);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox3.Size = new System.Drawing.Size(282, 156);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Screening";
			// 
			// PersonAmount
			// 
			this.PersonAmount.AutoSize = true;
			this.PersonAmount.Location = new System.Drawing.Point(156, 141);
			this.PersonAmount.Name = "PersonAmount";
			this.PersonAmount.Size = new System.Drawing.Size(92, 13);
			this.PersonAmount.TabIndex = 6;
			this.PersonAmount.Text = "AmountOfPersons";
			this.PersonAmount.Click += new System.EventHandler(this.PersonAmount_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.Wheat;
			this.groupBox4.Controls.Add(this.label8);
			this.groupBox4.Controls.Add(this.label9);
			this.groupBox4.Location = new System.Drawing.Point(16, 88);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(107, 46);
			this.groupBox4.TabIndex = 5;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Timer";
			this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(32, 16);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(28, 13);
			this.label8.TabIndex = 1;
			this.label8.Text = "0:00";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(-3, 30);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(109, 13);
			this.label9.TabIndex = 0;
			this.label9.Text = "Seconds:MiliSeconds";
			// 
			// groupBox6
			// 
			this.groupBox6.BackColor = System.Drawing.Color.Wheat;
			this.groupBox6.Controls.Add(this.SeatsfilledLbl);
			this.groupBox6.Controls.Add(this.label13);
			this.groupBox6.Location = new System.Drawing.Point(129, 88);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(119, 46);
			this.groupBox6.TabIndex = 4;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Seat Status";
			// 
			// SeatsfilledLbl
			// 
			this.SeatsfilledLbl.AutoSize = true;
			this.SeatsfilledLbl.Location = new System.Drawing.Point(66, 16);
			this.SeatsfilledLbl.Name = "SeatsfilledLbl";
			this.SeatsfilledLbl.Size = new System.Drawing.Size(13, 13);
			this.SeatsfilledLbl.TabIndex = 1;
			this.SeatsfilledLbl.Text = "0";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(0, 16);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(64, 13);
			this.label13.TabIndex = 0;
			this.label13.Text = "Seats Filled:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(47, 42);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(148, 20);
			this.label4.TabIndex = 1;
			this.label4.Text = "Screening Status";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Khaki;
			this.groupBox1.Controls.Add(this.tb_disablePercentage);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Location = new System.Drawing.Point(2, 2);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(254, 221);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Customer Type";
			// 
			// tb_disablePercentage
			// 
			this.tb_disablePercentage.Location = new System.Drawing.Point(151, 134);
			this.tb_disablePercentage.Margin = new System.Windows.Forms.Padding(2);
			this.tb_disablePercentage.Name = "tb_disablePercentage";
			this.tb_disablePercentage.Size = new System.Drawing.Size(56, 20);
			this.tb_disablePercentage.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(32, 137);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Disable Percentage:";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.groupBox2.Controls.Add(this.lbl_malePercentage);
			this.groupBox2.Controls.Add(this.tb_femalePercentage);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(16, 24);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox2.Size = new System.Drawing.Size(232, 87);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Gender Percentage";
			// 
			// lbl_malePercentage
			// 
			this.lbl_malePercentage.AutoSize = true;
			this.lbl_malePercentage.Location = new System.Drawing.Point(137, 32);
			this.lbl_malePercentage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_malePercentage.Name = "lbl_malePercentage";
			this.lbl_malePercentage.Size = new System.Drawing.Size(36, 13);
			this.lbl_malePercentage.TabIndex = 2;
			this.lbl_malePercentage.Text = "Male: ";
			// 
			// tb_femalePercentage
			// 
			this.tb_femalePercentage.Location = new System.Drawing.Point(64, 29);
			this.tb_femalePercentage.Margin = new System.Windows.Forms.Padding(2);
			this.tb_femalePercentage.Name = "tb_femalePercentage";
			this.tb_femalePercentage.Size = new System.Drawing.Size(56, 20);
			this.tb_femalePercentage.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 32);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Female:";
			// 
			// btn_resetSimulation
			// 
			this.btn_resetSimulation.BackColor = System.Drawing.Color.Cyan;
			this.btn_resetSimulation.Location = new System.Drawing.Point(486, 501);
			this.btn_resetSimulation.Margin = new System.Windows.Forms.Padding(2);
			this.btn_resetSimulation.Name = "btn_resetSimulation";
			this.btn_resetSimulation.Size = new System.Drawing.Size(101, 34);
			this.btn_resetSimulation.TabIndex = 2;
			this.btn_resetSimulation.Text = "Reset";
			this.btn_resetSimulation.UseVisualStyleBackColor = false;
			// 
			// btn_stopSimulation
			// 
			this.btn_stopSimulation.BackColor = System.Drawing.Color.Red;
			this.btn_stopSimulation.Location = new System.Drawing.Point(351, 501);
			this.btn_stopSimulation.Margin = new System.Windows.Forms.Padding(2);
			this.btn_stopSimulation.Name = "btn_stopSimulation";
			this.btn_stopSimulation.Size = new System.Drawing.Size(101, 34);
			this.btn_stopSimulation.TabIndex = 1;
			this.btn_stopSimulation.Text = "Stop";
			this.btn_stopSimulation.UseVisualStyleBackColor = false;
			this.btn_stopSimulation.Click += new System.EventHandler(this.btn_stopSimulation_Click);
			// 
			// btn_startSimulation
			// 
			this.btn_startSimulation.BackColor = System.Drawing.Color.Turquoise;
			this.btn_startSimulation.Location = new System.Drawing.Point(214, 501);
			this.btn_startSimulation.Margin = new System.Windows.Forms.Padding(2);
			this.btn_startSimulation.Name = "btn_startSimulation";
			this.btn_startSimulation.Size = new System.Drawing.Size(101, 34);
			this.btn_startSimulation.TabIndex = 0;
			this.btn_startSimulation.Text = "Start";
			this.btn_startSimulation.UseVisualStyleBackColor = false;
			this.btn_startSimulation.Click += new System.EventHandler(this.btn_startSimulation_Click);
			this.btn_startSimulation.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_startSimulation_Paint);
			// 
			// panel_cinemaCampus
			// 
			this.panel_cinemaCampus.Controls.Add(this.flowLayoutPanel2);
			this.panel_cinemaCampus.Controls.Add(this.flowLayoutPanel1);
			this.panel_cinemaCampus.Controls.Add(this.panel4);
			this.panel_cinemaCampus.Controls.Add(this.label3);
			this.panel_cinemaCampus.Location = new System.Drawing.Point(5, 7);
			this.panel_cinemaCampus.Margin = new System.Windows.Forms.Padding(2);
			this.panel_cinemaCampus.Name = "panel_cinemaCampus";
			this.panel_cinemaCampus.Size = new System.Drawing.Size(722, 483);
			this.panel_cinemaCampus.TabIndex = 1;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.BackColor = System.Drawing.Color.Black;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 13);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(161, 467);
			this.flowLayoutPanel2.TabIndex = 5;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.Black;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(169, 403);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(467, 77);
			this.flowLayoutPanel1.TabIndex = 4;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.pnlLayout1);
			this.panel4.Location = new System.Drawing.Point(169, 13);
			this.panel4.Margin = new System.Windows.Forms.Padding(2);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(538, 390);
			this.panel4.TabIndex = 3;
			// 
			// pnlLayout1
			// 
			this.pnlLayout1.BackColor = System.Drawing.Color.Black;
			this.pnlLayout1.Location = new System.Drawing.Point(0, 0);
			this.pnlLayout1.Margin = new System.Windows.Forms.Padding(1);
			this.pnlLayout1.Name = "pnlLayout1";
			this.pnlLayout1.Size = new System.Drawing.Size(536, 385);
			this.pnlLayout1.TabIndex = 0;
			this.pnlLayout1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLayout1_Paint);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(641, 429);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Main Entrance";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.button1.Location = new System.Drawing.Point(610, 501);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(86, 34);
			this.button1.TabIndex = 3;
			this.button1.Text = "Save";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// rbA
			// 
			this.rbA.AutoSize = true;
			this.rbA.Location = new System.Drawing.Point(42, 40);
			this.rbA.Name = "rbA";
			this.rbA.Size = new System.Drawing.Size(32, 17);
			this.rbA.TabIndex = 4;
			this.rbA.TabStop = true;
			this.rbA.Text = "A";
			this.rbA.UseVisualStyleBackColor = true;
			this.rbA.CheckedChanged += new System.EventHandler(this.rbA_CheckedChanged);
			this.rbA.Click += new System.EventHandler(this.rbA_Click);
			// 
			// timerStart
			// 
			this.timerStart.Tick += new System.EventHandler(this.timerStart_Tick);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.BurlyWood;
			this.panel2.Location = new System.Drawing.Point(5, 182);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(42, 100);
			this.panel2.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.rbA);
			this.panel3.Location = new System.Drawing.Point(733, 398);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(257, 92);
			this.panel3.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(25, 17);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(153, 20);
			this.label5.TabIndex = 5;
			this.label5.Text = "Hall Configuration";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.LightGreen;
			this.ClientSize = new System.Drawing.Size(1052, 538);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.btn_resetSimulation);
			this.Controls.Add(this.panel_cinemaCampus);
			this.Controls.Add(this.btn_stopSimulation);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btn_startSimulation);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cinema Hall Simulation";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.panel_cinemaCampus.ResumeLayout(false);
			this.panel_cinemaCampus.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_resetSimulation;
        private System.Windows.Forms.Button btn_stopSimulation;
        private System.Windows.Forms.Button btn_startSimulation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_disablePercentage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_malePercentage;
        private System.Windows.Forms.TextBox tb_femalePercentage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_cinemaCampus;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox groupBox6;
		public System.Windows.Forms.Label SeatsfilledLbl;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label PersonAmount;
		private System.Windows.Forms.RadioButton rbA;
		private System.Windows.Forms.Timer timerStart;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Panel pnlLayout1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
	}
}

