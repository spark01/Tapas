using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleAppPractice2
{
    public class Vehicle
    {
        public string VName { get; set; }
        public string RegNo { get; set; }
        List<double> Speeds = new List<double>();

        public void Set(string name, string reg)
        {
            VName = name;
            RegNo = reg;
        }

        public void SetSpeed(double spd)
        {
            Speeds.Add(spd);
            
        }

        public double GetMax()
        {
            if (Speeds.Count > 0)
            {
                return Speeds.Max();
            }

            return 0;

        }

        public double GetMin()
        {
            if (Speeds.Count > 0)
            {
                return Speeds.Min();
            }
            return 0;

        }

        public double GetAvg()
        {
            if (Speeds.Count > 0)
            {
                return Speeds.Average();
            }

            return 0;

        }

    }
}
