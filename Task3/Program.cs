namespace Task3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Shallow copy
			House houseOrig = new House(20000, "st. Peremoha 1/3");
			House? houseCopy = houseOrig.Clone() as House;

			Console.WriteLine("ShallowCopy: ");

			Console.WriteLine($"houseOrig: Cost({houseOrig.Cost}), Adress({houseOrig.Adress})");
			Console.WriteLine($"houseOrig: Cost({houseCopy.Cost}), Adress({houseCopy.Adress})");

			houseCopy.Adress = "Sportyvna 1";
			houseCopy.Cost = 100;

			Console.WriteLine("After shallow copy:");

			Console.WriteLine($"houseOrig: Cost({houseOrig.Cost}), Adress({houseOrig.Adress})");
			Console.WriteLine($"houseOrig: Cost({houseCopy.Cost}), Adress({houseCopy.Adress})");

			Console.WriteLine(new string('-', 30));

			//Deep copy
			House houseOrig1 = new House(20000, "st. Peremoha 1/3");
			House? houseCopy1 = houseOrig1.DeepClone() as House;

			Console.WriteLine("DeepCopy: ");

			Console.WriteLine($"houseOrig1: Cost({houseOrig1.Cost}), Adress({houseOrig1.Adress})");
			Console.WriteLine($"houseOrig1: Cost({houseCopy1.Cost}), Adress({houseCopy1.Adress})");

			houseCopy1.Adress = "Sportyvna 1";
			houseCopy1.Cost = 100;

			Console.WriteLine("After deep copy:");

			Console.WriteLine($"houseOrig1: Cost({houseOrig1.Cost}), Adress({houseOrig1.Adress})");
			Console.WriteLine($"houseOrig1: Cost({houseCopy1.Cost}), Adress({houseCopy1.Adress})");

		}
	}
}