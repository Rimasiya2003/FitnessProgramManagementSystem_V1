using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class IndividualFitnessProgram : FitnessProgram
    {
        public string SubscriptionType {  get; set; }
        public bool needPersonalTrainer {  get; set; }

        public IndividualFitnessProgram(string id, string title, string duration, string price, string SubscriptionType, bool needPersonalTrainer)
           : base(id, title, duration, price)
        {
            SubscriptionType = SubscriptionType;
            this.needPersonalTrainer = needPersonalTrainer;
        }

        public string IndividualFitnessProgramInfo()
        {
           this.needPersonalTrainer = needPersonalTrainer ? true : false;
            return $"SubscriptionType:{SubscriptionType},needPersonalTrainer:{needPersonalTrainer}";
        }
    }
}
