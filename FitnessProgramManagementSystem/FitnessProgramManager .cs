using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class FitnessProgramManager
    {
        public List<FitnessProgram> FitnessPrograms=new List<FitnessProgram>();

        public void CreateFitnessProgram(string id, string title,string duration,string price)
        {
            FitnessProgram program = new FitnessProgram(id, title, duration, price);
            FitnessPrograms.Add(program);
            Console.WriteLine("program created successfully");
        }

        public void ReadFitnessPrograms()
        {
            if(FitnessPrograms.Count == 0)
            {
                Console.WriteLine("program not available");
            }
            else
            {
                Console.WriteLine("Program List:");
                foreach(var program in FitnessPrograms)
                {
                    Console.WriteLine(program.ToString());
                }

            }
        }

        public void UpdateFitnessProgram(string id, string title, string duration, string price)
        {
            var findedProgram = FitnessPrograms.Find(p => p.fitnessProgramId == id);
            {
                findedProgram.fitnessProgramId = id;
                findedProgram.title = title;
                findedProgram.duration = duration;
                findedProgram.price = price;
                Console.WriteLine("program update successfully");

            }

        }

        public void DeleteFitnessProgram(string id)
        {
            var findedProgram = FitnessPrograms.Find(p => p.fitnessProgramId == id);
            {
              
                findedProgram.fitnessProgramId = id;
                FitnessPrograms.Remove(findedProgram);
                Console.WriteLine("program update successfully");

            }
        }
        public void ValidateFitnessProgramPrice()
        {
            decimal price;
            while (true)
            {
                if (decimal.TryParse(Console.ReadLine(), out price) && price > 0) 
                {
                    Console.WriteLine("Invalid Price!! ");
                }
               else
                {
                    Console.WriteLine("please input tha value again");
                }
            }
           
        }
     
    }
}
