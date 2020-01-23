using System;

namespace morse
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Enter text you want to change to Morse code");
            string textToChange = Console.ReadLine().ToLower();


            Console.WriteLine("Text in Morse Code");
            Console.WriteLine(ToMorseCode(textToChange));
            Console.ReadKey();



        }
        static string ToMorseCode(string text)
        {
            char[] letters = { ' ', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            string[] morseLetters = { "    ", ". ___", "___ . . .", "___ . ___ .", "___ . .", ".", ". . ___ .", "___ ___ .", ". . . .", ". .", ". ___ ___ ___", "___ . ___", ". ___ . .", "___ ___", "___ .", "___ ___ ___", ". ___ ___ .", "___ ___ . ___", ". ___ .", ". . .", "_", ". . ___", ". . . ___", ". ___ ___", "___ . . ___", "___ . ___ ___", "___ ___ . .", ". ___ ___ ___ ___", ". . ___ ___ ___", ". . . ___ ___", ". . . . ___", ". . . . .", "___ . . . .", "___ ___ . . .", "___ ___ ___ . .", "___ ___ ___ ___ .", "___ ___ ___ ___ ___" };
            string textToChange = text;
            string newText = "";

            for (int i = 0; i < textToChange.Length; i++)
            {
                for (short j = 0; j < 37; j++)
                {
                    if (textToChange[i] == letters[j])
                    {
                        newText += morseLetters[j];
                        newText += "   ";
                        break;
                    }
                }
            }
            return newText;
        }
    }
}
