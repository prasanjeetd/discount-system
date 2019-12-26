using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Classlibrary.Algorithms
{
    public class Toptal
    {
        public int Demo()
        {
            Console.WriteLine("Billa");

            Console.WriteLine("Billaaa");

            int[] A = { 1, 3, 6, 4, 1, 2 };

            var b = A.Where(x => x >= 0).ToList();

            Console.WriteLine("results" + b.Count());

            b.Sort();

            for (int i = 0; i < b.Count() - 1; i++)
            {
                int nextItem = b[i + 1];
                int nextValue = b[i] + 1;


                if (nextItem > nextValue)
                {
                    Console.WriteLine("nextItem" + nextValue);

                }

                continue;
            }

            if (b.Count() > 0)
            {
                return ++b[b.Count() - 1];
            }
            else
            {
                return 0;
            }

        }

        public void Start()
        {



        }
    }
}
