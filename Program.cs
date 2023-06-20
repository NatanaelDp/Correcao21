using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correcao21
{    
    class Program
    {
        static void Main(string[] args)
        {

            int pontos = 0;

            Console.WriteLine("Bem-vindo ao jogo do 21");
            Console.WriteLine("Faça 21 pontos para vencer");
            while (true)
            {

                Console.WriteLine($"Você tem {pontos} pontos");
                Console.WriteLine("Digite 1 para continuar ou 2 para parar:");
                int resposta = int.Parse(Console.ReadLine());
                if (resposta == 2)
                {
                    Console.WriteLine("Fim de jogo");
                    break;
                    
                }
                Random sorteador = new Random();
                int numero = sorteador.Next(1,11);
                Console.WriteLine("Você tirou o número "  +numero);

                pontos +=numero;

                if (pontos>=21)
                {
                    Console.WriteLine("FIM DE JOGO!");
                    break;
                }

                Console.ReadKey();
            }
        }
    }
}
