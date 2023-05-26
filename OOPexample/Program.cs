using System;
using System.Reflection;
using Task1.entity;
using Task1.service.impl;

internal class Program
{
    private void Run()
    {
        Console.WriteLine("::::::::::::Task 1 – Design :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::" + '\n' + "");
        
        Car car = new();
        car.Representation();
   
        Scooter scooter = new();
        scooter.Representation();

        Bicycle bicycle = new();
        bicycle.Representation();

        Motorbike motorbike = new();
        motorbike.Representation();

        var vehicles = new List<Vehicle>();
        vehicles.Add(scooter);
        vehicles.Add(bicycle);
        vehicles.Add(car);
        vehicles.Add(motorbike);
        {
        Console.WriteLine('\n'+"::::::::::::Task 2 – Reflection (Returns an instance of every class of type T)::::::::::::::::::::::::" + '\n' + ""); {
                Console.WriteLine(InstanceService.GetInstances<Bicycle>());
        }

        Console.WriteLine('\n' + "::::::::Task 3 – Functionality :Before Sorting::::::::::::::::::::::::::::::::::::::::::::::::::::::" + '\n' + "");

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.Name);
            }

        Console.WriteLine('\n' + "::::::::::::Task 3 – Functionality :After alphabetically sorting  ::::::::::::::::::::::::::::::::::" + '\n' + "");

            var sort = new SortService();
            var sortedList = sort.SortByAlphabet(vehicles);
            foreach (var vehicle in sortedList)
            {
                Console.WriteLine(vehicle.Name);
            }

        Console.WriteLine('\n' + "::::::::::::Task 3 – Functionality :Get type by specifying part of the name::::::::::::::::::::::::::" + '\n' + "");
            {
            Console.WriteLine(InstanceService.GetTypeByName("bic"));
            }

         Console.WriteLine('\n' + "::::::Task 3 – write all instances returned from InstanceService.GetInstances() to disk:::::::::::::" + '\n' + "");
            InstanceService.ExportToTextFile<Bicycle>(@"C:\Users\Public\Documents\AllInstanceTemp.txt");
           
        }
        Console.WriteLine('\n' + "::::::Task 4 – Problem-solving ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::" + '\n' + "");

            Console.WriteLine(StringService.ReverseString("Problem-solving"));

            Console.WriteLine('\n' + "Task 4.2 isPalindrome: " + StringService.IsPalindrome("Problem-solving")); // - false; "abba" - true

            Console.WriteLine('\n' + "Task 4.3 Missing Elements:" +'\n'+ "int[] arr:");

            int[] arr = { 2,3,4 };

            foreach (var num in arr)
            {
            Console.Write("{0} ", num);
            }

            foreach (var number in arr.MissingElements())
            {
            Console.Write("{0} ", number);
            }
    }
   
    private static void Main(string[] args)
    {
        (new Program()).Run();
    } 
}