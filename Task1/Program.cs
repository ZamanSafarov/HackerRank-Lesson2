namespace Task1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			 Array verilib qarisiq arr=[7,4,2,9,12,1,2] bu arrayin cut
				yerde duran edelerini artan ardicilligla duzun eger arrayde tekrar element varsa tekrarlanmasin.
			 */
			int[] arr = { 7, 4, 2, 9, 12, 1, 2 };

			List<int> filteredElements = new List<int>();
			for (int i = 0; i < arr.Length; i += 2)
			{
				filteredElements.Add(arr[i]);
			}

			List<int> result = filteredElements.Distinct().OrderBy(x => x).ToList();

			foreach (var element in result)
			{
				Console.WriteLine(element);
			}
		}
		
	}
}
