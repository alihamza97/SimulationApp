using System;
using System.Collections.Generic;
using System.Drawing;

namespace simulation
{
	abstract class Customer
	{
		public int customerID, seatRow, seatColumn, simID, customerAmount, seatRowCustomers, seatColumnCustomers;
		public Hall hall;
		public Seat[,] seats;
		public Door[] doors;
		public Random rand;
		public int seatCounter = 0;
		public int speed = 1;
		SimulatingScreen FormScreen;
		public Image userObject = (Image)new System.Drawing.Bitmap(@"object.png");

		public Customer(int customerID, int customerAmount, Hall hall1)
		{
			this.customerID = customerID;
			this.customerAmount = customerAmount;

			
			hall = hall1;
			hall.HallConfiguration();
			seats = hall.Seats();
			doors = hall.Doors();

			seatRowCustomers = seats.GetLength(0); 
			seatColumnCustomers = seats.GetLength(1); 

			rand = new Random();

		}
		
		public int SeatRow
		{
			get { return this.seatRow; }
			set { seatRow = value; }
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

		public void goToSeat(int amount, List<System.Windows.Forms.Panel> users, Seat[,] listSeats, List<Customer> customers, SimulatingScreen FormScreen)
		{
			for (int i = 0; i < amount; i++)
			{
				if (users[i].Top < listSeats[customers[i].SeatRow, customers[i].seatColumn].seatPositionY - listSeats[customers[i].SeatRow, customers[i].seatColumn].SHeight)
				{
					if (i != 0 && users[i].Bottom >= users[i - 1].Top && users[i].Left >= users[i - 1].Left)
					{
						users[i].Top += 0;
					}
					else
					{
						users[i].Top += customers[i].Speed;
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
							if (users[i].Top == listSeats[customers[i].SeatRow, customers[i].seatColumn].seatPositionY)
							{
								users[i].BringToFront();
								seatCounter++;
							}
						}
					}

				}
			}


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
		}

	}



	class Female : Customer
	{
		public Female(int customerID, int customerAmount, Hall hallChosen)
			: base(customerID, customerAmount, hallChosen)
		{
			speed = 2;
			userObject = (Image)new System.Drawing.Bitmap(@"object.png");
		}
	}
	class Male : Customer
	{
		public Male(int customerID, int customerAmount, Hall hallChosen)
			: base(customerID, customerAmount, hallChosen)
		{
			speed = 2;
			userObject = (Image)new System.Drawing.Bitmap(@"object.png");
		}
	}

}
