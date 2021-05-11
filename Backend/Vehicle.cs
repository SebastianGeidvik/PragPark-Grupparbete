using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string LicensePlate { get; set; }
        public string OwnerName { get; set; }
        public string VehicleType { get; set; }
        public Vehicle(string licensePlate, string ownerName, string vehicleType)
        {
            LicensePlate = licensePlate;
            OwnerName = ownerName;
            VehicleType = vehicleType;
        }
    }
}