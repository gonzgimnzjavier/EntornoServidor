namespace comparacionEj24Boletin
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] primerArrayNumeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
			int[] segundoArrayNumeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

			bool esLaSecuenciaIgual = primerArrayNumeros.SequenceEqual(segundoArrayNumeros);

			if (esLaSecuenciaIgual)
			{
				Console.WriteLine("la secuencia es igual");
			}
			else
			{
				Console.WriteLine("La secuencia es diferente");
			}
			Console.ReadKey();
		}
	}
}
