using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22072024_DicesChancesOfBecomingADuchess_CodersLife
{
    public class Program
    {
        static void Main(string[] args)
        {
            int rolledDiceCount = 0;
            bool foundSuccess = false;
            for (int i = 0; i < 1000; i++) // 1000 defa oyun oynanacak
            {
                Player player = new Player("Ahmet");
                Dice firstDice = new Dice();
                Dice secondDice = new Dice();
                int successCount = 0;
                for (int k = 0; k < 1000; k++) // Her oyunda 1000 defa zar atılacak
                {
                    rolledDiceCount++;
                    (int roll1, int roll2) = player.RollDice(firstDice, secondDice);
                    if (roll1 == 6 && roll2 == 6)
                    {
                        successCount++;
                    }
                    else
                    {
                        successCount = 0;
                    }

                    if (successCount == 1000)
                    {
                        Console.WriteLine("1000 defa üst üste 6-6 geldi.");
                        foundSuccess = true;
                        System.Threading.Thread.Sleep(10000);
                        break;
                    }
                }

                if (foundSuccess)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"{i + 1}. deneme içerisinde 1000 kez üst üste 6-6 gelmedi.");
                    //System.Threading.Thread.Sleep(1);
                    Console.Clear();
                }
            }

            Console.WriteLine($"Oyun sonlandı. Atılan zar sayısı: {rolledDiceCount}");
            Console.ReadLine();
        }
    }

}
