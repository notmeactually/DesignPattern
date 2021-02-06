using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IElectricalFactory electricalFactory = new IndianElectricalFactory();
            //IElectricalFactory electricalFactory = new USElectricalFactory();
            IFan fan = electricalFactory.GetFan();
            fan.SwithOn();

            Console.ReadKey();
        }
    }

}
