namespace Task4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Date date = new Date(12, 12, 2023);
			Date date1 = new Date(23, 12, 2023);

            Console.WriteLine(date - date1);
            Console.WriteLine(date + 12);

        }
	}
}