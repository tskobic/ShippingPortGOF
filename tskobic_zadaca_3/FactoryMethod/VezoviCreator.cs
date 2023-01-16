﻿using tskobic_zadaca_3.Citaci;

namespace tskobic_zadaca_3.FactoryMethod
{
    public class VezoviCreator : Creator
    {
        public override ICitac FactoryMethod()
        {
            return new CitacVezova();
        }
    }
}