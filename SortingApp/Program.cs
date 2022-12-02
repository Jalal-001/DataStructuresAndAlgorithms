using SortingAlgorithms;

internal class Program
{
	private static void Main(string[] args)
	{
		var array = new int[] { 10, 30, 50, 45, 60, 90, 80 };
		Write(array);
		SortingAlgorithms.BubbleSort.Sort(array);
		//SortingAlgorithms.SelectionSort.Sort(array);
		Write(array);

        static void Write<T>(T[] array)
		{
			Console.WriteLine();
			foreach (var item in array)
			{
				Console.Write($"{item,-7}");
			}
            Console.WriteLine();
        }
    }
}

