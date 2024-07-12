namespace Task3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			  List<int> numbers = new List<int> { 1, 45, 23, 42, 67, 98, 2 }; bu listin max ededinden 1
				vahid az olan eded ile listin min ededinden 1 vahid cox olan ededin ferqini tapan funksiya yazin
			 */
			List<int> numbers = new List<int> { 1, 45, 23, 42, 67, 98, 2 };

			numbers.Sort();
			var result = numbers[numbers.IndexOf(numbers.Max()) - 1] - numbers[numbers.IndexOf(numbers.Min()) + 1];
            Console.WriteLine(result);

        }
	}
}
