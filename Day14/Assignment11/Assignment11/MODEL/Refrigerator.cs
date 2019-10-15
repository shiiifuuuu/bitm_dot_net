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
        public int ItemNo { set; get; }
        public double ItemWeight { set; get; }

        double weight = 0;

        public Refrigerator(double maximumWeight)
        {
            this.MaximumWeight = maximumWeight;
        }

        public double CalculateWeight()
        {
            double totaltWeight = this.ItemNo * this.ItemWeight;
            return totaltWeight;
        }

        public double CurrentWeight(double itemWeight)
        {
            this.weight += itemWeight;
            this.MaximumWeight -= itemWeight;
            return weight;
        }

        public double RemainingWeight()
        {
            return this.MaximumWeight;
        }

        internal bool Validate(double totalWeight)
        {
            bool isValid = false;
            if(totalWeight <= this.MaximumWeight)
            {
                isValid = true;
            }
            return isValid;
        }
    }
}
