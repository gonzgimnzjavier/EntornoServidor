namespace variablesEj9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horasTrabajadasMes = 0;
            double tasaPorHora = 0;
            double IRPF = 0;
            String userInput = "";

            Console.WriteLine("Introduce el numero de horas trabajadas por mes:");
            int.TryParse(userInput=Console.ReadLine(), out horasTrabajadasMes);
            Console.WriteLine("Introduce la tasa por hora:");
            double.TryParse(userInput=Console.ReadLine(), out tasaPorHora);
            Console.WriteLine("Introduce el IRPF:");
            double.TryParse(userInput = Console.ReadLine(), out IRPF);
            
            double salarioBruto = horasTrabajadasMes * tasaPorHora;
            double salarioNeto = salarioBruto - (salarioBruto * (IRPF / 100));

            Console.WriteLine("Tu salario bruto es de: " + salarioBruto + " y tu salario neto es de: " + salarioNeto);
            Console.ReadKey();
        }
    }
}
