using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        string MESSAGE = Console.ReadLine();
        // message turn to char arry
        char[] charArray = MESSAGE.ToArray();

        //char to binary. 
        int numOfArray = charArray.Length;
        List<int> myNumber = new List<int>();
        
        foreach (char c in MESSAGE)
        {
            myNumber.Add((int)c);
        }
        foreach(int num in myNumber)
        {
            Console.Write(num);
        }
        Console.WriteLine();

        List<string> myBinary = new List<string>();
        foreach (int num in myNumber)
        {
            myBinary.Add(Convert.ToString(num, 2));
        }

        foreach (string s in myBinary)
        {
            Console.Write(s);
        }
        Console.WriteLine();

        List<char> myChar = new List<char>();
        foreach (string a in myBinary)
        {
            myChar.Add(Convert.ToChar(a));
        }

        foreach (char ch in myChar)
        {
            Console.Write(ch + ",");
        }
        Console.WriteLine();


        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine("answer");
    }
}
