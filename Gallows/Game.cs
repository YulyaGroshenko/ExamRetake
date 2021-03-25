using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Gallows
{
    static class Game
    {
        static public int Lifes { get; private set; } = 5;
        static public string Word { get; private set; } = GetWord();
        static public List<string> Field { get; private set; } = new List<string>();
        static public string GetWord()
        {
            string[] words = File.ReadAllLines("list.txt");
            Word = words[new Random().Next(words.Length)];
            return Word;
        }
        static public void FiilLetters()
         {
            for (int i = 0; i < Word.Length; i++)
            {
                Field.Add("_ ");
            }
        }
        static public void InsertRightLetter(string letter)
        {
            if (CheckLetter(letter))
            {
                for (int i = 0; i < Word.Length; i++)
                {
                    if (Word[i].ToString() == letter)
                        Field[i] = letter;
                }                
            }
            else
            {
                Lifes--;
            }
        }
        static public bool CheckLetter(string letter)
        {
            if (Word.Contains(letter))
                return true;
            else
                return false;
        }

    }
}
