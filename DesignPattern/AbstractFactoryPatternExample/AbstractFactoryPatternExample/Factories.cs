using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPatternExample
{
    interface IElectricalFactory
    {
        IFan GetFan();
        ITubelight GetTubeLight();
    }

    class IndianElectricalFactory : IElectricalFactory
    {
        public IFan GetFan()
        {
            return new IndianFan();
        }

        public ITubelight GetTubeLight()
        {
            return new IndianTubelight();
        }
    }

    class USElectricalFactory : IElectricalFactory
    {
        public IFan GetFan()
        {
            return new USFan();
        }

        public ITubelight GetTubeLight()
        {
            throw new NotImplementedException();
        }
    }
}
