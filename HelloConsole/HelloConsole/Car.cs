using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsole
{
    public class Car
    {
        public int Doors { get; set; }

        private int milege;

        public int Milege
        {
            get { return milege; }
            set { milege = value; }
        }

        int wheels;
        public Car(int wheels)
        {
            this.wheels = wheels;
        }

        // default constructor
        public Car()
        {

        }

        public override string ToString()
        {
            return string.Format("car: wheel {0} milege {1}", wheels, milege);
        }

        // Car a = new Car();
    }
}
