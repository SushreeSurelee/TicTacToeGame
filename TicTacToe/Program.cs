using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToeGame ticTacToe = new TicTacToeGame();
            Console.WriteLine("Welcome To tic tak toe game");
            ticTacToe.TicTacToe();
            Console.ReadLine();
        }
    }
}
