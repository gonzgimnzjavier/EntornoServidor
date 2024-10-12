namespace Ej32Boletin
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Random rnd = new Random();

			double media;

			int contadorExamenesPorEncimaDeLaMedia=0;

			List<int> notasExamenes = new List<int>();

			for (int i = 0; i <= rnd.Next(2, 11); i++) { 
				notasExamenes.Add(rnd.Next(0,11));
			}

			media = notasExamenes.Average();


			for (int i = 0; i < notasExamenes.Count; i++)
			{
				if (notasExamenes[i] >media) {

					contadorExamenesPorEncimaDeLaMedia++;
				}
			}

			Console.WriteLine(media.ToString());

			Console.WriteLine("El porcentaje de exámenes por encima de la media es: " +((double)contadorExamenesPorEncimaDeLaMedia / notasExamenes.Count) * 100);

			if (media < 5)
			{
				Console.WriteLine("El alumno esta suspenso");
			}
			else if (media >= 5 && media < 7)
			{
				Console.WriteLine("El alumno esta aprobado");
			}
			else if (media >= 7 && media < 9)
			{
				Console.WriteLine("El alumno tiene un notable");
			}
			else if (media >= 9 && media <= 10)
			{
				Console.WriteLine("El alumno tiene un sobresaliente");
			}
			else
			{
				Console.WriteLine("ERROR");
			}

			Console.ReadLine();
		}
	}
}
