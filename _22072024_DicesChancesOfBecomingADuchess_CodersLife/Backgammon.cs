using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22072024_DicesChancesOfBecomingADuchess_CodersLife
{
    public class Backgammon
    {
        public Dice FirstDice { get; private set; }
        public Dice SecondDice { get; private set; }
        public Player Player1 { get; private set; }
        public Player Player2 { get; private set; }
        public Backgammon(Dice _firstDice, Dice _secondDice, Player _player1, Player _player2)
        {
            FirstDice = _firstDice;
            SecondDice = _secondDice;
            Player1 = _player1;
            Player2 = _player2;
        }
    }
}
