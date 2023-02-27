using DevstreamTestTask.Design.Abstract;
using DevstreamTestTask.Design.Enums;
using DevstreamTestTask.Design.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevstreamTestTask.Design.Domain
{
    public class Bicycle : Vehicle
    {
        public const int DEFAULT_MIN_SPEED = 20;
        public const int DEFAULT_MAX_SPEED = 150;

        private int speed;

        public Bicycle() : base()
        {

        }

        public Bicycle(
            string manufacturer = "Basic Bicycle Manufacturer Name", 
            string vehicleName = "Basic Bicycle Name", 
            decimal price = 10.10m, 
            BicycleAcitvityType activityType = BicycleAcitvityType.Road, 
            int speed = 50): base(manufacturer, price, vehicleName)
        {
            Speed = speed;
            ActivityType = activityType;
        }


        /// <summary>
        /// Min value = 20
        /// Max value = 150
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
        public BicycleAcitvityType ActivityType { get; set; }
    }
}
