using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Calc.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int tipo = Menu();
                if (tipo < 5)
                {
                    switch (tipo)
                    {
                        case 0:
                            goto sair;
                        case 1:
                            Somar();
                            break;
                        case 2:
                            Sub();
                            break;
                        case 3:
                            Mult();
                            break;
                        case 4:
                            Divi();
                            break;
                    }

                }else
                {
                    Console.WriteLine("* Operacao Invalida!! *");
                    Console.WriteLine("\n--------------------------\n");
                }

            }
        sair:
            //Chama o menu principal
            static int Menu()
            {

                Console.WriteLine("*****Calculadora*****\n");
                Console.WriteLine("|||||Menu|||||");
                Console.WriteLine("Somar: 1");
                Console.WriteLine("Diminuir: 2");
                Console.WriteLine("Multiplicar: 3");
                Console.WriteLine("Dividir: 4");
                Console.WriteLine("Sair: 0");
                Console.WriteLine("Informe a operacao: ");

                return Convert.ToInt32(Console.ReadLine());
            }

            static void Somar()
            {
                Console.Clear();
                Console.WriteLine("***Somar***\n");
                Console.WriteLine("Informe o primeiro numero: ");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe o segundo numero: ");
                double y = Convert.ToDouble(Console.ReadLine());

                double resultado = x + y;

                Console.WriteLine("\n* Resultado da Soma é: " + resultado + " *");
            }

            static void Sub()
            {
                Console.Clear();
                Console.WriteLine("\n***Subtracao***\n");
                Console.WriteLine("Informe o primeiro numero: ");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe o segundo numero: ");
                double y = Convert.ToDouble(Console.ReadLine());

                double resultado = x - y;

                Console.WriteLine("\n* Resultado da Subritacao é: " + resultado + " *");
            }

            static void Mult()
            {
                Console.Clear();
                Console.WriteLine("\n***Multiplicar***\n");
                Console.WriteLine("Informe o primeiro numero: ");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe o segundo numero: ");
                double y = Convert.ToDouble(Console.ReadLine());

                double resultado = x * y;

                Console.WriteLine("*\n Resultado da Multiplicacao é: " + resultado + " *");
            }

            static void Divi()
            {
                Console.Clear();
                Console.WriteLine("\n***Divisao***\n");
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
                    double resultado = x / y;

                    Console.WriteLine("\n* Resultado da Divisao é: " + resultado + " *");
                }
            }
        }
    }
}
