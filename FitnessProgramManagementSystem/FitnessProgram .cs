using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class FitnessProgram
    {
        public int TotalFitnessPrograms {  get; set; }=0;
        public string fitnessProgramId { get; set; }
        public string title { get; set; }
        public string duration { get; set; }
        public string price { get; set; }

        public FitnessProgram(string fitnessProgramId, string title, string duration, string price)
        {
            this.TotalFitnessPrograms++;
            this.fitnessProgramId = fitnessProgramId;
            this.title = title;
            this.duration = duration;
            this.price = price;
        }

        public override string ToString()
        {
            return $"fitnessProgramId: {fitnessProgramId}, Title: {title}, Duration: {duration}, Price: {price}";
        }

       
    }
}
