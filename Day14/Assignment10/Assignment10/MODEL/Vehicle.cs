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
        public double Speed { set; get; }

        public Vehicle()
        {

        }

        public Vehicle(string name, string regNo)
        {
            this.Name = name;
            this.RegNo = regNo;
        }

    }
}
