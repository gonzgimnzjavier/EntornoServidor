namespace busquedadBoletinEj21
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] cadenas = new string[10];

			for (int i = 0; i < cadenas.Length; i++)
			{
				Console.WriteLine("Introduce la "+(i+1)+"ª cadena:");
				cadenas[i] = Console.ReadLine();
			}

			for (int i = 0;i < cadenas.Length; i++)
			{
				if (cadenas[i] == "" || cadenas[i] == " " || cadenas[i] == null)
				{
					Console.WriteLine("La primera cadena vacia esta en la " + i + "ª posicion");
					break;
				}
			}
			Console.ReadKey();
		}
	}
}
