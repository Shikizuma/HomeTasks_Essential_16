using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
	internal struct Coordinate
	{
		double x;
		double y;
		double z;

        public Coordinate(double x, double y, double z)
        {
            this.x = x; 
			this.y = y; 
			this.z = z;
        }

		public static Coordinate operator +(Coordinate a, Coordinate b)
		{
			return new Coordinate
			{
				x = a.x + b.x,
				y = a.y + b.y,
				z = a.z + b.z
			};
		}

		public override string ToString() => $"Coordinates(x: {x}, y: {y}, z: {z})";
	}
}
