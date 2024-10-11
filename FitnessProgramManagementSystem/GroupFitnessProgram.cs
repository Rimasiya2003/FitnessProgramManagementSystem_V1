using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.PeerToPeer.Collaboration;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class GroupFitnessProgram : FitnessProgram
    {
        public string Schedule {  get; set; }
        public int GroupCapacity {  get; set; }

        public GroupFitnessProgram (string id,string title, string duration, string price, string schedule, int groupCapacity)
            :base (id, title, duration, price)
        {
            Schedule = schedule;
           this. GroupCapacity = groupCapacity;
        }

        public string DisplayGroupFitnessProgramInfo()
        {
            return $"Schedule:{Schedule},GroupCapacity:{GroupCapacity}";
        }

        
    }

}
