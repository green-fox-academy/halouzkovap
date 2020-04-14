using System;

namespace alterSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            
                string s1 = "jor";
                string s2 = "geeksforgeeks";

                int res = isSubstring(s1, s2);

                if (res == -1)
                    Console.WriteLine(res);
                else
                    Console.Write("Present at index " + res);

         static int isSubstring(string s1, string s2)
        {
                int M = s1.Length;
                int N = s2.Length;

                /* A loop to slide pat[] one by one */
                for (int i = 0; i <= N - M; i++)
                {
                    int j;

                    /* For current index i, check for  pattern match */

                    for (j = 0; j < M; j++)
                        if (s2[i + j] != s1[j])
                            break;

                    if (j == M)
                        return i;
                }

                return -1;
            }
        }
            }
}
