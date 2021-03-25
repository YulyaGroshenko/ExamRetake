using System;
using System.Collections.Generic;
using System.Text;

namespace Gallows
{
    static class Drawer
    {
        static public void PrintField()
        {
            for (int i = 0; i < Game.Word.Length; i++)
            {
                Console.Write(Game.Field[i]);
            }
        }
        static public void PrintLifes(int lifes)
        {
            Console.WriteLine($"количество жизней: {lifes}");
        }
        static public void WriteResult()
        {
            if (Game.Lifes == 0)
                Console.WriteLine("You lose");
            else
                Console.WriteLine("You win");
        }
    }
}
