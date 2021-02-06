using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPatternExample
{
    interface IFan 
    {
        void SwithOn();
    }

    interface ITubelight { }

    class IndianFan : IFan
    {
        public void SwithOn()
        {
            Console.WriteLine("Indian Fan is running !");
        }
    }

    class IndianTubelight : ITubelight { }

    class USFan : IFan
    {
        public void SwithOn()
        {
            Console.WriteLine("US Fan is running !");
        }
    }   
    class USTubelight : ITubelight { }
}
