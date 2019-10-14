using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleAppPractice2
{
    public class Vehicle
    {     
       public string Name { get; set; }
       public string RegNo { get; set; }
       public List<Double> Speed=new List<double>();
       public Vehicle(string Name,string RegNo)
       {
           this.Name = Name;
           this.RegNo = RegNo;
       }
    }
}
