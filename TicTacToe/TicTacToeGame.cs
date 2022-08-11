using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class TicTacToeGame
    {
        public static void TicTacToe()
        {
            char[] game = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int i=1;i<10;i++)
            {
                game[i] = ' ';
            }
        }
    }
}
