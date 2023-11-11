using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_15
{
    internal class CopperFurnace
    {
        public int Temperature { get; set; }
        public CopperSmeltingControlSystem MeltCopper()
        {
            Temperature = 1083;
            CopperSmeltingControlSystem copperSmeltingControlSystem = new CopperSmeltingControlSystem();
            return copperSmeltingControlSystem;
        }
    }
}
