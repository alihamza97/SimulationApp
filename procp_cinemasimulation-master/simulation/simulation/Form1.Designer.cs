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
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lbl_maleCount = new System.Windows.Forms.Label();
			this.lbl_femaleCount = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.lblnrfemale = new System.Windows.Forms.Label();
			this.checkBox_ShopClosed = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.lbl_ShopVisitor = new System.Windows.Forms.Label();
			this.NrShopVistor = new System.Windows.Forms.Label();
			this.seatsFilled = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.btnDecreaseSim = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.btnIncreaseSim = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton_shuffleCust = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tb_femalePercentage = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbCustAmount = new System.Windows.Forms.TextBox();
			this.PersonAmount = new System.Windows.Forms.Label();
			this.btn_stopSimulation = new System.Windows.Forms.Button();
			this.btn_startSimulation = new System.Windows.Forms.Button();
			this.panel_cinemaCampus = new System.Windows.Forms.Panel();
			this.pnlLayout1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.rbA = new System.Windows.Forms.RadioButton();
			this.timerStart = new System.Windows.Forms.Timer(this.components);
			this.panel3 = new System.Windows.Forms.Panel();
			this.A2 = new System.Windows.Forms.RadioButton();
			this.label5 = new System.Windows.Forms.Label();
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.timer3 = new System.Windows.Forms.Timer(this.components);
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.btn_stopTimer = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.panel_cinemaCampus.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox3);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Location = new System.Drawing.Point(699, 10);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(305, 383);
			this.panel1.TabIndex = 0;
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Khaki;
			this.groupBox3.Controls.Add(this.groupBox7);
			this.groupBox3.Controls.Add(this.groupBox5);
			this.groupBox3.Controls.Add(this.checkBox_ShopClosed);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.groupBox6);
			this.groupBox3.Controls.Add(this.btnDecreaseSim);
			this.groupBox3.Controls.Add(this.groupBox4);
			this.groupBox3.Controls.Add(this.btnIncreaseSim);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Location = new System.Drawing.Point(-1, 126);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox3.Size = new System.Drawing.Size(293, 257);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Screening";
			// 
			// groupBox7
			// 
			this.groupBox7.BackColor = System.Drawing.Color.Wheat;
			this.groupBox7.Controls.Add(this.label7);
			this.groupBox7.Controls.Add(this.label6);
			this.groupBox7.Controls.Add(this.lbl_maleCount);
			this.groupBox7.Controls.Add(this.lbl_femaleCount);
			this.groupBox7.Location = new System.Drawing.Point(124, 190);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(164, 66);
			this.groupBox7.TabIndex = 6;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Amount by Gender";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 42);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(44, 13);
			this.label7.TabIndex = 3;
			this.label7.Text = "Female:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 21);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(33, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "Male:";
			// 
			// lbl_maleCount
			// 
			this.lbl_maleCount.AutoSize = true;
			this.lbl_maleCount.Location = new System.Drawing.Point(60, 21);
			this.lbl_maleCount.Name = "lbl_maleCount";
			this.lbl_maleCount.Size = new System.Drawing.Size(13, 13);
			this.lbl_maleCount.TabIndex = 1;
			this.lbl_maleCount.Text = "0";
			// 
			// lbl_femaleCount
			// 
			this.lbl_femaleCount.AutoSize = true;
			this.lbl_femaleCount.Location = new System.Drawing.Point(60, 42);
			this.lbl_femaleCount.Name = "lbl_femaleCount";
			this.lbl_femaleCount.Size = new System.Drawing.Size(13, 13);
			this.lbl_femaleCount.TabIndex = 0;
			this.lbl_femaleCount.Text = "0";
			// 
			// groupBox5
			// 
			this.groupBox5.BackColor = System.Drawing.Color.Wheat;
			this.groupBox5.Controls.Add(this.lblnrfemale);
			this.groupBox5.Location = new System.Drawing.Point(2, 194);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(114, 58);
			this.groupBox5.TabIndex = 12;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Amount of People";
			// 
			// lblnrfemale
			// 
			this.lblnrfemale.AccessibleDescription = "lblFemales";
			this.lblnrfemale.AccessibleName = "lblFemales";
			this.lblnrfemale.AutoSize = true;
			this.lblnrfemale.Location = new System.Drawing.Point(6, 16);
			this.lblnrfemale.Name = "lblnrfemale";
			this.lblnrfemale.Size = new System.Drawing.Size(73, 13);
			this.lblnrfemale.TabIndex = 9;
			this.lblnrfemale.Text = "Total Amount:";
			this.lblnrfemale.Click += new System.EventHandler(this.lblnrfemale_Click);
			// 
			// checkBox_ShopClosed
			// 
			this.checkBox_ShopClosed.AutoSize = true;
			this.checkBox_ShopClosed.Location = new System.Drawing.Point(16, 30);
			this.checkBox_ShopClosed.Margin = new System.Windows.Forms.Padding(2);
			this.checkBox_ShopClosed.Name = "checkBox_ShopClosed";
			this.checkBox_ShopClosed.Size = new System.Drawing.Size(86, 17);
			this.checkBox_ShopClosed.TabIndex = 11;
			this.checkBox_ShopClosed.Text = "Shop Closed";
			this.checkBox_ShopClosed.UseVisualStyleBackColor = true;
			this.checkBox_ShopClosed.CheckedChanged += new System.EventHandler(this.checkBox_ShopClosed_CheckedChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(80, 49);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Simulation Speed";
			// 
			// groupBox6
			// 
			this.groupBox6.BackColor = System.Drawing.Color.Wheat;
			this.groupBox6.Controls.Add(this.lbl_ShopVisitor);
			this.groupBox6.Controls.Add(this.NrShopVistor);
			this.groupBox6.Controls.Add(this.seatsFilled);
			this.groupBox6.Controls.Add(this.label13);
			this.groupBox6.Location = new System.Drawing.Point(124, 122);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(166, 66);
			this.groupBox6.TabIndex = 4;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Seat/Shop Status";
			// 
			// lbl_ShopVisitor
			// 
			this.lbl_ShopVisitor.AutoSize = true;
			this.lbl_ShopVisitor.Location = new System.Drawing.Point(6, 41);
			this.lbl_ShopVisitor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_ShopVisitor.Name = "lbl_ShopVisitor";
			this.lbl_ShopVisitor.Size = new System.Drawing.Size(63, 13);
			this.lbl_ShopVisitor.TabIndex = 10;
			this.lbl_ShopVisitor.Text = "Shop Visitor";
			// 
			// NrShopVistor
			// 
			this.NrShopVistor.AccessibleDescription = "lblFemales";
			this.NrShopVistor.AccessibleName = "lblFemales";
			this.NrShopVistor.AutoSize = true;
			this.NrShopVistor.Location = new System.Drawing.Point(81, 41);
			this.NrShopVistor.Name = "NrShopVistor";
			this.NrShopVistor.Size = new System.Drawing.Size(13, 13);
			this.NrShopVistor.TabIndex = 9;
			this.NrShopVistor.Text = "0";
			// 
			// seatsFilled
			// 
			this.seatsFilled.AutoSize = true;
			this.seatsFilled.Location = new System.Drawing.Point(99, 16);
			this.seatsFilled.Name = "seatsFilled";
			this.seatsFilled.Size = new System.Drawing.Size(13, 13);
			this.seatsFilled.TabIndex = 1;
			this.seatsFilled.Text = "0";
			this.seatsFilled.Click += new System.EventHandler(this.seatsFilled_Click);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(5, 16);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(91, 13);
			this.label13.TabIndex = 0;
			this.label13.Text = "SeatsToBeTaken";
			// 
			// btnDecreaseSim
			// 
			this.btnDecreaseSim.Location = new System.Drawing.Point(146, 74);
			this.btnDecreaseSim.Margin = new System.Windows.Forms.Padding(2);
			this.btnDecreaseSim.Name = "btnDecreaseSim";
			this.btnDecreaseSim.Size = new System.Drawing.Size(64, 23);
			this.btnDecreaseSim.TabIndex = 8;
			this.btnDecreaseSim.Text = "Decrease";
			this.btnDecreaseSim.UseVisualStyleBackColor = true;
			this.btnDecreaseSim.Click += new System.EventHandler(this.btnDecreaseSim_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.Wheat;
			this.groupBox4.Controls.Add(this.label8);
			this.groupBox4.Controls.Add(this.label9);
			this.groupBox4.Location = new System.Drawing.Point(5, 122);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(111, 66);
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
			this.label8.Click += new System.EventHandler(this.label8_Click);
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
			// btnIncreaseSim
			// 
			this.btnIncreaseSim.Location = new System.Drawing.Point(42, 74);
			this.btnIncreaseSim.Margin = new System.Windows.Forms.Padding(2);
			this.btnIncreaseSim.Name = "btnIncreaseSim";
			this.btnIncreaseSim.Size = new System.Drawing.Size(64, 23);
			this.btnIncreaseSim.TabIndex = 7;
			this.btnIncreaseSim.Text = "Increase";
			this.btnIncreaseSim.UseVisualStyleBackColor = true;
			this.btnIncreaseSim.Click += new System.EventHandler(this.btnIncreaseSim_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(50, 98);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(148, 20);
			this.label4.TabIndex = 1;
			this.label4.Text = "Screening Status";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Khaki;
			this.groupBox1.Controls.Add(this.radioButton_shuffleCust);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.tbCustAmount);
			this.groupBox1.Location = new System.Drawing.Point(2, 2);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(289, 122);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Customer Type";
			// 
			// radioButton_shuffleCust
			// 
			this.radioButton_shuffleCust.AutoSize = true;
			this.radioButton_shuffleCust.Location = new System.Drawing.Point(14, 94);
			this.radioButton_shuffleCust.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.radioButton_shuffleCust.Name = "radioButton_shuffleCust";
			this.radioButton_shuffleCust.Size = new System.Drawing.Size(134, 17);
			this.radioButton_shuffleCust.TabIndex = 13;
			this.radioButton_shuffleCust.TabStop = true;
			this.radioButton_shuffleCust.Text = "Suffle Customer Queue";
			this.radioButton_shuffleCust.UseVisualStyleBackColor = true;
			this.radioButton_shuffleCust.CheckedChanged += new System.EventHandler(this.radioButton_shuffleCust_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 22);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 13);
			this.label2.TabIndex = 14;
			this.label2.Text = "Total Customers:";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.groupBox2.Controls.Add(this.tb_femalePercentage);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(14, 38);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox2.Size = new System.Drawing.Size(266, 51);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Gender Percentage";
			// 
			// tb_femalePercentage
			// 
			this.tb_femalePercentage.Location = new System.Drawing.Point(104, 21);
			this.tb_femalePercentage.Margin = new System.Windows.Forms.Padding(2);
			this.tb_femalePercentage.Name = "tb_femalePercentage";
			this.tb_femalePercentage.Size = new System.Drawing.Size(127, 20);
			this.tb_femalePercentage.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 25);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Female:";
			// 
			// tbCustAmount
			// 
			this.tbCustAmount.Location = new System.Drawing.Point(107, 18);
			this.tbCustAmount.Margin = new System.Windows.Forms.Padding(2);
			this.tbCustAmount.Name = "tbCustAmount";
			this.tbCustAmount.Size = new System.Drawing.Size(126, 20);
			this.tbCustAmount.TabIndex = 13;
			// 
			// PersonAmount
			// 
			this.PersonAmount.AutoSize = true;
			this.PersonAmount.Location = new System.Drawing.Point(943, 517);
			this.PersonAmount.Name = "PersonAmount";
			this.PersonAmount.Size = new System.Drawing.Size(7, 13);
			this.PersonAmount.TabIndex = 6;
			this.PersonAmount.Text = "\r\n";
			this.PersonAmount.Click += new System.EventHandler(this.timer1_Tick);
			// 
			// btn_stopSimulation
			// 
			this.btn_stopSimulation.BackColor = System.Drawing.Color.Red;
			this.btn_stopSimulation.Location = new System.Drawing.Point(445, 501);
			this.btn_stopSimulation.Margin = new System.Windows.Forms.Padding(2);
			this.btn_stopSimulation.Name = "btn_stopSimulation";
			this.btn_stopSimulation.Size = new System.Drawing.Size(101, 34);
			this.btn_stopSimulation.TabIndex = 1;
			this.btn_stopSimulation.Text = "Exit";
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
			this.panel_cinemaCampus.Controls.Add(this.pnlLayout1);
			this.panel_cinemaCampus.Location = new System.Drawing.Point(11, 7);
			this.panel_cinemaCampus.Margin = new System.Windows.Forms.Padding(2);
			this.panel_cinemaCampus.Name = "panel_cinemaCampus";
			this.panel_cinemaCampus.Size = new System.Drawing.Size(685, 483);
			this.panel_cinemaCampus.TabIndex = 1;
			this.panel_cinemaCampus.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_cinemaCampus_Paint);
			// 
			// pnlLayout1
			// 
			this.pnlLayout1.BackColor = System.Drawing.Color.Black;
			this.pnlLayout1.Location = new System.Drawing.Point(75, 33);
			this.pnlLayout1.Margin = new System.Windows.Forms.Padding(1);
			this.pnlLayout1.Name = "pnlLayout1";
			this.pnlLayout1.Size = new System.Drawing.Size(536, 385);
			this.pnlLayout1.TabIndex = 0;
			this.pnlLayout1.LocationChanged += new System.EventHandler(this.pnlLayout1_LocationChanged);
			this.pnlLayout1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLayout1_Paint);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.button1.Location = new System.Drawing.Point(332, 501);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(86, 34);
			this.button1.TabIndex = 3;
			this.button1.Text = "Save";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
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
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.panel3.Controls.Add(this.A2);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.rbA);
			this.panel3.Location = new System.Drawing.Point(701, 398);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(302, 92);
			this.panel3.TabIndex = 5;
			// 
			// A2
			// 
			this.A2.AutoSize = true;
			this.A2.Location = new System.Drawing.Point(93, 40);
			this.A2.Name = "A2";
			this.A2.Size = new System.Drawing.Size(38, 17);
			this.A2.TabIndex = 6;
			this.A2.TabStop = true;
			this.A2.Text = "A2";
			this.A2.UseVisualStyleBackColor = true;
			this.A2.CheckedChanged += new System.EventHandler(this.A2_CheckedChanged);
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
			// timer2
			// 
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
			// 
			// btn_stopTimer
			// 
			this.btn_stopTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btn_stopTimer.Location = new System.Drawing.Point(129, 501);
			this.btn_stopTimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_stopTimer.Name = "btn_stopTimer";
			this.btn_stopTimer.Size = new System.Drawing.Size(68, 34);
			this.btn_stopTimer.TabIndex = 15;
			this.btn_stopTimer.Text = "Stop Timer";
			this.btn_stopTimer.UseVisualStyleBackColor = false;
			this.btn_stopTimer.Visible = false;
			this.btn_stopTimer.Click += new System.EventHandler(this.btn_stopTimer_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.LightGreen;
			this.ClientSize = new System.Drawing.Size(1052, 538);
			this.Controls.Add(this.btn_stopTimer);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.PersonAmount);
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
			this.groupBox7.ResumeLayout(false);
			this.groupBox7.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.panel_cinemaCampus.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_stopSimulation;
        private System.Windows.Forms.Button btn_startSimulation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_femalePercentage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_cinemaCampus;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button button1;
		public System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label PersonAmount;
		private System.Windows.Forms.RadioButton rbA;
		private System.Windows.Forms.Timer timerStart;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RadioButton A2;
        private System.Windows.Forms.Panel pnlLayout1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDecreaseSim;
        private System.Windows.Forms.Button btnIncreaseSim;
        private System.Windows.Forms.CheckBox checkBox_ShopClosed;
		public System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Timer timer3;
		private System.Windows.Forms.GroupBox groupBox5;
		public System.Windows.Forms.Label lblnrfemale;
        private System.Windows.Forms.TextBox tbCustAmount;
		public System.Windows.Forms.Label NrShopVistor;
		public System.Windows.Forms.Label seatsFilled;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_stopTimer;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_maleCount;
        private System.Windows.Forms.Label lbl_femaleCount;
        private System.Windows.Forms.Label lbl_ShopVisitor;
        private System.Windows.Forms.RadioButton radioButton_shuffleCust;
    }
}

