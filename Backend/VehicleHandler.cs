﻿using System;
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
    }
}