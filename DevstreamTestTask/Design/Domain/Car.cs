using DevstreamTestTask.Design.Abstract;
using DevstreamTestTask.Design.Enums;
using DevstreamTestTask.Design.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevstreamTestTask.Design.Domain
{
    public class Car : Vehicle
    {
        public const int DEFAULT_MAX_SPEED = 300;
        public const int DEFAULT_MIN_SPEED = 180;
        private int speed;

        public Car() : base() { }

        public Car(
            string manufacturer = "Basic Car Manufacturer Name", 
            string vehicleName = "Basic Car Name", 
            decimal price = 10.10m, int speed = 220) : base(manufacturer, price, vehicleName)
        {
            Speed = speed;
        }

        /// <summary>
        /// Min value = 180
        /// Max value = 300
        /// </summary>
        public override int Speed
        {
            get => speed;
            set
            {
                if (!(value > DEFAULT_MIN_SPEED && value < DEFAULT_MAX_SPEED))
                {
                    throw new VehicleException($"Bicycle speed should be between {DEFAULT_MIN_SPEED} and {DEFAULT_MAX_SPEED}", typeof(Bicycle));
                }
                speed = value;
            }
        }

        public CarWheelDriveType CarWheelDriveType { get; set; } 
    }
}
