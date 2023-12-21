using System;
using System.Collections.Generic;
namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car DONE
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable DONE
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() DONE
            //The methods should take one string parameter: the respective noise property DONE
            var ParkingLot = new CarLot();

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            //Car 1
            var carOne = new Car();
            carOne.year = 2017;
            carOne.make = "Tesla";
            carOne.model = "Model S";
            carOne.EngineNoise = "SHHHHHHHHH";
            carOne.HonkNoise = "Beep beep";
            carOne.IsDrivable = true;
            carOne.MakeEngineNoise(carOne.EngineNoise);
            carOne.MakeHonkNoise(carOne.HonkNoise);
            ParkingLot.ParkingLot.Add(carOne);
            //Car 2
            var carTwo = new Car() { year = 2018, make = "Lambo", model = "Hurrican", EngineNoise = "VROOM VROOOM", HonkNoise = "Kank Kank", IsDrivable = true };
            carOne.MakeEngineNoise(carTwo.EngineNoise);
            carOne.MakeHonkNoise(carTwo.HonkNoise);
            ParkingLot.ParkingLot.Add(carTwo);
            //Car 3
            //*************BONUS*************// I'm not sure what the third way is. Is the third way just multi line of the second???
            var carThree = new Car() { year = 1999, make = "Ford", model = "Tarus", EngineNoise = "GRRRRRRRRRR GRRRRRRRRRR", HonkNoise = "WAAAAAAAAAAAH WAAAAAAAAAAH", IsDrivable = false };
            carOne.MakeEngineNoise(carThree.EngineNoise);
            carOne.MakeHonkNoise(carThree.HonkNoise);
            ParkingLot.ParkingLot.Add(carThree);

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            
            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars DONE
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list. DONE
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console DONE

            foreach(var car in ParkingLot.ParkingLot) Console.WriteLine($"The car's year is: {car.year}, the car's make is: {car.make}, the car's model is: {car.model}");
            Console.ReadLine();
        }
    }
}
