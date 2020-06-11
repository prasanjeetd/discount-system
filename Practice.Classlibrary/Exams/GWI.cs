using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Classlibrary.Exams
{
    public class GWI
    {
        public void Solution()
        {
            var line = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Input" + line);

            for (int i = 0; i < line; i++)
            {

                var a = Convert.ToInt64(Console.ReadLine());
                var b = Convert.ToInt64(Console.ReadLine());
                var k = Convert.ToInt64(Console.ReadLine());

                Console.WriteLine("a" + a);
                Console.WriteLine("b" + b);
                Console.WriteLine("k" + k);

                var res = a;

                for (int j = 1; j <= k; j++)
                {

                    if (j % 2 != 0)
                    {
                        res = res & b;
                    }
                    else
                    {
                        res = res | b;
                    }

                    Console.WriteLine("res" + res);
                }

                Console.WriteLine(res);


            }
        }
    }
}
