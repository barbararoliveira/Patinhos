using System;

namespace Patinhos
{
    class Program
    {
        static void Main(string[] args)
        {
            int patinhos;
            int patofinal;
            bool patovalido;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" ----- CINCO PATINHOS ----- \n");

            ConsoleColor padrao = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Quantos patinhos (mínimo 2)? ");
            patovalido = Int32.TryParse(Console.ReadLine(), out patinhos);

            if (!patovalido || patinhos < 2)

            {
                Console.Write("Programa finalizado: número de patinhos \n");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("INVÁLIDO.");
                Console.ForegroundColor = padrao;
                Environment.Exit(-1);
            }

            for (patofinal = patinhos; patofinal > 0; patofinal--)

            {
                if (patofinal > 1)

                {
                    Console.WriteLine($"\n{patofinal} patinhos foram passear");
                }

                else

                {
                    Console.WriteLine($"\n{patofinal} patinho foi passear");
                }

                Console.WriteLine($"Além das montanhas");
                Console.WriteLine($"Para brincar");
                Console.WriteLine($"A mamãe gritou: Quá, quá, quá, quá");

                if (patofinal > 2)

                {
                    Console.WriteLine($"Mas só {patofinal - 1} patinhos voltaram de lá.\n");
                }

                else if (patofinal == 1)

                {
                    Console.WriteLine($"Mas nenhum patinho voltou de lá.\n");
                }

                else

                {
                    Console.WriteLine($"Mas só {patofinal - 1} patinho voltou de lá.\n");
                }

            }

            Console.WriteLine("A mamãe patinha foi procurar");
            Console.WriteLine("Além das montanhas na beira do mar");
            Console.WriteLine("A mamãe gritou: Quá, quá, quá, quá");
            Console.WriteLine($"E os {patinhos} patinhos voltaram de lá\n");

            Console.WriteLine("Pressione enter para finalizar <3 ");
            Console.ReadKey();

        }
    }
}
