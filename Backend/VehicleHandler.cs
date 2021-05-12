using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public static class VehicleHandler
    {
        public static void AddVehicle(string licensePlate, string ownerName, string vehicleType)
        {
            var validLicensePlate = ValidateLicensePlate(licensePlate);
            using (var dbContext = new PragParkContext())
            {
                dbContext.Vehicles.Add(new Vehicle(validLicensePlate, ownerName, vehicleType));
                dbContext.SaveChanges();
            }
        }
        public static void RemoveVehicle(string licensePlate)
        {
            using (var dbContext = new PragParkContext())
            {

                var car = dbContext.Vehicles.First(v => v.LicensePlate == licensePlate);
                if (car != null)
                {
                    dbContext.Vehicles.Remove(car);
                    dbContext.SaveChanges();
                }
            }
        }
        //public static Vehicle SearchVehicle(string licensePlate)
        //{

        //}
        //public static List<Vehicle> SearchVehicle(string owner)
        //{

        //}
        public static string ValidateLicensePlate(string licensePlate)
        {

            if (licensePlate.Length > 3)
            {
                return licensePlate;
            }
            else
            {
                throw new ApplicationException("License plate is not within valid range(3-10).");
            }
        }
    }
}