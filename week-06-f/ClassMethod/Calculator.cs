using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethod
{
    class Calculator
    {
        public int Add(params int[] number)
        {
            var sum = 0;
            foreach (var num in number)
            {
                sum += num;
            }
            return sum;
        }
    }
}
