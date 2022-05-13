using SimUDuck.Interface;

namespace SimUDuck.Metodos
{
    public class Quack : IQuackBehavior
    {     
        void IQuackBehavior.Quack()
        {
            System.Console.WriteLine("Quack");
        }
    }
}