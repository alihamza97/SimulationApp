using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace simulation
{
	public class Sim
	{
		private int simID, ageRating;
		string options;

		private Seat[,] listSeats;
		private Door[] doors;
		private Hall hall1;
		System.Windows.Forms.Panel p;

		public List<System.Windows.Forms.Panel> users = new List<System.Windows.Forms.Panel>();
		List<Customer> customers = new List<Customer>();

		private int x, y, height, width, row, col;
		private string name;
		Random rand = new Random();

		int seatCounter = 0;

		public int randRow, randCol, randSpace;
		public static int amount;
		private int z;

	
		private Door doorA;
		private Door doorB;
		Customer customer;
		private decimal[] CustomersList;

		decimal[] agecategory;
		SimulatingScreen FormScreen;

		public static double customerCount;

		public Sim()
		{

		}
		public double GetRandomNumber(double minimum, double maximum)
		{
			Random random = new Random();
			return random.NextDouble() * (maximum - minimum) + minimum;
		}

		public void CalcAmountofCustomers() 
		{
					customerCount = GetRandomNumber(0.7, 0.75); 
					customerCount = GetRandomNumber(0.6, 0.8);
					customerCount = GetRandomNumber(0.5, 0.7);
					customerCount = GetRandomNumber(0, 0.1);			
					customerCount = GetRandomNumber(0.4, 0.6);		
					customerCount = GetRandomNumber(0.1, 0.3);
					
		}

		public void SetHall(string hallString)
		{
			if (hallString == "A") hall1 = new HallA();
			
		}

		public decimal[] AssignCustomers(decimal AmountOfPeople) 
		{
			CustomersList = new decimal[2];
			
				CustomersList[0] = Math.Round((30 * AmountOfPeople) / 100);
				CustomersList[1] = Math.Round((60 * AmountOfPeople) / 100);
			
			return CustomersList;
		}

		public void AssignCustomerSeats() 
		{
			amount = Convert.ToInt32(CustomersList[0] + CustomersList[1]);
			for (int i = 0; i < amount; i++)
			{
				bool valid = true;

				while (valid)
				{
					int a = rand.Next(0, 4);

					if (a == 0 && CustomersList[0] > 0)
					{
						customer = new Female(i, amount, hall1);
						CustomersList[0]--;
						valid = false;
					}
					else if (a == 1 && CustomersList[1] > 0)
					{
						customer = new Male(i, amount, hall1);
						CustomersList[1]--;
						valid = false;
					}

				}

				customers.Add(customer);
				customers[i].FindSeat();
				for (int j = 0; j < customers.Count(); j++)
				{
					if (customers[i].SeatRow == customers[j].SeatRow && customers[i].seatColumn == customers[j].seatColumn && i != j)
					{
						customers[i].FindSeat();
						j = -1;
					}
				}

			}
		}

		public void StartSim(SimulatingScreen FormScreen)
		{
			this.FormScreen = FormScreen;
			hall1.HallConfiguration();
			listSeats = hall1.Seats();
			doors = hall1.Doors();
			amount = Convert.ToInt32(customerCount * listSeats.GetLength(1) * listSeats.GetLength(0));
			AssignCustomers(amount);
			AssignCustomerSeats();

			for (int i = 0; i < hall1.GetRow(); i++)
			{
				for (int j = 0; j < hall1.GetColumn(); j++)
				{
					System.Windows.Forms.Panel p = new System.Windows.Forms.Panel();
					p.Location = new System.Drawing.Point(listSeats[i, j].seatPositionX, listSeats[i, j].seatPositionY);
					p.Size = new System.Drawing.Size(listSeats[i, j].SHeight, listSeats[i, j].SWidth);
					p.BackColor = listSeats[i, j].seatColour;

					FormScreen.Controls.Add(p);
				}
			}

			for (int i = 0; i < hall1.GetDoorAmount(); i++)
			{
				System.Windows.Forms.Panel p = new System.Windows.Forms.Panel();
				p.Location = new System.Drawing.Point(doors[i].DoorPositionX, doors[i].DoorPositionY);
				p.Size = new System.Drawing.Size(doors[i].DoorWidth, doors[i].DoorHeight);
				p.BackColor = System.Drawing.Color.Tomato;
				FormScreen.Controls.Add(p);
			}
			generateCustomer();
		}

		public void generateCustomer() 
		{
			for (int i = 0; i < amount; i++)
			{
				System.Windows.Forms.Panel pnlUser = new System.Windows.Forms.Panel();
				users.Add(pnlUser);
				users[i].Location = new System.Drawing.Point((doors[0].DoorPositionX + doors[0].DoorWidth) / 2, doors[0].DoorPositionY);

				users[i].BackgroundImage = customers[i].UserObject;
				users[i].Size = new System.Drawing.Size(8, 8);
				FormScreen.Controls.Add(users[i]);
				randSpace = rand.Next(11, 40);
				doors[0].DoorPositionY -= randSpace;
			}
		}
		public void UserGoToSeat()
		{
			customer.goToSeat(amount, this.users, this.listSeats, this.customers, this.FormScreen);
		}

	}
}
