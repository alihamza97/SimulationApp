using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation
{
	class Shops
	{
		private int shopWidth, shopHeight, shopPositionX, shopPositionY;

		public Shops(int shopWidth, int shopHeight, int positionX, int positionY)
		{
			this.shopWidth = shopWidth;
			this.shopHeight = shopHeight;
			this.shopPositionX = positionX;
			this.shopPositionY = positionY;
		}

		public int shopsWidth
		{
			get { return this.shopWidth; }
			set { shopWidth = value; }
		}
		public int shopsHeight
		{
			get { return this.shopHeight; }
			set { shopHeight = value; }
		}

		public int shopsPositionX
		{
			get { return this.shopPositionX; }
			set { shopPositionX = value; }
		}
		public int shopsPositionY
		{
			get { return this.shopPositionY; }
			set { shopPositionY = value; }
		}
	}
}
