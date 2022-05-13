using SimUDuck.Interface;

namespace SimUDuck.Metodos
{
    public class FlyWithWings : IFlyBehavior
    {       
        void IFlyBehavior.Fly()
        {
            System.Console.WriteLine("I'm flying!!");
        }
    }
}