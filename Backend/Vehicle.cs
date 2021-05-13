using System;
using System.Linq;
using ExtensionClasses;

namespace Backend
{
    public class Vehicle
    {
        public int Id { get; set; }
        private string licensePlate;
        public string LicensePlate
        {
            get
            {
                return licensePlate;
            }
            set
            {
                licensePlate = ValidateLicensePlate(value);
            }
        }
        private string ownerName;

        public string OwnerName
        {
            get
            {
                return ownerName;
            }
            set
            {
                ownerName = ValidateName(value, 1, 25);
            }
        }
        public string VehicleType { get; set; }
        public Vehicle(string licensePlate, string ownerName, string vehicleType)
        {
            LicensePlate = licensePlate;
            OwnerName = ownerName;
            VehicleType = vehicleType;
        }
        private static string ValidateLicensePlate(string licensePlate)
        {
            if(licensePlate.Trim().Any(c => !char.IsLetterOrDigit(c)))
            {
                throw new ApplicationException("License plate can only contain letter and digits");
            }
            if (licensePlate.Length > 3)
            {
                return licensePlate;
            }
            else
            {
                throw new ApplicationException("License plate is not within valid range(4-10).");
            }
        }
        private static string ValidateName(string name, int minLength, int maxLength)
        {
            if (name == null)
            {
                throw new ApplicationException("Owner name was null");
            }
            name = name.SuperTrim();
            if (name.Length < minLength || name.Length > maxLength)
            {
                throw new ApplicationException(
                    $"The length of the owner name was outside the valid range ({minLength}-{maxLength})");
            }
            // Temporary replaces all whitespaces in the middle of the name-string with the letter a
            string tempNameWithWhitespaceReplaced = name.Replace(' ', 'a');
            if (!tempNameWithWhitespaceReplaced.All(c => char.IsLetter(c)))
            {
                throw new ApplicationException("Owner Name contains invalid characters. Only letters and whitespaces allowed");
            }
            return name;
        }
    }
    
}