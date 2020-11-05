using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemsControls
{
   [Serializable]
    public class Worker
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public string Position { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string House { get; set; }
        public Worker()
        {
            FirstName = "";
            LastName = "";
            Salary = 0;
            Position = "";
            City = "";
            Address = "";
            House = "";
        }
        public Worker(string firstName,string lastName,decimal salary,string position,string city,string address, string house)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Position = position;
            City = city;
            Address = address;
            House = house;
        }
        public override string ToString()
        {
            return String.Format("{0,-15}\t{1,-18}\t{2,-25}",FirstName,LastName,City);
          
        }
    }
}
