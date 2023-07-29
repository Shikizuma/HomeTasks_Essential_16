using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks_Essential_16
{
	internal class Block
	{
		int a1;
		int a2;
		int a3;
		int a4;

		public Block(int a1, int a2, int a3, int a4) 
		{ 
			this.a1 = a1;
			this.a2 = a2;
			this.a3 = a3;
			this.a4 = a4;
		}

		public override bool Equals(object? obj)
		{
			Block? block = obj as Block;
			return a1 == block.a1 && a2 == block.a2 && a3 == block.a3 && a4 == block.a4;
		}

		public override int GetHashCode()
		{
			return a1 ^ a2 ^ a3 ^ a4;
		}
	}
}
