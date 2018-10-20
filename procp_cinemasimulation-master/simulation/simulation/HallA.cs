using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation
{
	class HallA:Hall
	{
		public override void HallConfiguration()
		{
			PositionX = 120;
			PositionY = 90;

			Height = 10;
			Width = 10;

			Row = 10;
			Column = 22;

			seatAmount = Row * Column;
			seats = new Seat[Row, Column];

			doors = new Door[2];
			doorAmount = doors.Length;
			for (int i = 0; i < Row; i++)
			{
				for (int j = 0; j < Column; j++)
				{
					
					if (j == (Column / 2))
					{
						PositionX = PositionX + 20;
					}

					seats[i, j] = new Seat(name + "" + (j + 1), PositionX, PositionY, Height, Width);
					PositionX = PositionX + 13;
				}
				PositionX = 120;
				PositionY = PositionY + 20;
			}
			doors[0] = new Door(50, 10, 30, 0);
			doors[1] = new Door(50, 10, 30, 0);

		}
	}
}
