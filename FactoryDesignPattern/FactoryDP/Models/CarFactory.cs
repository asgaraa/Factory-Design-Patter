using FactoryDP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDP.Models
{
    public class CarFactory
    {
        public static ICar createCar(String mark, String color, double price, int modelYear, bool backupCamera)
        {

            ICar car;
            if (mark.Equals("BMW"))
            {
                car = new BMW(color, price, modelYear, backupCamera);
            }
            else if (mark.Equals("MercedesBenz"))
            {
                car = new MercedesBenz(color, price, modelYear, backupCamera);
            }
            else
            {
                throw new NotImplementedException(mark + " markasi hazirda istifadede deyil");
            }
            return car;
        }
    }
}
