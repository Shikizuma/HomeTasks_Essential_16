namespace HomeTasks_Essential_16
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Block block1 = new Block(1,2,3,4);
			Block block2 = new Block(2,3,4,5);
			Block block3 = new Block(1,2,3,4);

            Console.WriteLine($"Block1(Hash: {block1.GetHashCode()}) == Block2(Hash: {block2.GetHashCode()}): " + block1.Equals(block2));
            Console.WriteLine($"Block1(Hash: {block1.GetHashCode()}) == Block3(Hash: {block3.GetHashCode()}): " + block1.Equals(block3));
        }
	}
}