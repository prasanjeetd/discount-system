using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Classlibrary.Algorithms
{
    public class Problem
    {
        public void Solution()
        {

            List<int> num = new List<int> { 10, 20, 7 };
            int k = 4;

            int index = num.Count - 1;
            for (int i = 0; i < k; i++)
            {
                //num.Sort();

                //index = index % (i + 1);

                //decimal elem = num[index];
                decimal elem = num.Max();
                num.Remove((int)elem);
                //num.RemoveAt(index);

                decimal elemBy2 = (elem / 2);
                elem = (int)Math.Ceiling(elemBy2);
                num.Add((int)elem);

                /* Trying to fix the timeout issue*/
                //num.Insert(num.Count / 2, (int)elem);
                //num[index] = (int)elem;
            }

            int sum = 0;

            for (int i = 0; i < num.Count; i++)
            {
                sum = sum + num[i];
            }



        }
    }
}
