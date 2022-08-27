using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brock_CourseProject_Part2
{
    public class Benefits
    {
        //attributes
        private string healthinsurance;
        private double lifeinsurance;
        private int vacation;

        //constructors
        //public Benefits(string healthinsurance, double lifeinsurance, int vacation)
        //{
        //    healthinsurance = "unk0nown";
        //    lifeinsurance = 0.0;
        //    vacation = 0;
        //}
        public Benefits(string healthinsurance, double lifeinsurance, int vacacation)
        {
            this.Healthinsurance = healthinsurance;
            this.Lifeinsurance = lifeinsurance;
            this.Vacation = vacation;

        }

        //behavior
        public override string ToString()
        {
            return "Heathinsurance: " + healthinsurance +
                "Lifeinsurance: " + lifeinsurance +
                "VacationDays: " + vacation;
        }

        //properties (get/set methods)
        public string Healthinsurance
        {
            get 
            { 
                return healthinsurance; 
            }
            set
            {
                if (value.Length > 0)
                    healthinsurance = value;
                else
                    healthinsurance = "unknown";
            }
        }
        public double Lifeinsurance
        {
            get
            {
                return lifeinsurance;
            }
            set
            {
                if (value > 0.0 && value <= 10000000.0)
                    lifeinsurance = value;
                else
                    lifeinsurance = 0.0;
            }
        }
        public int Vacation
        {
            get
            {
                return vacation;
            }
            set
            {
                if (value > 0 && value <= 40)
                    vacation = value;
                else
                    vacation = 0;
            }
        }
    }
}
