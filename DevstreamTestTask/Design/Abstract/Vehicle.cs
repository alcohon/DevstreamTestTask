using DevstreamTestTask.Design.Domain;
using DevstreamTestTask.Design.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevstreamTestTask.Design.Abstract
{
    public abstract class Vehicle
    {
        private string manufacturer;
        private string vehicleName;
        private decimal price;

        public abstract int Speed { get; set; }

        public string Manufacturer
        {
            get => manufacturer;
            set
            {
                ThrowStringPropertyError(value, Manufacturer);
                manufacturer = value;
            }
        }

        protected Vehicle()
        {

        }

        protected Vehicle(string manufacturer, decimal price, string vehicleName)
        {
            Manufacturer = manufacturer;
            Price = price;
            VehicleName = vehicleName;
        }

        public string VehicleName
        {
            get => vehicleName;
            set
            {
                ThrowStringPropertyError (value, VehicleName);
                vehicleName = value;
            }
        }

        public decimal Price
        {
            get => price;
            set => price = value;
        }

        /// <summary>
        /// Default error message for null, empty or whitespace string property value.
        /// Doesn't throw any error if it is validated corretly.
        /// </summary>
        /// <returns>{propertyName} cannot be null, empty or whitespace</returns>
        protected void ThrowStringPropertyError(string value, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new VehicleException($"{propertyName} cannot be null, empty or whitespace", GetType());
            }
        }
    }
}
