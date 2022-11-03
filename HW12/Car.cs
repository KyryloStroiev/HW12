using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    public class Car : Transport
    {
        public string BrandCar { get; set; }
        public string ModelCar { get; set; }
        public string ColorCar { get; set; }
        public int YearMade { get; set; }
        public Car (string brandCar, string modelCar, string colorCar, int yearMade)
        {
            BrandCar = brandCar;
            ModelCar = modelCar;
            ColorCar = colorCar;
            YearMade = yearMade;
        }
    }
}
