using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Classlibrary.OOPS
{
    public class Base
    {
        public void Test()
        {
            Console.WriteLine("Test");
        }
    }

    public class Derived : Base
    {
        public new void Test()
        {
            Console.WriteLine("Billa");
        }
    }

    public class Runner
    {
        public void Run()
        {
            var derived = new Derived();
            derived.Test();
        }
    }
}
