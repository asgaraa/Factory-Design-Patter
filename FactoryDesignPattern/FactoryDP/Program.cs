
using FactoryDP.Models;
using FactoryDP.Services;

ICar bmw = CarFactory.createCar("BMW", "Siyah", 240000, 2016, true);
bmw.showCarInfo();
Console.WriteLine("===================================================================================");
ICar audi = CarFactory.createCar("Audi", "Beyaz", 194000, 2018, false);
audi.showCarInfo();
Console.WriteLine("===================================================================================");