using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Employee
    {
        public int Id {get; set;}
        public  string FName {get; set;} = String.Empty;
        public  string LName {get; set;} = String.Empty;
        public  int DoB {get; set;}
        public int Salary {get; set;}
    }
}