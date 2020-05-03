using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public static class ENumType
    {
        public enum eEnergytype
        {
            Gasoline = 1,
            Elecrtic
        }

        public enum eVehicleList
        {
            Car = 1,
            Motorcycle,
            Truck
        }

        public enum eCarDoorsNumber
        {
            Two = 2,
            Three,
            Four,
            Five
        }

        public enum eCarColor
        {
            Yellow = 1,
            White,
            Black,
            Blue
        }

        public enum eFuelType
        {
            Octan95 = 1,
            Octan96,
            Octan98,
            Soler
        }

        public enum eMenuChoises
        {
            InsertVehicle = 1,
            ViewRegistrationNumbers,
            ChangeVehicleStatus,
            AddAirToTires,
            FuelVehicle,
            ChargeVehicle,
            ViewFullDetails,
            Exit
        }

        public enum eLicenseType
        {
            A = 1,
            AB,
            A2,
            B1
        }

        public enum eVehicleStatus
        {
            AtWork = 1,
            Fixed,
            Paid
        }

        public enum eVehicleRegistrationNumberListWithFilterring
        {
            ShowAll = 1,
            AtWork,
            Fixed,
            Paid
        }
    }
}
