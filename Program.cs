using System;

namespace Calculomedia
{
    class Program
    {
        static void Main(string[] args)
        {
            float notaUm;
            float notaDois;
            float media;

            Console.WriteLine("Digite a primeira nota com apenas 1 casa decimal");
            notaUm = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota com apenas 1 casa decimal");
            notaDois = float.Parse(Console.ReadLine());
            
            media = (notaUm + notaDois)/2;
            Console.WriteLine("Sua média é "+media);

            if(media>=5){
                Console.WriteLine("Parabéns, você foi aprovado!");
            }else{
                Console.WriteLine("Você foi Reprovado. Que pena!");
            }
            }

        }
    }

