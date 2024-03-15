namespace Calc.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Calculadora*****");
            Console.WriteLine("");
            double resultado;
            while (true)
            {

                Console.WriteLine("|||||Menu|||||");
                Console.WriteLine("Somar: 1");
                Console.WriteLine("Diminuir: 2");
                Console.WriteLine("Multiplicar: 3");
                Console.WriteLine("Dividir: 4");
                Console.WriteLine("Sair: 0");
                Console.WriteLine("Informe a operacao: ");

                double tipo = Convert.ToInt32(Console.ReadLine());


                if (tipo == 1)
                {

                    Console.WriteLine("\n***Somar***\n");
                    Console.WriteLine("Informe o primeiro numero: ");
                    double x = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Informe o segundo numero: ");
                    double y = Convert.ToDouble(Console.ReadLine());

                    resultado = x + y;

                    Console.WriteLine("\n* Resultado da Soma é: " + resultado + " *");
                }
                else if (tipo == 2)
                {
                    Console.WriteLine("\n***Subtracao***\n");
                    Console.WriteLine("Informe o primeiro numero: ");
                    double x = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Informe o segundo numero: ");
                    double y = Convert.ToDouble(Console.ReadLine());

                    resultado = x - y;

                    Console.WriteLine("\n* Resultado da Subritacao é: " + resultado + " *");
                }
                else if (tipo == 3)
                {
                    Console.WriteLine("\n***Multiplicar***\n");
                    Console.WriteLine("Informe o primeiro numero: ");
                    double x = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Informe o segundo numero: ");
                    double y = Convert.ToDouble(Console.ReadLine());

                    resultado = x * y;

                    Console.WriteLine("*\n Resultado da Multiplicacao é: " + resultado + " *");
                }
                else if (tipo == 4)
                {
                    Console.WriteLine("Informe o primeiro numero: ");
                    double x = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Informe o segundo numero: ");
                    double y = Convert.ToDouble(Console.ReadLine());

                    if (y == 0)
                    {
                        Console.WriteLine("\nImposivel dividir por 0!!");
                    }
                    else
                    {
                        resultado = x / y;

                        Console.WriteLine("\n* Resultado da Divisao é: " + resultado + " *");
                    }


                }
                else if (tipo == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("* Operacao Invalida!! *");
                }
                Console.WriteLine("");
                Console.WriteLine("--------------------------");
                Console.WriteLine("");
            }
        }
    }
}
