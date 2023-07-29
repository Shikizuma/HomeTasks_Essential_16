namespace Task6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Coordinate coordinate1 = new Coordinate(1,2,3);
			Coordinate coordinate2 = new Coordinate(5,5,5);

            Console.WriteLine(coordinate1 + coordinate2);
        }
	}
}