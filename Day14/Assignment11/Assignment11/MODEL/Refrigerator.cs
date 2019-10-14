using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11.MODEL
{
    public class Refrigerator
    {
        public double MaximumWeight { set; get; }

        public Refrigerator(double maximumWeight)
        {
            this.MaximumWeight = maximumWeight;
        }

        public Refrigerator()
        {
        }

        double currentWeight = 0;
        public double CurrentWeight(double weight)
        {
            currentWeight+= weight;
            return currentWeight;
        }

        public double RemainingWeight()
        {
            double remainingWeight = this.MaximumWeight - currentWeight;
            return remainingWeight;
        }
    }
}
