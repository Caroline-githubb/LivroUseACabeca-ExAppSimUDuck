using SimUDuck.Metodos;

namespace SimUDuck.Classes
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }

        public override void Display()
        {
            System.Console.WriteLine("I'am Model Duck");
        }
    }
}