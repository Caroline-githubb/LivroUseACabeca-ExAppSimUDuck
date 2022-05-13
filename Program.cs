using System;
using SimUDuck.Classes;

namespace SimUDuck
{
    public class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.Display();
            mallard.PerformFly();
            mallard.PerformQuack();
           
        
        }
    }
}