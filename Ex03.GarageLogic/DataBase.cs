using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class DataBase
    {
        public static List<VehicleBase> vehicleList = new List<VehicleBase>();

        public void AddVehicleToList(VehicleBase i_VehicleToAdd)
        {
            vehicleList.Add(i_VehicleToAdd);
        }//maybe unnecessary

        public bool CheckIfVehicleIsInList(string i_VehicleRegistrationNumber)
        {
            bool result = false;

            foreach (VehicleBase vehicle in vehicleList)
            {
                if (vehicle.r_RegistrationNumber.Equals(i_VehicleRegistrationNumber))
                {
                    result = true;
                }
            }

            return result;
        }

        public static void ChangeOwnersVehicleStatus(string i_RegistrationNumber, ENumType.eVehicleStatus i_NewStatus)
        {
            bool vehicleIsFound = false;

            foreach (VehicleBase vehicle in vehicleList)
            {
                if (vehicle.r_RegistrationNumber == i_RegistrationNumber)
                {
                    vehicle.Status = i_NewStatus;
                    vehicleIsFound = true;
                }
            }

            if (!vehicleIsFound)
            {
                throw new System.Exception("Vehicle not found");
            }
        }

        public static void FillTires(string i_RegistrationNumber)
        {
            bool vehicleIsFound = false;

            foreach (VehicleBase vehicle in vehicleList)
            {
                if (vehicle.r_RegistrationNumber == i_RegistrationNumber)
                {
                    vehicle.FillAir(vehicle.MaxAirPressure - vehicle.AirPressure);
                    vehicleIsFound = true;
                }

                if (!vehicleIsFound)
                {
                    throw new System.Exception("Vehicle not found");
                }
            }
        }

        public static void ChargeVehicle(string i_RegistrationNumber, float i_ToAdd)
        {
            bool vehicleIsFound = false;

            foreach (VehicleBase vehicle in vehicleList)
            {
                if (vehicle.r_RegistrationNumber == i_RegistrationNumber)
                {
                    vehicle.FillEnergySource(i_ToAdd);
                    vehicleIsFound = true;
                }
            }

            if (!vehicleIsFound)
            {
                throw new System.Exception("Vehicle not found");
            }
        }

        public static void FuelVehicle(string i_RegistrationNumber, ENumType.eFuelType i_TypeOfFuel, float i_ToAdd)
        {
            bool vehicleIsFound = false;

            foreach (VehicleBase vehicle in vehicleList)
            {
                if(vehicle.r_RegistrationNumber == i_RegistrationNumber)
                {
                    vehicle.FillEnergySource(i_TypeOfFuel, i_ToAdd);
                    vehicleIsFound = true;
                }
            }
            if (!vehicleIsFound)
            {
                throw new System.Exception("Vehicle not found");
            }
        }

        public List<VehicleBase> ListOfVehicles
        {
            get { return vehicleList; }
        }
    }
}
