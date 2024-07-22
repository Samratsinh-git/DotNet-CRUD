using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Employee
    {
        public int? Id {get;set;}
        public string Fname {get;set;} = String.Empty;
        public string Lname {get;set;} = String.Empty;
        public DateOnly? DOB {get;set;}
        public int? Salary {get;set;}
    }
}