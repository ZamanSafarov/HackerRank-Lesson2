namespace Task4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
				int[,] matrix = {
				    { 1, 2, 3, 4 },
				    { 5, 6, 7, 8 },
				    { 9, 10, 11, 12 },
				    { 13, 14, 15, 16 }
				}; bu matrixsin setirlerin sutun formatina getir ve tek sirada duran sutunlarla cut sirada duran sutunlarin yerini deyis
			 */
			int[,] matrix = {
			{ 1, 2, 3, 4 },
			{ 5, 6, 7, 8 },
			{ 9, 10, 11, 12 },
			{ 13, 14, 15, 16 }
		};

            Console.WriteLine("VERILEN MATRIX");
            PrintMatrix(matrix);

			Console.WriteLine("-----------------------------------");

			int rows = matrix.GetLength(0);
			int cols = matrix.GetLength(1);
			int[,] transposedMatrix = new int[cols, rows];



			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					transposedMatrix[j, i] = matrix[i, j];
				}
			}
			Console.WriteLine("matrixsin setirlerin sutun formatinda");
			PrintMatrix(transposedMatrix);


            Console.WriteLine("-----------------------------------");
			
			int[,] rearrangedMatrix = new int[cols, rows];
			for (int i = 0; i < cols; i++)
			{
				for (int j = 0; j < rows; j++)
				{
					if (j % 2 == 0)
					{
						rearrangedMatrix[i, j] = transposedMatrix[i, j + 1];
					}
					else
					{
						rearrangedMatrix[i, j] = transposedMatrix[i, j - 1];
					}
				}
			}
			Console.WriteLine("tek sirada duran sutunlarla cut sirada duran sutunlarin yerini deyis");

			PrintMatrix(rearrangedMatrix);
		}

		static void PrintMatrix(int[,] matrix)
		{
			int rows = matrix.GetLength(0);
			int cols = matrix.GetLength(1);

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					Console.Write(matrix[i, j] + "\t");
				}
				Console.WriteLine();
			}
		}
	}
}
