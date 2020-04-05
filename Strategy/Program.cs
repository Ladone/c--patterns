using System;
using System.Collections.Generic;
using System.Xml.Schema;
using Duck.Behaviour;

namespace Duck
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.performQuack();
            mallard.display();
            mallard.performFly();
            mallard.setFlyBehaviour(new FlyRocketPowered());
            mallard.performFly();
        }
    }
}