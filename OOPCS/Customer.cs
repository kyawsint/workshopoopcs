using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPCS
{
    class Customer
    {
        private string name, address, nirc;
        private DateTime dob;

        public Customer(string n, string a, string nrc, DateTime d)
        {
            name = n;
            address = a;
            nirc = nrc;
            dob = d;
        }

        public string Name
        {
            get { return name; }
            set { value = name; }
        }

        public string Address
        {
            get { return address; }
        }

        public string NIRC
        {
            get { return nirc; }
        }

        public int Age()
        {
            //Console.WriteLine("Customer Name : {0} and Age : {1}.", name, Math.Round((DateTime.Today - dob).Days / 365.25m));
            return Convert.ToInt16(Math.Round((DateTime.Today - dob).Days / 365.25m));
        }
    }
}
