using System;
using System.Collections.Generic;
using System.Drawing;

namespace simulation
{
	abstract class Customer
	{
		public int customerID, seatRow, seatColumn, simID, customerAmount, seatRowCustomers, seatColumnCustomers,shopss,shopCustomers;
		public Hall hall;
		public Seat[,] seats;
		public Door[] doors;
		public Shops[] shops;
		//public Random rand;
	//	public int seatCounter = 0;
		public int speed=0;
        public static int spd=1;
		SimulatingScreen FormScreen;
		public Image userObject ;
        public bool hungry;
		public static int StopTimer = 0;
        public int max = 10;
        public int min = 1;
        public int HungaryRandomness;
		public static int SeatCounter=0;
		public int visitorCounter = 0;

        //public Random HungryRandom = new Random();
        public Random rand = new Random();
        public bool Hungry()
        {
            return hungry;
        }
        
		public Customer(int customerID, int customerAmount, Hall hall1,  ref Random r)
		{
			this.customerID = customerID;
			this.customerAmount = customerAmount;
            List<Customer> customers = new List<Customer>();

                this.HungaryRandomness = r.Next(0, 10);

                if (HungaryRandomness > 5)
                {
                    this.hungry = true;

                }
                else { this.hungry = false; }

            Console.WriteLine($"Number: {HungaryRandomness} hungry:{this.hungry}");

            hall = hall1;
			hall.HallConfiguration();
			seats = hall.Seats();
			doors = hall.Doors();
			shops = hall.Shops();

			seatRowCustomers = seats.GetLength(0); 
			seatColumnCustomers = seats.GetLength(1);
            shopCustomers = shops.GetLength(0);




        }


        public int SeatRow
		{
			get { return this.seatRow; }
			set { seatRow = value; }
		}
        public int Shopss
        {
            get { return this.shopss; }
            set { shopss = value; }
        }

        public int SeatColumn
		{
			get { return this.seatColumn; }
			set { seatColumn = value; }
		}
		public Image UserObject
		{
			get { return userObject; }
			set { userObject = value; }
		}

        static bool  boolStopShop = true;
        public static void StopShop()
        {
            boolStopShop = false;
            Console.WriteLine("stopShop");
        }
		public  int getSeatCounter()
		{
			return SeatCounter++;
		}

		//public static bool StopTimer = false;

        public void goToShop(int amount, List<System.Windows.Forms.Panel> users, Shops[] shops, Seat[,] listSeats, List<Customer> customers, SimulatingScreen FormScreen)
        {
            
            for (int i = 0; i < amount; i++)
            {
				
				if (customers[i].hungry==true) {


                    if (users[i].Top < shops[customers[i].Shopss].shopsPositionY - shops[customers[i].Shopss].shopsHeight)
                    {
                        if (i != 0 && users[i].Bottom >= users[i - 1].Top && users[i].Left >= users[i - 1].Left)
                        {
                            users[i].Top += 0;
                        }
                        else
                        {
                            //users[i].Top +=customers[i].speed;
                            users[i].Top += spd;
                        }
                    }
                    else
                    {
                        if (users[i].Left > shops[customers[i].Shopss].shopsPositionX)
                            users[i].Left -= 1;
                        else if (users[i].Left == shops[customers[i].Shopss].shopsPositionX)
                        {
                            while (users[i].Top < shops[customers[i].Shopss].shopsPositionY && boolStopShop == true)
                            {
                                users[i].Top += 1;
                                //shoppp
                                users[i].BringToFront();
                                                                                                                          
                            }
                            
                        }
                                               
                    }
                    if (users[i].Top < listSeats[customers[i].SeatRow, customers[i].seatColumn].seatPositionY - listSeats[customers[i].SeatRow, customers[i].seatColumn].SHeight)
                    {
                        if (i != 0 && users[i].Bottom >= users[i - 1].Top && users[i].Left >= users[i - 1].Left)
                        {
                            users[i].Top += 0;
                        }
                        else
                        {
                            //users[i].Top += customers[i].speed;
                            users[i].Top += spd;
                        }
                    }
                    else
                    {
                        if (users[i].Left < listSeats[customers[i].SeatRow, customers[i].seatColumn].seatPositionX)
                            users[i].Left += 2;
                        else if (users[i].Left == listSeats[customers[i].SeatRow, customers[i].seatColumn].seatPositionX)
                        {
                            while (users[i].Top < listSeats[customers[i].SeatRow, customers[i].seatColumn].seatPositionY)
                            {
                                users[i].Top += 1;
                                if (users[i].Top == listSeats[customers[i].SeatRow, customers[i].seatColumn].seatPositionY)
                                {
                                    users[i].BringToFront();
									visitorCounter++;
									System.Windows.Forms.Label lbl = ((Form1)FormScreen.Owner).NrShopVistor;
									lbl.Text = Convert.ToString(visitorCounter+" person(s) visted Shop");
									

									//StopTimer = true;
									//				seatCounter++;
								}
                                
                            }
                        }
                    }

                }
                else
                {
                    if (users[i].Top < listSeats[customers[i].SeatRow, customers[i].seatColumn].seatPositionY - listSeats[customers[i].SeatRow, customers[i].seatColumn].SHeight)
                    {
                        if (i != 0 && users[i].Bottom >= users[i - 1].Top && users[i].Left >= users[i - 1].Left)
                        {
                            users[i].Top += 0;
                        }
                        else
                        {
                            // users[i].Top +=customers[i].speed;
                            users[i].Top += spd;
                             //IncreaseSimulationSpeed();
                        }
                    }
                    else
                    {
                        if (users[i].Left < listSeats[customers[i].SeatRow, customers[i].seatColumn].seatPositionX)
                            users[i].Left += 1;
                        else if (users[i].Left == listSeats[customers[i].SeatRow, customers[i].seatColumn].seatPositionX)
                        {
                            while (users[i].Top < listSeats[customers[i].SeatRow, customers[i].seatColumn].seatPositionY)
                            {
                                users[i].Top += 1;
                                //IncreaseSimulationSpeed();

                                if (users[i].Top == listSeats[customers[i].SeatRow, customers[i].seatColumn].seatPositionY)
                                {
                                    users[i].BringToFront();
								
								}
								

							}
                        }
                    }
                   
                }

				SeatCounter = i+1 ;
				

				
			}
			
			System.Windows.Forms.Label lblSeat = ((Form1)FormScreen.Owner).seatsFilled;
			lblSeat.Text = Convert.ToString(SeatCounter );
			

		}
        

        public void FindSeat()
		{

			int columns, rows;
            rows = rand.Next(0, seatRowCustomers);
            columns = rand.Next(0, seatColumnCustomers);

            

            seatRow = rows;
			seatColumn = columns;
		}

       
        public int getCustomerAmount()
		{
			return customerAmount;
		}

		public int Speed
		{
			get { return this.speed; }
            set { this.speed = value; }
		}
        private int seatingRowArrangment()
        {
            return (seatRowCustomers / 2) - 1;
        }
        private int seatingColumnArrangment()
        {
            return (seatColumnCustomers / 2) - 2;
        }
    }


    

    class Female : Customer
	{
		public Female(int customerID, int customerAmount, Hall hallChosen, ref Random r)
			: base(customerID, customerAmount, hallChosen, ref r)
		{

           
            userObject = (Image)new System.Drawing.Bitmap(@"object2.png");
		}
	}
	class Male : Customer
	{
		public Male(int customerID, int customerAmount, Hall hallChosen, ref Random r)
			: base(customerID, customerAmount, hallChosen, ref r)
		{
           
            userObject = (Image)new System.Drawing.Bitmap(@"object.png");
		}
	}

}
