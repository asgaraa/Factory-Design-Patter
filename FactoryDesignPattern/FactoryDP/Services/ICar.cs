using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDP.Services
{
    public interface ICar
    {
        string getColor();
        double getPrice();
        int modelYear();
        bool backupCamera();
        void showCarInfo();
    }
}
