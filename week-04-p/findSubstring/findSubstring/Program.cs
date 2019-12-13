using System;

namespace findSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            //Varianta 1

            string s1 = "The quick brown fox jumps over the lazy dog";
            string s2 = "koks";
            bool b = s1.Contains(s2);
            Console.WriteLine("'{0}' is in the string '{1}': {2}",
                            s2, s1, b);
            if (b)
            {
                int index = s1.IndexOf(s2);
                if (index >= 0)
                    Console.WriteLine("'{0} begins at character position {1}",
                                  s2, index + 1);
            }

            /*
            static int isSubstring(string s1, string s2)
            {
                int M = s1.Length;
                int N = s2.Length;

                /* A loop to slide pat[] one by one */
            /*for (int i = 0; i <= N - M; i++)
            {
                int j;
            */
            /* For current index i, check for 
            pattern match */
            /*          for (j = 0; j < M; j++)
                          if (s2[i + j] != s1[j])
                              break;

                      if (j == M)
                          return i;
                  }

                  return -1;
              }
          */
            /* Driver program to test above function */
            /*public static void Main()
            {
                string s1 = "jor";
                string s2 = "geeksforgeeks";

                int res = isSubstring(s1, s2);

                if (res == -1)
                    Console.WriteLine(res);
                else
                    Console.Write("Present at index " + res);*/

        }
    }
    
}
