using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInformationAppWalkthrough2
{
    class Person
    {
        public string FirstName { set; get; }
        public string MiddleName { set; get; }
        public string LastName { set; get; }

        public string GetFullName()
        {
            string fullName = this.FirstName + " " + this.MiddleName + " " + this.LastName;
            return fullName;
        }
    }
}
