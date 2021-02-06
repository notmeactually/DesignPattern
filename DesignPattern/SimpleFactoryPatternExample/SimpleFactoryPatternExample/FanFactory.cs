﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactoryPatternExample
{
    interface IFanFactory
    {
        IFan CreateFan(FanType type);
    }

    class FanFactory : IFanFactory
    {
        public IFan CreateFan(FanType type)
        {
            switch (type)
            {
                case FanType.TableFan:
                    return new TableFan();
                case FanType.CeilingFan:
                    return new CeilingFan();
                case FanType.ExhaustFan:
                    return new ExhaustFan();
                default:
                    return new TableFan();
            }
        }
    }
}
