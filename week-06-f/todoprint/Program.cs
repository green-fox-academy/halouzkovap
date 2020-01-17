using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todoprint
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> toDoList = new List<string>();

            string todoText2 = " - Buy milk";
            string todoText = "My todo";
            toDoList.Add(todoText);
            toDoList.Add(todoText2);
            
            toDoList.Add(" - Download games");  //to the end of the todoText
            toDoList.Add("     - Diablo"); // to the end of the todoText but with indentation

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo

            foreach (var item in toDoList)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
