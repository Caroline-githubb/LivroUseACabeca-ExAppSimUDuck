using SimUDuck.Interface;

namespace SimUDuck.Classes
{
    public abstract class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        public Duck()
        {

        }
        
        public abstract void Display();

        public void PerformFly()
        {
            flyBehavior.Fly();
        }
        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void Swim()
        {
            System.Console.WriteLine("All ducks float, even toys ...");
        }

    }
}