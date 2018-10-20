using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using simulation.Properties;

namespace simulation
{
	public partial class SimulatingScreen : Form
	{
		enum Position
		{
			Left, Right, Up, Down
		}

		
		private Sim Sim;
		Hall hall1;
		public SimulatingScreen(Sim sim)
		{
			InitializeComponent();
			this.Sim = sim;
			
		}

		public SimulatingScreen()
		{
			InitializeComponent();
			


		}
		
		
		decimal[] Listppl;
		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{


		}


		private void SimulatingScreen_Load(object sender, EventArgs e)
		{
			Sim.StartSim(this);
			Listppl = Sim.AssignCustomers(Convert.ToDecimal(Sim.amount));	
		}

		public void simulatetimer_Tick_1(object sender, EventArgs e)
		{
			Sim.UserGoToSeat();
		}

		public void simulatetimer_Tick(object sender, EventArgs e)
		{
			Sim.UserGoToSeat();
		}

		private void SimulatingScreen_Paint(object sender, PaintEventArgs e)
		{
			//e.Graphics.DrawImage(new Bitmap(simulation.Properties.Resources.imageObj), (float)x, (float)y, 10, 10);

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			
		}

		public void timerobj_Tick(object sender, EventArgs e)
		{
			Sim.UserGoToSeat();
		}
	}
}
