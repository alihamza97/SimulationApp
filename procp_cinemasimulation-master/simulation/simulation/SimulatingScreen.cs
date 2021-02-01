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
		
		
		int[] Listppl;
		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{
			
			Sim.StartSim(this);
			//Listppl = Sim.GenratedCustomers(Convert.ToInt32(Sim.amount));

			//Label femalesAmount = ((Form1)this.Owner).lblnrfemale;
			//Label  malesAmount = ((Form1)this.Owner).lblnrmale;
			//femalesAmount.Text = Convert.ToString(Convert.ToString(Listppl[0]));
			//malesAmount.Text = Convert.ToString(Convert.ToString(Listppl[1]));

		}


		private void SimulatingScreen_Load(object sender, EventArgs e)
		{
			Sim.StartSim(this);
			
			// ((Form1)this.Owner).
			//Sim.GenratedCustomers((Form1)this.Owner)).
			//Listppl = Sim.AssignCustomers(Convert.ToDecimal(Sim.amount));	
		}

		public void simulatetimer_Tick_1(object sender, EventArgs e)
		{
			Sim.UserGoToSeat();
            Console.WriteLine("simulatetimer_Tick_1");
		}

		public void simulatetimer_Tick(object sender, EventArgs e)
		{
			Sim.UserGoToSeat();
            Console.WriteLine("simulatetimer_Tick");

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
