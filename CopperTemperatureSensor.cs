using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_15
{
    internal class CopperTemperatureSensor : ITemperatureSensor
    {
        public int GetTemperature()
        {
            Random random = new Random();
            return random.Next(15) + 1070;
        }
    }
}
