using System;
using System.Collections.Generic;
using System.Text;

namespace HFDesignPatterns
{
    public class FlyRocketPowered : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }

}
