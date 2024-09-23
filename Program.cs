using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory5.TransportCreator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Хотите создать транспорт? 1 - машина, 2 - мотоцикл, 3 - самолет, 4 - велосипед.");
            int TypeVehicle = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Какая модель транспорта?");
            string ModelVehicle = Console.ReadLine();
            Console.WriteLine("Какая скорость транспорта?");
            double SpeedVehicle = Convert.ToDouble(Console.ReadLine());

            IVehicle MyVehicle;
            ITransportFactory TransportCreator;
            switch (TypeVehicle)
            {
                case 1:
                    TransportCreator = new CarFactory();
                    MyVehicle = TransportCreator.CreateTransport();
                    break;
                case 2:
                    TransportCreator = new MotorcycleFactory();
                    MyVehicle = TransportCreator.CreateTransport();
                    break;
                case 3:
                    TransportCreator = new PlaneFactory();
                    MyVehicle = TransportCreator.CreateTransport();
                    break;
                case 4:
                    TransportCreator = new BikeFactory();
                    MyVehicle = TransportCreator.CreateTransport();
                    break;
                default:
                    throw new Exception("Транспортного средства нет в каталоге.");
                    break;
            }

            MyVehicle.Move();
            MyVehicle.FuelUp();
            MyVehicle.Model = ModelVehicle;
            MyVehicle.Speed = SpeedVehicle;

            Console.WriteLine($"Модель: {MyVehicle.Model}\nСкорость:{MyVehicle.Speed}");
        }
    }
}
