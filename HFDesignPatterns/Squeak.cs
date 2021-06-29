using System;
using System.Collections.Generic;
using System.Text;

namespace HFDesignPatterns
{
    public class Squeak : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Squeak");
        }
    }

}
