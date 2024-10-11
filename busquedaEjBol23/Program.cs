namespace busquedaEjBol23
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] frutas = { "naranja", "manzana", "pomelo", "platano" };

			Console.WriteLine("Introduzca una fruta:");

			string frutaABuscar = Console.ReadLine();

			int indice = Array.IndexOf(frutas, frutaABuscar);

			if (indice == -1)
			{

				Console.WriteLine(frutaABuscar + " no se encuentra en el array");
			}
			else {
				Console.WriteLine(frutaABuscar + " se encuentra en el array en la "+indice+"ª posicion");
			}

			Console.ReadKey();

		}
	}
}
