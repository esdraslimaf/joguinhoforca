using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /* TENTATIVA DE FAZER JOGO DA FORCA AS CEGAS. NÃO VI QUALQUER VIDEO-AULA SOBRE O ASSUNTO OU
            ALGO QUE INDUZA E PENSAR EM UMA LÓGICA. RESOLVI TENTAR POR SI SÓ, TENDO IDEIAS DA MINHA CABEÇA

            Este código serve de backup, pois depois irei reconstrui-lo, dá para melhorar bastante o código,
            pois o mesmo está feio/incompleto. */

            //OBS: Não esquecer de transformar a letra em char, etc, pois está como string.

            Console.Write("Insira uma palavra: ");
            string[] palavra = Console.ReadLine().Split();

            while (palavra[0] == null || palavra[0].Count() <= 0)
            { // ESSA FOI A MODIFICAÇÃO
                Console.Write("Insira uma palavra: ");
                palavra = Console.ReadLine().Split();
            }


            int vida = 5;
            int diminuir = 0;
            int pontos = 0;
            int qteletras = palavra[0].Count();
            int tentativa = 1;


            Console.Clear();
            Console.WriteLine(" ");
            Console.WriteLine("Dica: A palavra tem: " + qteletras + " letras");

            for (int i = 0; i < qteletras; i++)
            {
                Console.Write(" _ ");

            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");


            bool jogando = true;

            while (jogando)
            {
                Console.Write(+tentativa + "° tentativa. " + "Letra: ");
                string letra = Console.ReadLine();
                while (letra == null || letra == "")
                { // ESSA FOI A MODIFICAÇÃO
                    Console.Write(+tentativa + "° tentativa. " + "Letra: ");
                    letra = Console.ReadLine();
                }
                // diminuir++;

                if (palavra[0].Contains(letra) == false)
                {
                    vida--;
                    Console.WriteLine("Errou");
                    Console.WriteLine("Você tem: " + vida + " vidas");
                }
                else { diminuir++; }

                if (vida == 0)
                {

                    Console.WriteLine("Você perdeu");
                    break;
                }

                for (int j = 0; j < palavra[0].Count() - diminuir; j++)
                {
                    if (palavra[0].Contains(letra) == true)
                    {

                        Console.Write(" _ ");

                    }

                }

                if (palavra[0].Contains(letra) == true)
                {
                    pontos++;
                }
                if (pontos < palavra[0].Count() && palavra[0].Contains(letra) == true)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("Você acertou uma letra.");

                }

                if (pontos == palavra[0].Count())
                {
                    Console.WriteLine("Você ganhou, acertou todas as letras.");
                    break;
                }
                Console.WriteLine("");

                Console.WriteLine(" ");
                tentativa++;

                /*if(palavra[0].Contains(letra) == false)
                {
                    vida--;
                }
                
                else { Console.WriteLine("Você acertou uma letra"); } */
            }


        }

        /* if (checker)
         {
             Console.Write(letra);

             for (int i = 0; i < palavra[0].Length-1; i++)
             {
                 Console.Write(" _ ");
             }
         }
         else { Console.WriteLine("Você errou, menos uma vida.");
             vida--; 
         }*/

    }

}