using SimUDuck.Interface;

namespace SimUDuck.Metodos
{
    public class FlyNoWay : IFlyBehavior
    {        
        void IFlyBehavior.Fly()
        {
            System.Console.WriteLine("I can't fly.");
        }
    }
}