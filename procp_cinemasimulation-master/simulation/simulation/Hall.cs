using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation
{
	abstract class Hall
	{
		public int seatAmount;
	    public int doorAmount;
		public int shopAmount;

		public string name;
		public int PositionX, PositionY,
			Height, Width,
			Row, Column;
        public int shopsAmount;
		public Seat[,] seats;
		public Door[] doors;
		public Shops[] shops;

		public abstract void HallConfiguration()
		;

		public int GetSeatAmount()
		{
			return seatAmount;
		}
		public int GetDoorAmount()
		{
			return doorAmount;
		}
		public int GetShopsAmount()
		{
			return shopAmount;
		}
		public Seat[,] Seats()
		{
			return this.seats;
		}

		public Door[] Doors()
		{
			return this.doors;
		}
		public Shops[] Shops()
		{
			return this.shops;
		}

		public int GetRow()
		{
			return Row;
		}
		public int GetColumn()
		{
			return Column;
		}
	
	}
}
