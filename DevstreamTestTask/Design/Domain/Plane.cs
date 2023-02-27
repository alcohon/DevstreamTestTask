using DevstreamTestTask.Design.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevstreamTestTask.Design.Domain
{
    //Additional Class to test GetInstances method in Instance Service
    public class Plane : Vehicle
    {
        private int speed;
        public override int Speed { get => speed; set => speed = value; }

        public Plane()
        {
            
        }

        public Plane(string manufacturer, decimal price, string vehicleName, int speed) : base(manufacturer, price, vehicleName)
        { 
            Speed = speed;
        }
    }
}
