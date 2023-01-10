using FactoryDP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDP.Models
{
    public class BMW : ICar
    {
        private string _color;
        private double _price;
        private int _modelYear;
        private bool _backupCamera;
        public BMW(string color, double price, int modelYear, bool backupcamera)
        {
            _color = color;
            _price = price;
            _modelYear = modelYear;
            _backupCamera = backupcamera;

        }
        public bool backupCamera()
        {
            return _backupCamera;
        }

        public string getColor()
        {
            return _color;
        }

        public double getPrice()
        {
            return _price;
        }

        public int modelYear()
        {
            return _modelYear;
        }

        public void showCarInfo()
        {
            Console.WriteLine("Maşinin Markasi: BMW");
            Console.WriteLine("Maşinin Qiymeti: " + _price);
            Console.WriteLine("Maşinin Rengi: " + _color);
            Console.WriteLine("Maşinin İli: " + _modelYear);

            if (_backupCamera)
            {
                Console.WriteLine("Arxa Kamera Özelliyi : Var");
            }
            else
            {
                Console.WriteLine("Arxa Kamera Özelliyi : Yox");
            }
        }
    }
}
