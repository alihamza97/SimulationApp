using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulation
{
    public partial class Form1 : Form
    {
		private SimulatingScreen SimulatedScreen;
		private Sim mainSim = new Sim();
		Point Initinameoint;
        public Form1()
        {
            InitializeComponent();
		
			this.ShowInTaskbar = false; ;
			//this.ControlBox = false;
			this.Text = null;
        }
		private void EnableRB(bool value)
		{
			rbA.Enabled = value;
			
		}
		public void ShowSimulatingScreen()
		{
			SimulatedScreen = new SimulatingScreen(mainSim);
			SimulatedScreen.StartPosition = FormStartPosition.Manual;
			SimulatedScreen.Size = pnlLayout1.Size;
			SimulatedScreen.Location = new Point(this.Location.X+100, this.Location.Y+130);
			SimulatedScreen.Show(this);
		}
		private void groupBox4_Enter(object sender, EventArgs e)
		{

		}

		private void btn_startSimulation_Click(object sender, EventArgs e)
		{
			if (rbA.Checked)
			{ ShowSimulatingScreen();
				mainSim.SetHall(rbA.Text);
				timer1.Start();
			} 
			else
			{
				MessageBox.Show("Please check the radio button first");
		      }

		}
		private void Form1_Load(object sender, EventArgs e)
		{
			this.CenterToScreen();
			Initinameoint = this.Location;
		}

		private void PersonAmount_Click(object sender, EventArgs e)
		{

		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			SimulatedScreen.timerobj_Tick(sender, e);
		}

		private void btn_startSimulation_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pnlLayout1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void timerStart_Tick(object sender, EventArgs e)
		{
			SimulatedScreen.simulatetimer_Tick(sender, e);
		}

		private void btn_stopSimulation_Click(object sender, EventArgs e)
		{

		}

		private void rbA_Click(object sender, EventArgs e)
		{
			mainSim.SetHall(rbA.Text);
			countCustomer();
			ShowSimulatingScreen();
			mainSim.CalcAmountofCustomers();
			EnableRB(true);
		}
		public void countCustomer() //move this to sim
		{

		}

		private void rbA_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			//if (cbTime.SelectedIndex > -1 && cbAge.SelectedIndex > -1 && cbGenre.SelectedIndex > -1)
			//{
				
				
					mainSim.CalcAmountofCustomers();
					EnableRB(true);
				
			//}
			//else
			//	MessageBox.Show("Please choose correctly");
		}
	}
}
