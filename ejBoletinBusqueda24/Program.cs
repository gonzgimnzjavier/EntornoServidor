namespace ejBoletinBusqueda24
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] frutas = { "naranja", "amorodo", "mazana", "platano", "pera" };

			Array.Sort(frutas);

			Console.WriteLine("Orden alafabetico:");
			Console.WriteLine("-------------------------------------------------");

			for (int i = 0; i < frutas.Length; i++) { Console.WriteLine(frutas[i]); }


			Array.Reverse(frutas);

			Console.WriteLine();
			Console.WriteLine("Orden alafabetico inverso:");
			Console.WriteLine("-------------------------------------------------");

			for (int i = 0; i < frutas.Length; i++) { Console.WriteLine(frutas[i]); }

			Console.ReadKey();
		}
	}
}
