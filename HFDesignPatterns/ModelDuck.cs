using System;
using System.Collections.Generic;
using System.Text;

namespace HFDesignPatterns
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }
        public override void display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }

}
