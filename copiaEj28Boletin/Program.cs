namespace copiaEj28Boletin
{
	internal class Program
	{
		static void Main(string[] args)
		{

			int[] numeros = { 1, 2, 5, 4, 5 };

			static int[] copiadorArrays(int[] arr)
			{
				int[] copia = new int[arr.Length];

				Array.Copy(arr,copia,copia.Length);

				for (int i = 0; i<copia.Length; i++)
				{
					Console.WriteLine(copia[i]);
				}

				return copia;
			}

			copiadorArrays(numeros);

			Console.ReadKey();
		}
	}
}
