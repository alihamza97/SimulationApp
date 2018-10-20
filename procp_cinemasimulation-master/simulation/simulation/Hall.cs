using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation
{
	abstract class Hall
	{
		public int seatAmount, doorAmount;

		public string name;
		public int PositionX, PositionY,
			Height, Width,
			Row, Column;

		public Seat[,] seats;
		public Door[] doors;

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
		public Seat[,] Seats()
		{
			return this.seats;
		}

		public Door[] Doors()
		{
			return this.doors;
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
