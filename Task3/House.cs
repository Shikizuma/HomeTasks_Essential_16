using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	internal class House : ICloneable
	{
		private int cost;

		public int Cost
		{
			get { return cost; }
			set { cost = value; }
		}

		private string? adress;

		public string Adress
		{
			get { return adress; }
			set { adress = value; }
		}

        public House(int cost, string adress)
        {
            Cost = cost;
			Adress = adress;
        }

        public object Clone()
		{
			return this;
		}

		public object DeepClone() => new House(Cost, Adress);
	}
}
