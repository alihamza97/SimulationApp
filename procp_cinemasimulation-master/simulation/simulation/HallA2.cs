using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation
{
	class HallA2 : Hall
	{
		public override void HallConfiguration()
		{
			PositionX = 120;
			PositionY = 90;

			Height = 10;
			Width = 10;

			Row = 10;
			Column = 22;
            shopAmount = 2;

            seatAmount = Row * Column;
			seats = new Seat[Row, Column];
			shops = new Shops[shopAmount];
			doors = new Door[2];
			shopAmount = shops.Length;
			doorAmount = doors.Length;
			for (int i = 0; i < Row; i++)
			{
				for (int j = 0; j < Column; j++)
				{

					if (i > 0 && i % 2 == 0 && j == 0)
					{
						PositionY= PositionY + 10;
					}

					seats[i, j] = new Seat(name + "" + (j + 1), PositionX, PositionY, Height, Width);
					PositionX = PositionX + 13;
				}
				PositionX = 120;
				PositionY = PositionY + 20;
			}
            doors[0] = new Door(50, 10, 30, 0);
            doors[1] = new Door(50, 10, 30, 0);
            shops[0] = new Shops(30, 30, 40, 50);
            shops[1] = new Shops(0, 0, 0, 0);
        }
	}
}
