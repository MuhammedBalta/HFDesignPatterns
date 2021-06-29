using System;
using System.Collections.Generic;
using System.Text;

namespace HFDesignPatterns
{
    public class FlyNoWay : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}
