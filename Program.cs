
using SimUDuck.Classes;
using SimUDuck.Metodos;

namespace SimUDuck
{
    public class Program
    {
        static void Main(string[] args)
        {
            Duck model  = new ModelDuck();            
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowerede());
            model.PerformFly();
           
        
        }
    }
}