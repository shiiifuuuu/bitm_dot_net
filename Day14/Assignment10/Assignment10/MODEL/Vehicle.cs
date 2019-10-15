using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10.MODEL
{
    public class Vehicle
    {
        public string Name { set; get; }
        public string RegNo { set; get; }
        public List<double> Speeds = new List<double>();

        public Vehicle()
        {

        }

        public Vehicle(string name, string regNo)
        {
            this.Name = name;
            this.RegNo = regNo;
        }

        public void SetSpeed(double speed)
        {
            Speeds.Add(speed);
        }

        public double MinSpeed()
        {
            return Speeds.Min();
        }
        public double MaxSpeed()
        {
            return Speeds.Max();
        }
        public double AvgSpeed()
        {
            return Speeds.Average();
        }
    }
}
