using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarChiper
{
    internal class Program
    {
        static string plainText;
        static int shift;
        static void Main(string[] args)
        {
            Console.WriteLine("1. Encode Caesar Message");
            Console.WriteLine("2. Quit");

            string selection = Console.ReadLine();

            switch (selection)
            {
                case "1":
                    Console.WriteLine("Enter in a sentence to be shifted: ");
                    plainText = Console.ReadLine();

                    Console.WriteLine("Enter a shift value: ");
                    shift = Convert.ToInt32(Console.ReadLine());

                    ShiftMessage(plainText, shift);
                    break;
            }
            Console.ReadLine();
        }

        static void ShiftMessage(string plainText, int shift)
        {
            char[] charLetters = plainText.ToLower().ToCharArray();
            string cipherText = "";

            for (int i = 0; i < charLetters.Length; i++)
            {
                int originalValue = (int)charLetters[i];

                if (originalValue > 96 && originalValue < 123)
                {
                    int shiftedValue = 0;

                    if ((originalValue + shift) > 123)
                    {
                        int leftOver = 122 - originalValue;
                        shiftedValue = 96 + (shift - leftOver);
                    }
                    else
                    {
                        shiftedValue = originalValue + shift;
                    }

                    string newLetter = Convert.ToChar(shiftedValue).ToString();
                    cipherText += newLetter;
                }
                else
                {
                    string newLetter = Convert.ToChar(originalValue).ToString();
                    cipherText += newLetter;
                }
            }

            Console.WriteLine("\n" + cipherText);
        }
    }
}
