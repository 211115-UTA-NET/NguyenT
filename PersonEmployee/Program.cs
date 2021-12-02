//Using statements 

using System;
using System.IO;
using System.Collections.Generic;

//Namespace
namespace SampleNamespace
{
//Class declaration
    class Program
    {
    //function declaration
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Default Person
            Person newGuy = new Person();
            newGuy.Introduce();

            // Person Tommy Nguyen
            Person someOtherPerson = new Person("Tommy", "Nguyen");
            someOtherPerson.Introduce();

            // Person Stefan
            Console.WriteLine($"\nName Change:\n{newGuy.getFirstName()}");
            newGuy.setFirstName("Stefan");
            Console.WriteLine(newGuy.getFirstName());
            newGuy.Introduce();

            // Employee Kyler
            Employee Kyler = new Employee(40, 18.50, "Kyler", "Dennis");
            Kyler.Introduce();
            Kyler.doWork();

            // Kyler pay raise
            Console.WriteLine($"\n{Kyler.getFirstName()} is willing to work longer for a pay raise!");

            Console.WriteLine($"Old work hours: {Kyler.HoursWorked}");
            Kyler.setHoursWorked(45);
            Console.WriteLine($"New work hours: {Kyler.HoursWorked}");

            Console.WriteLine($"Old salary: {Kyler.PayRate}/hour");
            Kyler.setPayRate(20.81);
            Console.WriteLine($"New salary: {Kyler.PayRate}/hour");
            Kyler.Introduce();
            Kyler.doWork();

            // Sponsor Richie
            Sponsor Richie = new Sponsor("Coca-Cola", "online commercial", true, "Richie", "Hawkman");
            Richie.Introduce();
            Richie.Sponsorship();

            // Trainee Joe
            Trainee Joe = new Trainee(true, "California", "66666666", 50, 23.13, "Joe", "Swan");
            Joe.Introduce();
            Joe.doWork();
            Joe.TraineeInfo();

        }
    }
}