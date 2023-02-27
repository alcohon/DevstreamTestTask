using DevstreamTestTask.Design.Abstract;
using DevstreamTestTask.Design.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevstreamTestTask.Design.Domain
{
    public class Motorbike : Vehicle
    {
        public const int DEFAULT_MIN_SPEED = 120;
        public const int DEFAULT_MAX_SPEED = 280;
        private int speed;

        public Motorbike() : base() 
        { 

        }

        public Motorbike(
            string manufacturer,
            string vehicleName,
            decimal price, int speed = 200) : base(manufacturer, price, vehicleName)
        {
            Speed = speed;
        }

        /// <summary>
        /// Min value = 120
        /// Max value = 280
        /// </summary>
        public override int Speed
        {
            get => speed;
            set
            {
                if (speed < DEFAULT_MIN_SPEED || speed > DEFAULT_MAX_SPEED)
                {
                    throw new VehicleException($"Motorbike speed should be between {DEFAULT_MIN_SPEED} and {DEFAULT_MAX_SPEED}", typeof(Bicycle));
                }
                speed = value;
            }
        }
    }
}
