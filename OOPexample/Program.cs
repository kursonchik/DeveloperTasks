using System;
using Task1.entity;
using Task1.service.impl;

internal class Program
{
    private void Run()
    {
        var vehicles = new List<Vehicle>();
        vehicles.Add(new Scooter("Scooter", "F", 100, 30));
        vehicles.Add(new Bicycle("Bicycle", "Bicycle-1234", 60, 10));
        vehicles.Add(new Car("Ford", "Fiesta", 180, 100));
        vehicles.Add(new Motorbike("Motorbike", "F1234", 100, 150));
        {
            Console.WriteLine("::::::::::::Task 2 – Reflection (Returns an instance of every class of type T)::::::::::::::::::::::::" + '\n' + ""); {
                Console.WriteLine(InstanceService.GetInstances<Scooter>());
            }
            Console.WriteLine('\n' + "::::::::Task 3 – Functionality :Before Sorting::::::::::::::::::::::::::::::::::::::::::::" + '\n' + "");

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.Name);
            }
            Console.WriteLine('\n' + "::::::::::::Task 3 – Functionality :After alphabetically sorting  ::::::::::::::::::::::::" + '\n' + "");

            var sort = new SortService();
            var sortedList = sort.SortByAlphabet(vehicles);
            foreach (var vehicle in sortedList)
            {
                Console.WriteLine(vehicle.Name);
            }
            Console.WriteLine('\n' + "::::::::::::Task 3 – Functionality :Get type by specifying part of the name::::::::::::::::" + '\n' + "");
            {
                Console.WriteLine(SortService.GetTypeByName("Mot"));
            }
            Console.WriteLine('\n' + "::::::Task 3 – write all instances returned from InstanceService.GetInstances() to disk:::" + '\n' + "");
            InstanceService.ExportToTextFile(vehicles, @"C:\Users\Public\Documents\AllInstanceTemp.txt", ';');
           
        }
        Console.WriteLine('\n' + "::::::Task 4 – Problem-solving :::::::::::::::::::::::::::::::::::::::::::::::" + '\n' + "");

        Console.WriteLine(StringService.ReverseString("Problem-solving"));
        Console.WriteLine('\n' + "Task 4.2 isPalindrome: " + StringService.IsPalindrome("Problem-solving")); // - false; "abba" - true
        Console.WriteLine('\n' + "Task 4.3 Missing Elements:" +'\n'+ "int[] arr:");

        int[] arr = { 1, 3, 4 };

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