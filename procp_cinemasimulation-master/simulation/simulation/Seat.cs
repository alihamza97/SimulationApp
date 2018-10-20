using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation
{
 public	class Seat
	{
		private string seatId;
		private int positionX, positionY, seatHeight, seatWidth;
		private System.Drawing.Color seatColor;

		public Seat()
		{
		}

		public Seat(int seatposX, int seatposY)
		{
			this.positionX = seatposX;
			this.positionY = seatposY;
		}

		public Seat(string seatId, int posX, int posY, int height, int width)
		{
			this.seatId = seatId;
			this.positionX = posX;
			this.positionY = posY;
			this.seatHeight = height;
			this.seatWidth = width;
			this.seatColor = System.Drawing.Color.Green;
		}

		public string SeatId
		{
			get { return this.seatId; }
			set { seatId = value; }
		}
		public int seatPositionX
		{
			get { return this.positionX; }
			set { positionX = value; }
		}

		public int seatPositionY
		{
			get { return this.positionY; }
			set { positionY = value; }
		}

		public int SHeight
		{
			get { return this.seatHeight; }
			set { seatHeight = value; }
		}

		public int SWidth
		{
			get { return this.seatWidth; }
			set { seatWidth = value; }
		}

		public System.Drawing.Color seatColour
		{
			get { return this.seatColor; }
			set { seatColor = value; }
		}
	}
}
