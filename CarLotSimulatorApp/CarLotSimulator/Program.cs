using System;
using System.Security.AccessControl;

namespace CarLotSimulator
{

    class Program
    {
        public static void Main(string[] args)
        {
            CarLot carLot = new CarLot();

            // Create 3 new cars
            Car car1 = new Car
            {
                Year = 2020,
                Make = "Toyota",
                Model = "Camry",
                EngineNoise = "Broom!",
                HonkNoise = "Honk honk!",
                IsDriveable = true
            };

            Car car2 = new Car
            {
                Year = 2018,
                Make = "Honda",
                Model = "Civic",
                EngineNoise = "Vroom!",
                HonkNoise = "Beep beep!",
                IsDriveable = true
            };

            Car car3 = new Car
            {
                Year = 2023,
                Make = "Ford",
                Model = "Mustang",
                EngineNoise = "Roar!",
                HonkNoise = "Aooga!",
                IsDriveable = true
            };

            // Add cars to the CarLot
            carLot.AddCar(car1);
            carLot.AddCar(car2);
            carLot.AddCar(car3);

            // Make engine and honk noises for each car
            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);

            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);

            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);

            // Print car details from the CarLot
            Console.WriteLine("\nCar Details:");
            carLot.PrintCarDetails();
        }
    }
}

    //TODO

    //Create a seperate class file called Car
    //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
    //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
    //The methods should take one string parameter: the respective noise property


    //Now that the Car class is created we can instanciate 3 new cars
    //Set the properties for each of the cars
    //Call each of the methods for each car

    //*************BONUS*************//

    // Set the properties utilizing the 3 different ways we learned about, one way for each car

    //*************BONUS X 2*************//

    //Create a CarLot class
    //It should have at least one property: a List of cars
    //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
    //At the end iterate through the list printing each of car's Year, Make, and Model to the console

    

