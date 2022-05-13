using SimUDuck.Interface;

namespace SimUDuck.Metodos
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            System.Console.WriteLine("<<silence>>");
        }       
    }
}