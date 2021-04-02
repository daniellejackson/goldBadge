using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenPlanRepository
{
    public class Repo
    {
        private readonly List<Vehicle> _vehicleDatabase = new List<Vehicle>();


        public bool AddVehicleToDatabase(Vehicle vehicle)
        {    
            _vehicleDatabase.Add(vehicle);
            return true;
        }

        public List<Vehicle> ShowAllVehicles()
        {
            return _vehicleDatabase;
        }

        public Vehicle GetVehicleByName(string VehicleName)
        {
            foreach (var vehicle in _vehicleDatabase)
            {
                if (vehicle.VehicleName == VehicleName)
                {
                    return vehicle;
                }
            }
            return null;
        }

        public bool UpdateVehicle(string oldVehicleInfo, Vehicle newVehicleInfo)
        {
            Vehicle oldVehicle = GetVehicleByName(oldVehicleInfo);
            if(oldVehicle == null)
            {
                return false;
            }
            else
            {
                oldVehicle.VehicleName = newVehicleInfo.VehicleName;
                oldVehicle.HasTaxRebate = newVehicleInfo.HasTaxRebate;
                oldVehicle.Cost = newVehicleInfo.Cost;
                oldVehicle.SafetyRating = newVehicleInfo.SafetyRating;
                return true;
            }
        }

        public bool DeleteVehicle(string vehicleName)
        {
            foreach (Vehicle item in _vehicleDatabase)
            {
                if (item.VehicleName == vehicleName)
                {
                    _vehicleDatabase.Remove(item);
                    return true;
                }

            }
            return false;
        }


    }

}
