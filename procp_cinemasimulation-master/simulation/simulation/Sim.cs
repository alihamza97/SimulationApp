using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace simulation
{
    public class Sim
    {
        private int simID, ageRating;
        string options;
       // Customer customer;
        private Seat[,] listSeats;
        private Shops[] listShops;
        private Door[] doors;
        private Shops[] shops;
        private Hall hall1;
        public static double GenderPercentage;

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
        public int[] CustomersList;


        SimulatingScreen FormScreen;
		Form1 fss;

        public static double customerCount;

        public Sim()
        {

        }


        //public void CalcAmountofCustomers() 
        //{
        //	Random random = new Random();
        //	customerCount = rand.NextDouble();		

        //}

        public void SetHall(string hallString)
        {
            if (hallString == "A") hall1 = new HallA();
            if (hallString == "A2") hall1 = new HallA2();

        }
        //int newAmount;
        public static int TotalCustomer;
        public double f, m;
        public int[] GenratedCustomers(int Amount)
        {
            Amount = amount;
            Console.WriteLine("amt: " + Amount.ToString());
           // this.newAmount = amount;
             f = Amount - Convert.ToDouble((Amount * (GenderPercentage / 100)));
          // Console.WriteLine("f: " + f.ToString());
             m = Amount - f;
           // Console.WriteLine("m: " + m.ToString());

            CustomersList = new int[2];
            CustomersList[0] = Convert.ToInt32(m);
            CustomersList[1] = Convert.ToInt32(f);


            return CustomersList;
        }
        public string GetNrOfMale()
        {
            return m.ToString();
        }
        public string GetNrOfFemale()
        {
            return f.ToString();
        }
        public void SeatsFilled()
		{
			for(int i = 0; i < amount; i++)
			{
				users[i].Controls.Add(GetLabel(i, 0));
				//System.Windows.Forms.Label seatFilled = ((Form1)FormScreen.Owner).SeatsfilledLbl;
				//seatFilled.Text = Convert.ToString(i);
			}
		}

		public System.Windows.Forms.Label GetLabel(int i,int j)
		{
			
			System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
			lbl.Text = listSeats[i, j].SeatId;
			return lbl;
		}

        public static bool timerStop=false;

        public void AssignCustomerSeats()
        {
            amount = Convert.ToInt32(CustomersList[0] + CustomersList[1]);
            for (int i = 0; i < amount; i++)
            {
                bool valid = true;

                while (valid)
                {


                    if (CustomersList[0] > 0)
                    {
                        customer = new Female(i, amount, hall1, ref rand);
                        CustomersList[0]--;
                        valid = false;
                    }
                    else if (CustomersList[1] > 0)
                    {
                        customer = new Male(i, amount, hall1, ref rand);
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
            timerStop = true;
            //shuffle the list
            Random random = new Random();
            foreach (Customer c in customers.ToList())
            {
                customers.Insert(random.Next(0, customers.Count + 1), c);
            }
        }
        //shuffle the list
        public void ShuffleCustomers()
        {
            Random random = new Random();
            foreach (Customer c in customers.ToList())
            {
                customers.Insert(random.Next(0, customers.Count + 1), c);
            }
        }
        public void StartSim(SimulatingScreen FormScreen)
        {
            this.FormScreen = FormScreen;
            hall1.HallConfiguration();
            listSeats = hall1.Seats();
            doors = hall1.Doors();
            shops = hall1.Shops();

            GenratedCustomers(amount);
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
            for (int i = 0; i < hall1.GetShopsAmount(); i++)
            {
                System.Windows.Forms.Panel p = new System.Windows.Forms.Panel();
                p.Location = new System.Drawing.Point(shops[i].shopsPositionX, shops[i].shopsPositionY);
                p.Size = new System.Drawing.Size(shops[i].shopsWidth, shops[i].shopsHeight);
                p.BackColor = System.Drawing.Color.BlueViolet;
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


            }
        }

        public void UserGoToSeat()
        {
            customer.goToShop(amount, this.users, this.shops, this.listSeats, this.customers, this.FormScreen);
        }

        //increase simulation speed
        public int IncreaseSimulationSpeed()
        {
            //foreach(var c in CustomersList)
            //{
           return customer.speed=0;
            // }

        }



    }
}
