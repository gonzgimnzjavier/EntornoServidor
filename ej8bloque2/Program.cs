namespace ej8bloque2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[2];

            string userInpunt = "";

            double masPequeno = 0;

            double masMayor = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Introduce el " + (i + 1) + "º numero:");
                double.TryParse(userInpunt = Console.ReadLine(), out numeros[i]);
                if (i == 0)
                {
                    masMayor += numeros[i];
                    masPequeno += numeros[i];
                }
                else
                {
                    if (numeros[i] > masPequeno)
                    {
                        masMayor = numeros[i];
                    }
                   else if (numeros[i] < masPequeno)
                    {
                        masPequeno = numeros[i];
                    }
                    
                }

            }
            double resultado = Math.Pow(masMayor, masPequeno);
            Console.WriteLine(resultado);
            Console.ReadKey(); 
        }
    }
}
    

