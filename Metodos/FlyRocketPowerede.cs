using SimUDuck.Interface;

namespace SimUDuck.Metodos
{
    public class FlyRocketPowerede : IFlyBehavior
    {
        public void Fly()
        {
            System.Console.WriteLine("I'm flying with  rocket");
        }
    }
}