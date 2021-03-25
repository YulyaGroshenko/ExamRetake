using System;

namespace Gallows
{
    class Program
    {
        static void Main()
        {
            Game.FiilLetters();
            while (Game.Lifes != 0 && Game.Field.Contains("_ "))
            {
                Console.SetCursorPosition(0, 0);
                Drawer.PrintLifes(Game.Lifes);
                Drawer.PrintField();
                Console.Write("Введите букву: ");
                string letter = Console.ReadLine();
                Game.InsertRightLetter(letter);
            }
            Drawer.WriteResult();
        }
    }
}
