using MotoBuilder.ExMoto;
using MotoBuilder.Quizz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //var vehicleCreator = new VehicleCreator(new HeroBuilder());
            //vehicleCreator.CreateVehicle();
            //var vehicle = vehicleCreator.GetVehicle();
            //vehicle.ShowInfo();

            //Console.WriteLine("---------------------------------------------");

            //vehicleCreator = new VehicleCreator(new HondaBuilder());
            //vehicleCreator.CreateVehicle();
            //vehicle = vehicleCreator.GetVehicle();
            //vehicle.ShowInfo();

            Process process = new Process();
            var response = process.initResponseRequest();
            var quizzCreator = new QuizzCreator(new QuizzBuilder());
            quizzCreator.CreateQuizz(response);
            var quizz = quizzCreator.GetQuizz();
            quizz.ShowInfo();





            Console.ReadKey();
        }
    }
}
