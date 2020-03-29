﻿using System;
using System.Collections.Generic;

namespace Duck
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.performQuack();
            mallard.performFly();
            mallard.display();
        }
    }
}