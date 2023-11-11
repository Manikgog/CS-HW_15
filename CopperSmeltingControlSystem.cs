using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CS_HW_15
{
    internal class CopperSmeltingControlSystem
    {
        public event Action<int> TemperatureExceededThreshold;

        public bool IsRunning;
        private CopperFurnace copperFurnace;
        public void Start()
        {
            IsRunning = true;
            this.copperFurnace = new CopperFurnace();
            copperFurnace.MeltCopper();
            ITemperatureSensor temperatureSensor = new CopperTemperatureSensor();
            for(int i = 1; i <= 10; i++)
            {
                copperFurnace.Temperature = i * 100;
                Console.WriteLine("Текущая температура в печи -> " + copperFurnace.Temperature + " C.");
                Thread.Sleep(1000);
            }
            while (true)
            {
                
                int currentTempreture = temperatureSensor.GetTemperature();
                copperFurnace.Temperature = currentTempreture;
                if (currentTempreture > 1083)
                {
                    TemperatureExceededThreshold?.Invoke(GetTempreture());
                    Stop(); 
                    break;
                }
                Console.WriteLine("Текущая температура в печи -> " + 1083 + "C.");
                Thread.Sleep(1000);
            }
        }

        public int GetTempreture()
        {
            return copperFurnace.Temperature;
        }

        

        public void Stop()
        {
            IsRunning = false;
            
        }

    }
}
