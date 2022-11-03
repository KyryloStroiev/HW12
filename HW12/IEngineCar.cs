using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    interface IEngineCar
    {
        public string FuelType {get;set;}   
        public double EngineCapacity {get;set;}
        public int Power { get;set;}
    }
}
