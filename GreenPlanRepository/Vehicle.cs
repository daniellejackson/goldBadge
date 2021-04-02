using GreenPlanRepository.ENUMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenPlanRepository
{
    public enum VehicleType
    {
        Gas,
        Electric,
        Hybrid
    }
    public class Vehicle
    {
        public string VehicleName { get; set; }
        public int MPG { get; set; }
        public int Cost { get; set; }
        public int SafetyRating { get; set; }

        public bool HasTaxRebate { get; set; }

        public VehicleType VehicleType { get; set; }

        public Vehicle()
        {

        }

        public Vehicle(string vehicleName, int mpg, int cost, int safetyRating, bool hasTaxRebate, VehicleType vehicleType)
        {
            VehicleName = vehicleName;
            MPG = mpg;
            Cost = cost;
            SafetyRating = safetyRating;
            HasTaxRebate = hasTaxRebate;
            VehicleType = vehicleType;
        }


    }
}
