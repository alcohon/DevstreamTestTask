using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevstreamTestTask.Design.Exceptions
{
    public class VehicleException : Exception
    {
        public VehicleException(string message, Type vehicleType) { 
            Console.WriteLine($"Vehicle type \"{vehicleType.Name}\" thrown an exception\n{message}");
        }
    }
}
