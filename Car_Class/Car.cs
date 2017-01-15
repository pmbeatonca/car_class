using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Class
{
    class Car
    {
        //public Properties
        public int Year { get; set; }
        public string Make { get; set; }
        public int Speed { get; set; }

        //constructor method with two arguments or parameters

        public Car(int year,string make)
        {
            Year = year;
            Make = make;
            Speed = 0;
        }
        public void Accelerate()
        {
            Speed += 5; //or Speed=Speed+5
        }
        public void Break()
        {
            Speed -= 5;
        }

    }
               
}
