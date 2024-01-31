using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jan31.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation {  get; set; }    
        public int Salary { get; set; } 
        public DateTime DOJ {  get; set; }  
        
    }
}