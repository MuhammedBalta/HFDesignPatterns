using System;
using System.Collections.Generic;
using System.Text;

namespace HFDesignPatterns
{
    public class MuteQuack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }

}
