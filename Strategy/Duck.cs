using System;
using Duck.Behaviour;

namespace Duck
{
    public abstract class Duck
    {
        protected FlyBehavior flyBehavior;
        protected QuackBehavior quackBehavior;

        public Duck()
        {
        }

        public abstract void display();

        public void performFly()
        {
            flyBehavior.fly();
        }

        public void performQuack()
        {
            quackBehavior.quack();
        }

        public void swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        public void setFlyBehaviour(FlyBehavior fb)
        {
            this.flyBehavior = fb;
        }

        public void setQuackBehaviour(QuackBehavior qb)
        {
            this.quackBehavior = qb;
        }
    }
}
