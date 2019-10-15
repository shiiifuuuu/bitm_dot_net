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

        private int point;

        public Person()
        {
            this.point = 10;
        }
        //public void SetFirstName(string firstName)
        //{
        //    this.FirstName = firstName;
        //}
        //public string GetFirstName()
        //{
        //    return this.FirstName;
        //}

        //public string MiddleName
        //{
        //   private set { this.MiddleName = value; }
        //    get { return this.MiddleName; }
        //}

        //CONSTRUCTOR CHAINING
        public Person(string firstname,  string lastname):this()
        {
            FirstName = firstname;
           // MiddleName = middlename;
            LastName = lastname;
        }

        public Person(string firstname, string middlename, string lastname):this (firstname,lastname)
        {
         //   FirstName = firstname;
           this.MiddleName = middlename;
           // LastName = lastname;
        }

        public string GetFullName()
        {
            string fullName = this.FirstName + " " + this.MiddleName + " " + this.LastName;
            return fullName;
        }
    }
}
