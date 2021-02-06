using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactoryPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IFanFactory simpleFactory = new FanFactory();

            // Creation of a Fan using Simple Factory 
            IFan fan = simpleFactory.CreateFan(FanType.TableFan);

            // Use created object 
            fan.SwitchOn();

            Console.ReadLine();
        }
    }
}
