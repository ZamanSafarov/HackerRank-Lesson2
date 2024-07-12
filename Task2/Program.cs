namespace Task2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Bir string daxil edin:");
			string input = Console.ReadLine();

            Console.WriteLine(IsPolindrom(input));

        }
		static bool IsPolindrom(string str)
		{
			var left = 0;
			var right = str.Length-1;

			while (left < right)
			{
				if (str[left].ToString().ToLower() != str[right].ToString().ToLower())
				{
					return false;
				}
				left++;
				right--;
			}
			return true;
		}
	}
}
