using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation
{
	public class Door
	{
		private int doorWidth, doorHeight, doorPositionX, doorPositionY;

		public Door(int doorWidth, int doorHeight, int pX, int pY)
		{
			this.doorWidth = doorWidth;
			this.doorHeight = doorHeight;
			this.doorPositionX = pX;
			this.doorPositionY = pY;
		}

		public int DoorWidth
		{
			get { return this.doorWidth; }
			set { doorWidth = value; }
		}
		public int DoorHeight
		{
			get { return this.doorHeight; }
			set { doorHeight = value; }
		}

		public int DoorPositionX
		{
			get { return this.doorPositionX; }
			set { doorPositionX = value; }
		}
		public int DoorPositionY
		{
			get { return this.doorPositionY; }
			set { doorPositionY = value; }
		}
	}
}
