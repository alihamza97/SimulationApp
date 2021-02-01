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
			btn_startSimulation.Enabled = false;
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
			SimulatedScreen.Location = new Point(this.Location.X+92, this.Location.Y+100);
			//SimulatedScreen=SimulatingScreen.instance
			//SimulatedScreen.TopLevel = false;
			//pnlLayout1.Controls.Add(SimulatedScreen);
			//SimulatedScreen.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			//SimulatedScreen.Dock = DockStyle.Fill;
			
			SimulatedScreen.Show(this);

		}
		private void groupBox4_Enter(object sender, EventArgs e)
		{

		}



		private void btn_startSimulation_Click(object sender, EventArgs e)
		{
			try {
				int amount = Convert.ToInt32(tbCustAmount.Text);
				if (amount <= 100)
				{
					int[] Listppl;
					int[] amountofPeople;
					int newAmount = Convert.ToInt32(tbCustAmount.Text);
					Sim.amount = newAmount;

					Listppl = mainSim.GenratedCustomers(Convert.ToInt32(Sim.amount));
					Customer.SeatCounter = newAmount;
					lblnrfemale.Text = "Amount: " + Convert.ToString(Convert.ToString(Listppl[0] + Listppl[1]));



					int x = Convert.ToInt32(tb_femalePercentage.Text);
					Sim.GenderPercentage = x;
					if (rbA.Checked)
					{
						countCustomer();
						ShowSimulatingScreen();
						EnableRB(true);
						timer1.Start();
						timer2.Start();
						if (Customer.StopTimer == 1)
						{
							timer2.Stop();
						}

					}
					else if (A2.Checked)
					{

						countCustomer();
						ShowSimulatingScreen();
						EnableRB(true);
						timer1.Start();
						timer2.Start();


					}
					else
					{
						MessageBox.Show("Please check the radio button first");
					}



					if (timer1.Enabled == false)
					{
						timer2.Stop();
					}

					lbl_maleCount.Text = Convert.ToInt32(mainSim.f).ToString();
					lbl_femaleCount.Text = Convert.ToInt32(mainSim.m).ToString();
					btn_stopTimer.Visible = true;
				}



			
			else
			{
				MessageBox.Show("Amount of people should not exceed 100" +
					"\nPlease re-enter the amount");
			}
			}
			catch (FormatException)
			{
				MessageBox.Show("Please re-configure the amount/percentage");
			}


		}
		private void Form1_Load(object sender, EventArgs e)
		{
            radioButton_shuffleCust.Checked = false;
			this.CenterToScreen();
			Initinameoint = this.Location;
            btn_startSimulation.Enabled = false;
           
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
		//	SimulatedScreen.simulatetimer_Tick(sender, e);
			
		}

		private void btn_stopSimulation_Click(object sender, EventArgs e)
		{
            this.Close();
		}

		private void rbA_Click(object sender, EventArgs e)
		{


           
			
		}
		public void countCustomer() //move this to sim
		{

		}

		private void rbA_CheckedChanged(object sender, EventArgs e)
		{
			if (tbCustAmount.Text != "" && tb_femalePercentage.Text != "")
			{
				mainSim.SetHall(rbA.Text);
				btn_startSimulation.Enabled = true;
			}
			else
			{
				MessageBox.Show("Please fill in customer amount and female percentage");
			}
           
        }

		

		private void A2_CheckedChanged(object sender, EventArgs e)
		{
			if (tbCustAmount.Text != "" && tb_femalePercentage.Text != "")
			{
				mainSim.SetHall(A2.Text);
				btn_startSimulation.Enabled = true;
			}
			else
			{
				MessageBox.Show("Please fill in customer amount and female percentage");
			}

			

        }

        private void btnIncreaseSim_Click(object sender, EventArgs e)
        {
           
            Customer.spd++;

        }

        private void btnDecreaseSim_Click(object sender, EventArgs e)
        {
            Customer.spd--;
        }

        private void checkBox_ShopClosed_CheckedChanged(object sender, EventArgs e)
        {
            Customer.StopShop();
        }

		int minute = 0;
		int seconds = 0;
		int miliseconds = 0;
		private void timer2_Tick(object sender, EventArgs e)
		{
		   label8.Text = Convert.ToString(minute) + ":" + Convert.ToString(seconds)+":"
				+Convert.ToString(miliseconds);
			if (miliseconds > 59)
			{
				miliseconds = 0;
				seconds++;
			}
			if (seconds > 59)
			{
				seconds = 0;
				minute++;
			}
			miliseconds++;

		
		
		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void pnlLayout1_LocationChanged(object sender, EventArgs e)
		{
			this.CenterToScreen();
		}

		public void lblnrfemale_Click(object sender, EventArgs e)
		{

		}

		private void panel_cinemaCampus_Paint(object sender, PaintEventArgs e)
		{

		}

        private void seatsFilled_Click(object sender, EventArgs e)
        {

        }

		private void button1_Click(object sender, EventArgs e)
		{
			//if (openFileDialog1.ShowDialog() == DialogResult.OK)
			//{

				FileStream fs = null;
				StreamWriter sw = null;
			   
				try
				{
					fs = new FileStream("../../Results.txt", FileMode.Create, FileAccess.Write);
					sw = new StreamWriter(fs);
				    sw.WriteLine("***********SIMULATION RESULTS************\n");
					sw.WriteLine("\nTotal Visitor:\t"+lblnrfemale.Text);
                    sw.WriteLine("\nMale Visitor:\t" + lbl_maleCount.Text);
                    sw.WriteLine("\nFemale Visitor:\t" + lbl_femaleCount.Text);
                    sw.WriteLine("\nShop Visitor:\t" + NrShopVistor.Text);
                    sw.WriteLine("\nSimulation TIME="+label8.Text);


				}
				catch (IOException)
				{
					MessageBox.Show("something went wrong, IOException was thrown");
				}
				finally
				{
					if (sw != null) sw.Close();
					if (fs != null) fs.Close();
				}
			MessageBox.Show("***********SIMULATION RESULTS************\nTotal Visitor:\t"+lblnrfemale.Text+ 
                "\nMale Visitor:\t" + lbl_maleCount.Text+ "\nFemale Visitor:\t" + lbl_femaleCount.Text+ "\nShop Visitor:\t" + NrShopVistor.Text+
                "\nSimulation TIME=" + label8.Text+"\n\nSaved!!!");
			}


		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{

		}

        private void btn_stopTimer_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void radioButton_shuffleCust_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_shuffleCust.Checked == true)
            {
                mainSim.ShuffleCustomers();

            }
        }

        private void btn_resetSimulation_Click(object sender, EventArgs e)
        {
            tbCustAmount.Clear();
            tb_femalePercentage.Clear();
            checkBox_ShopClosed.Checked = false;
            label8.Text = "0";
            seatsFilled.Text = "0";
            lbl_maleCount.Text = "0";
            lbl_femaleCount.Text = "0";
            NrShopVistor.Text = "0";
            radioButton_shuffleCust.Checked = false;

        }
    }
}
