using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22072024_DicesChancesOfBecomingADuchess_CodersLife
{
    public class Player
    {
        public string Name { get; set; }
        public Player(string _name)
        {
            Name = _name;
        }
        public (int roll1, int roll2) RollDice(Dice _dice1, Dice _dice2)
        {
            int roll1 = _dice1.Roll();
            int roll2 = _dice2.Roll();
            Console.WriteLine($"{Name} rolled: {roll1} and {roll2}");
            return (roll1, roll2);
        }
    }
}