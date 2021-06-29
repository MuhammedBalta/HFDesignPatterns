using System;
using System.Collections.Generic;
using System.Text;

namespace HFDesignPatterns
{
    public class MiniDuckSimulator
    {
        public static void Run()
        {
            Duck mallard = new MallardDuck();
            mallard.performQuack();
            mallard.performFly();

            Duck model = new ModelDuck();
            model.performFly();
            model.flyBehavior = new FlyRocketPowered();
            model.performFly();
        }
    }
}
