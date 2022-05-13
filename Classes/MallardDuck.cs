using SimUDuck.Metodos;

namespace SimUDuck.Classes
{
    public class MallardDuck : Duck
    {   
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            System.Console.WriteLine("I'm a wild duck");
        }     
    }
}