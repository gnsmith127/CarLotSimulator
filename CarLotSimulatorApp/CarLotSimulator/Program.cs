using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car - Done
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable - Done
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() - Done
            //The methods should take one string parameter: the respective noise property - Done


            //Now that the Car class is created we can instanciate 3 new cars - done
            //Set the properties for each of the cars - done
            //Call each of the methods for each car

            


            var car1 = new Car();
            car1.Year = 2020;
            car1.Make = "Mazda";
            car1.Model = "CX-5";
            car1.EngineNoise = "vroom";
            car1.HonkNoise = "beep";
            car1.IsDrivable = true;


            var car2 = new Car(1992, "Chevrolet", "Astro", "hiss", "bonk", false);


            var car3 = new Car()
            {
                Year = 2022,
                Make = "MINI",
                Model = "Cooper",
                EngineNoise = "*silence*",
                HonkNoise = "vreep",
                IsDrivable = true

            };


            


            car1.MakeEngineNoise(car1.EngineNoise);
            car2.MakeEngineNoise(car2.EngineNoise);
            car3.MakeEngineNoise(car3.EngineNoise);

            Console.WriteLine();

            car1.MakeHonkNoise(car1.HonkNoise);
            car2.MakeHonkNoise(car2.HonkNoise);
            car3.MakeHonkNoise(car3.HonkNoise);


            Console.WriteLine($"Number of cars created:{CarLot.numberOfCars}");
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
