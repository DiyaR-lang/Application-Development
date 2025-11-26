// ﻿using System;
// using System.Collections.Generic;

// namespace ConsoleTasks
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Task1();
//             Task2();
//             Task3();
//             Task4();
//             Task5();
//             Task6();
//         }

//         static void Task1()
//         {
//             string userName = "Diya Rai";
//             int luckyNumber = 8;
//             Console.WriteLine($"My name is: {userName}");
//             Console.WriteLine($"My lucky number is: {luckyNumber}");
//             Console.WriteLine($"Hello {userName}! your lucky number is {luckyNumber}");
//             Console.WriteLine();
//         }

//         static void Task2()
//         {
//             const double PI = 3.14;
//             Console.WriteLine($"Constant value of PI: {PI}");
//             Console.WriteLine();
//         }

//         static void Task3()
//         {
//             byte byteValue = 10;
//             short shortValue = 200;
//             int intValue = 1000;
//             long longValue = 50000L;
//             float floatValue = 3.14f;
//             double doubleValue = 6.28;
//             decimal decimalValue = 9.99m;
//             char charValue = 'A';
//             bool boolValue = true;

//             string intToString = intValue.ToString();
//             string numberString = "3.14";
//             double stringToDouble = Convert.ToDouble(numberString);

//             Console.WriteLine($"byte: {byteValue}");
//             Console.WriteLine($"short: {shortValue}");
//             Console.WriteLine($"int: {intValue}");
//             Console.WriteLine($"long: {longValue}");
//             Console.WriteLine($"float: {floatValue}");
//             Console.WriteLine($"double: {doubleValue}");
//             Console.WriteLine($"decimal: {decimalValue}");
//             Console.WriteLine($"char: {charValue}");
//             Console.WriteLine($"bool: {boolValue}");
//             Console.WriteLine($"Converted int to string: {intToString}");
//             Console.WriteLine($"Converted string to double: {stringToDouble}");
//             Console.WriteLine();
//         }

//         static void Task4()
//         {
//             int[] favoriteNumbers = { 7, 3, 9, 1, 5 };
//             Array.Sort(favoriteNumbers);

//             Console.WriteLine("Array after sorting (ascending):");
//             for (int i = 0; i < favoriteNumbers.Length; i++)
//                 Console.Write(favoriteNumbers[i] + " ");

//             Console.WriteLine("\n");

//             Array.Reverse(favoriteNumbers);
//             Console.WriteLine("Array after reversing (descending):");
//             for (int i = 0; i < favoriteNumbers.Length; i++)
//                 Console.Write(favoriteNumbers[i] + " ");

//             Console.WriteLine("\n");

//             int specificNumber = 5;
//             int position = Array.IndexOf(favoriteNumbers, specificNumber);

//             if (position != -1)
//                 Console.WriteLine($"The number {specificNumber} is found at index position: {position}");
//             else
//                 Console.WriteLine($"The number {specificNumber} is not found in the array.");

//             Console.WriteLine();
//         }

//         static void Task5()
//         {
//             DateTime birthDate = new DateTime(2004, 6, 15);
//             DateTime currentDate = DateTime.Now;
//             TimeSpan ageSpan = currentDate - birthDate;
//             int ageInYears = (int)(ageSpan.TotalDays / 365.25);

//             Console.WriteLine($"Birthdate: {birthDate.ToShortDateString()}");
//             Console.WriteLine($"Current Date: {currentDate.ToShortDateString()}");
//             Console.WriteLine($"Age: {ageInYears} years");

//             DateTime newDate = birthDate.AddDays(10);
//             Console.WriteLine($"Date after adding 10 days: {newDate.ToShortDateString()}");
//             Console.WriteLine();
//         }

//         static void Task6()
//         {
//             List<string> fruits = new List<string> { "Mango", "Apple", "Banana" };
//             fruits.Add("Orange");
//             fruits.Remove("Apple");

//             Console.WriteLine("List of Fruits:");
//             foreach (string fruit in fruits)
//                 Console.WriteLine($"- {fruit}");

//             Console.WriteLine();

//             Dictionary<int, string> fruitDictionary = new Dictionary<int, string>()
//             {
//                 { 1, "Mango" },
//                 { 2, "Banana" },
//                 { 3, "Orange" }
//             };

//             fruitDictionary.Add(4, "Pineapple");

//             Console.WriteLine("Fruit Dictionary:");
//             foreach (KeyValuePair<int, string> kvp in fruitDictionary)
//                 Console.WriteLine($"ID: {kvp.Key}, Fruit: {kvp.Value}");

//             Console.WriteLine();
//         }
//     }
// }
// using System;

// namespace ConsoleApp1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //Task1
//             Operators op = new Operators();

//             // Calling methods
//             op.Add(11, 5);
//             op.Subtract(13, 5);
//             op.Multiply(12, 5);
//             op.Divide(10, 5);

//             // Calling OddEvenFinder
//             op.OddEvenFinder(7);
//             op.OddEvenFinder(10);

//             //Task 2
//             NullOperations nullOps = new NullOperations();

//             nullOps.PerformNullChecks();

//             Console.ReadLine();
//         }
//     }
// }

class Program
{
    static void Main(string[] args)
    {
        //Task 1
        // Create bank account object
        BankAccount Account = new BankAccount("NKN390828J", 500);

        Console.WriteLine($"Account Number: {Account.AccountNumber}");
        Console.WriteLine($"Initial Balance: {Account.Balance}");

        // Deposit money
        Account.Deposit(300);
        Console.WriteLine($"Balance after deposit: {Account.Balance}");

        // Withdraw money
        Account.Withdraw(200);
        Console.WriteLine($"Balance after withdrawal: {Account.Balance}");

        //-------------------
        //Task 2
        
        // Creating Car object
        Car car = new Car()
        {
            Brand = "Yamaha"
            Speed = 100,
            Type = "Sports"
            
        };

        // Creating Motorcycle object
        Motorcycle Motorbike = new Motorcycle()
        {
            Brand = "Toyota"
            Speed = 350,
            Seats = 4
        };

        // Calling base class methods (reusability)
        car.Start();
        car.DisplayInfo();
        car.Stop();

        Console.WriteLine();

        Motorbike.Start();
        Motorbike.DisplayInfo();
        Motorbike.Stop();

        //Task 3
        Printer Printer = new Printer();

        Printer.Print("Hello World");     
        Printer.Print(909);                
        Printer.Print("Repeat Me", 7); 

        //Task 3

        NepaliTeacher NepaliTeach = new NepaliTeacher();
        NepaliTeach.Name = "Mrs. Diya";
        Console.WriteLine(NepaliTeach.Name);
        NepaliTeach.Teaching();
        NepaliTeach.SalaryInfo();

        Console.WriteLine();

        EnglishTeacher EnglishTeach = new EnglishTeacher();
        EnglishTeach.Name = "Ms. Monika";
        Console.WriteLine(EnglishTeach.Name);
        EnglishTeach.Teaching();
        EnglishTeach.SalaryInfo();


        Cars carr = new Cars();
        Bikes bike = new Bikes();

        Console.WriteLine("Car:");
        carr.Display();
        carr.StartEngine();
        carr.StopEngine();

        Console.WriteLine();

        Console.WriteLine("Bike:");
        bike.Display();
        bike.StartEngine();
        bike.StopEngine();

        // Task 5 OOP Derived Classes

        Laptop Laptop = new Laptop("Acer", 85000);
        Smartphone phone = new Smartphone("Apple", 50000);

        Console.WriteLine("Laptop:");
        Laptop.ShowInfo();
        Laptop.TurnOnBattery();

        Console.WriteLine();

        Console.WriteLine("Smartphone:");
        phone.ShowInfo();
        phone.EnableCamera();

        //Task 5 OOP
        ElectronicsStore_list Store_list = new ElectronicsStore_list();

        Laptop laptop = new Laptop("Acer", 85000);
        Smartphone phones = new Smartphone("Apple", 50000);

        // Add devices
        Store_list.AddDevice(laptop);
        Store_list.AddDevice(phones);

        Console.WriteLine();

        // Display all devices and call child-specific methods
        Store_list.ShowAllDeviceDetails();

        // Remove a device
        Store_list.RemoveDevice(Laptop);

        Console.WriteLine();
        Store_list.ShowAllDeviceDetails();

    
        // 2. Create Laptop and Smartphone objects
        Laptop laptoplist = new Laptop("Acer", 85000);
        Smartphone phoneList = new Smartphone("Apple", 50000);

        // 3. Add devices to the Store_list
        Store_list.AddDevice(laptoplist);
        Store_list.AddDevice(phoneList);

        Console.WriteLine();

        // 4. Display all device details including child-specific behavior
        Store_list.ShowAllDeviceDetails();
    }
}