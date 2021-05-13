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
            using (var dbContext = new PragParkContext())
            {
                dbContext.Vehicles.Add(new Vehicle(licensePlate, ownerName, vehicleType));
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
        public static Vehicle SearchVehicle_LicensePlate(string licensePlate)
        {
            using (var dbContext = new PragParkContext())
            {
                try
                {
                    Vehicle vehicle = dbContext.Vehicles.First(v => v.LicensePlate == licensePlate);
                    return vehicle;
                }
                catch
                {
                    throw new ApplicationException($"Couldnt find a vehicle with license plate {licensePlate}");
                }
            }
        }
        public static List<Vehicle> SearchVehicles_OwnerName(string owner)
        {
            using (var dbContext = new PragParkContext())
            {
                var vehicleList = new List<Vehicle>();
                try
                {
                    vehicleList = dbContext.Vehicles.Where(v => v.OwnerName == owner).ToList();
                }
                catch
                {
                    throw new ApplicationException($"Couldnt find any vehicles owned by {owner}");
                }
                if (vehicleList.Count < 1)
                {
                    throw new ApplicationException($"Couldnt find any vehicles owned by {owner}");
                }
                return vehicleList;
            }
        }

    }
}