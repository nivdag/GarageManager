using System;
/// <summary>
/// A factory class
/// </summary>
namespace Ex03.GarageLogic
{
    public static class VehicleFactory

    {
        public static void CreateVehicle(ENumType.eVehicleList i_VehicleType, Form i_FilledForm)
        {
            if(!checkIfGarageCanHandleVehicle(i_VehicleType, i_FilledForm))
            {
                throw new SystemException("The garage can't handle these properties");
            }
            switch (i_VehicleType)
            {
                case ENumType.eVehicleList.Motorcycle:
                    {
                        DataBase.vehicleList.Add(new Motorcycle(i_FilledForm.EngineCapacity, i_FilledForm.MotorLicense, i_FilledForm));
                        break;
                    }
                case ENumType.eVehicleList.Car:
                    {
                        DataBase.vehicleList.Add(new Car(i_FilledForm.CarColor, i_FilledForm.CarDoorsNumber, i_FilledForm));
                        break;
                    }
                case ENumType.eVehicleList.Truck:
                    {
                        DataBase.vehicleList.Add(new Truck(i_FilledForm.IsCarryingDangerousSubstance, i_FilledForm.MaximumWeightAllow, i_FilledForm));
                        break;
                    }
                default:
                    throw new Exception("Vehicle type not supported");
            }
        }
        
        public static bool checkIfGarageCanHandleVehicle(ENumType.eVehicleList i_VehicleType, Form i_FilledForm)
        {
            bool canHandle = true;
            switch (i_VehicleType)
            {
                case ENumType.eVehicleList.Motorcycle:
                    if(i_FilledForm.NumberOfWheels == 2 || i_FilledForm.WheelMaxAirPressure == 33)
                    {
                        if (i_FilledForm.EngineType == ENumType.eEnergytype.Elecrtic)
                        {
                            if (i_FilledForm.MaxEnergyCapacity != 2.7f)
                            {
                                canHandle = false;
                            }
                        }
                        else
                        {
                            if(i_FilledForm.FuelType != ENumType.eFuelType.Octan95 ||
                                i_FilledForm.MaxEnergyCapacity != 5.5f)
                            {
                                canHandle = false;
                            }
                        }
                    }
                    else
                    {
                        canHandle = false;
                    }
                    break;
                case ENumType.eVehicleList.Car:
                    if(i_FilledForm.NumberOfWheels == 4 || i_FilledForm.WheelMaxAirPressure == 30)
                    {
                        if(i_FilledForm.EngineType == ENumType.eEnergytype.Elecrtic)
                        {
                            if(i_FilledForm.MaxEnergyCapacity != 2.5f)
                            {
                                canHandle = false;
                            }                         
                        }
                        else
                        {
                            if (i_FilledForm.FuelType != ENumType.eFuelType.Octan98 ||
                                i_FilledForm.MaxEnergyCapacity != 42)
                            {
                                canHandle = false;
                            }
                        }
                    }
                    else
                    {
                        canHandle = false;
                    }
                    break;
                case ENumType.eVehicleList.Truck:
                    if(i_FilledForm.NumberOfWheels != 12 || i_FilledForm.WheelMaxAirPressure > 32
                        || i_FilledForm.FuelType != ENumType.eFuelType.Octan96 || i_FilledForm.MaxEnergyCapacity != 135)
                    {
                        canHandle = false;
                    }
                        break;
                default:
                    throw new Exception("Vehicle type not supported");
            }

            return canHandle;      
        }
    }
}