﻿using System;
using Lib;
using System.Collections.Generic;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateCat();
        }

        private static void AllMeals()
        {
            Pet pet = CreatePet();
            Meal meal1 = CreateMeal("Dry Food");
            Meal meal2 = CreateMeal("Wet Food");
            Meal meal3 = CreateMeal("Raw Food");
            Meal meal4 = CreateMeal("Human Food :(");

            List<Meal> meals = new List<Meal>() { meal1, meal2, meal3, meal4 };
            pet.Meals.AddRange(meals);

            foreach (Meal nom in pet.Meals)
            {
                Console.WriteLine(nom.ToString());
            }
        }
        static Meal CreateMeal(string name) {
            return new Meal(name);
        }
        static Pet CreatePet(){
            Pet pet1 = new Cat();
           // assign values to the variables
            Console.Write("\nPlease enter your Pet name: ");
            pet1.Name = Console.ReadLine();
            Console.Write("\nPlease enter your Pet date of birth (yyyy/mm/dd): ");
            pet1.Dob = Convert.ToDateTime(Console.ReadLine());

            do {
                Console.Write("\nPlease enter your Pet's Gender (press <1> for Female and press <0> for male): ");
                string gender = Console.ReadLine();
                if(gender == "0")
                    pet1.Gender = Gender.Male;
                else if(gender == "1") 
                    pet1.Gender = Gender.Female;
                else 
                    Console.Write("incorrect Gender (press <1> for Female and press <0> for male)");
            } while(pet1.Gender is null);

            // call the method
            string details=pet1.GetDetails();
            Console.WriteLine(pet1.GetDetails());
            return pet1;
        }
        static void CreateCat(){
            Cat pet1 = new Cat();
            Console.Write("\nPlease enter your Pet name: ");
            pet1.Name = Console.ReadLine();
            Console.Write("\nPlease enter your Pet date of birth (yyyy/mm/dd): ");
            pet1.Dob = Convert.ToDateTime(Console.ReadLine());

            do {
                Console.Write("\nPlease enter your Pet's Gender (press <1> for Female and press <0> for male): ");
                string gender = Console.ReadLine();
                if(gender == "0")
                    pet1.Gender = Gender.Male;
                else if(gender == "1") 
                    pet1.Gender = Gender.Female;
                else 
                    Console.Write("incorrect Gender (press <1> for Female and press <0> for male)");
            } while(pet1.Gender is null);
            Console.WriteLine(pet1.GetDetails());
        }
    }
}
