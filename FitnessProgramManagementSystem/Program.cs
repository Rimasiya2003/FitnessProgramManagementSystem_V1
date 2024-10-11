using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FitnessProgramManager manager = new FitnessProgramManager();
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("\nFitnessProgram Management System:");
                Console.WriteLine("1. Add a FitnessProgram:");
                Console.WriteLine("2. View All FitnessProgram:");
                Console.WriteLine("3. Update a FitnessProgram:");
                Console.WriteLine("4. Delete a FitnessProgram:");
                Console.WriteLine("5. Exit:");
                Console.Write("Choose an option:");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Clear();
                        CreateFitnessProgram(manager);
                        break;

                    case "2":
                        Console.Clear();
                        manager.ReadFitnessPrograms();
                        break;

                    case "3":
                        Console.Clear();
                        UpdateFitnessProgram(manager);
                        break;

                    case "4":
                        Console.Clear();
                        DeleteFitnessProgram(manager);
                        break;

                    case "5":
                        Console.Clear();
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("please select program choice");
                        break;
                }
                if (!exit)
                {
                    Console.WriteLine("\n Press enter to continue.....");
                    Console.ReadLine();
                }
            }
        }
        static void CreateFitnessProgram(FitnessProgramManager manager)
        {
            Console.WriteLine("Enter FitnessProgram ID: ");
            string id = Console.ReadLine();
            Console.WriteLine("Enter FitnessProgram Title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter FitnessProgram Duration:  ");
            string duration = Console.ReadLine();
            Console.WriteLine("Enter FitnessProgram price:  ");
            string price = Console.ReadLine();
            Console.WriteLine("FitnessProgram added successfully.");
            Console.ReadLine();

            manager.CreateFitnessProgram(id, title, duration, price);

        }

        static void UpdateFitnessProgram(FitnessProgramManager manager)
        {
            Console.WriteLine("Enter FitnessProgram ID to Update: ");
            string id = Console.ReadLine();
            Console.WriteLine("Enter new Title:  ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter new Duration:   ");
            string duration = Console.ReadLine();
            Console.WriteLine("Enter new Price:");
            string price = Console.ReadLine();
            Console.WriteLine("FitnessProgram updated  successfully.");
            Console.ReadLine();

            manager.UpdateFitnessProgram(id, title, duration, price);

        }

        static void DeleteFitnessProgram(FitnessProgramManager manager)
        {
            Console.WriteLine("Enter FitnessProgram ID to Delete: ");
            string id = Console.ReadLine();
            Console.WriteLine("FitnessProgram Deleted  successfully.");
            Console.ReadLine();

            manager.DeleteFitnessProgram(id);

        }

       
    }
}
