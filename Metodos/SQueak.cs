using SimUDuck.Interface;

namespace SimUDuck.Metodos
{
    public class SQueak : IQuackBehavior
    {
        public void Quack()
        {
            System.Console.WriteLine("Squeak");
        }
    }
}