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

        public List<int> ItemNo = new List<int>();
        public List<double> ItemWeight = new List<double>();
        public List<double> TotalWeight = new List<double>();

        double weight = 0;

        public Refrigerator(double maximumWeight)
        {
            this.MaximumWeight = maximumWeight;
        }

        public double CalculateWeight(int i)
        {
            TotalWeight.Add(this.ItemNo[i] * this.ItemWeight[i]);
            return TotalWeight[i];
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

        internal string ShowValue()
        {
            int totalItem = 0;
            double totalItemWeight = 0;
            double sum = 0;

            string message = "No Of Item, Weight / Unit, Total Weight\n";
            for(int i = 0; i < ItemNo.Count; i++)
            {
                message += ItemNo[i] + ", " + ItemWeight[i] + ", " + TotalWeight[i] + "\n";
            }

            for(int i=0; i < ItemNo.Count; i++)
            {
                totalItem += ItemNo[i];
                totalItemWeight += ItemWeight[i];
                sum += TotalWeight[i];
            }

            message += "----------------------------------\n" +
                "Total "+totalItem+", "+totalItemWeight+", "+sum+"/[Max Weight]";
            return message;
        }
    }
}
