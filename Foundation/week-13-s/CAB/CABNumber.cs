using System;
using System.Collections.Generic;

namespace CAB
{
    public class CABNumber
    {
        public List<int> CABNum;
        private Random random;
        public List<int> GetCABNumber()
        {
            CABNum = CreateArrayNumber();
            return CABNum;
        }
        private List<int> CreateArrayNumber()
        {
            List<int> arr = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            var CABArr = new List<int>(4);
            random = new Random();
            do
            {
                int a = random.Next(arr.Count);
                if (!CABArr.Contains(a))
                {
                    CABArr.Add(a);
                }
                a = 0;

            } while (CABArr.Count < 4);

            return CABArr;
        }
    }
}
