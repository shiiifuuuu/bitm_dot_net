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
        double Weight { set; get; }

        public Refrigerator(double maximumWeight)
        {
            this.MaximumWeight = maximumWeight;
        }

        public Refrigerator()
        {
        }

        public double CurrentWeight(double weight)
        {
            currentWeight += weight;
            MaximumWeight -= currentWeight;
            return currentWeight;
        }

        public double RemainingWeight(double weight)
        {
            double remainingWeight = MaximumWeight;
            return remainingWeight;
        }
    }
}
