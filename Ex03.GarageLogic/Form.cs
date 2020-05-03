using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Form
    {
            string m_ModelName, m_RegistrationNumber, m_WheelManufacturer, m_OwnerName,
                   m_OwnerPhoneNumber;
            float m_EnergyPercentageLeft, m_MaxEnergyCapacity, m_WheelCurrentAirPressure, m_WheelMaxAirPressure,
                  m_MaximumWeightAllow;
            bool m_IsCarryingDangerousSubstance;
            short m_NumberOfWheels;
            int m_EngineCapacity;
            ENumType.eEnergytype  m_EngineType;
            ENumType.eLicenseType m_MotorLicense;
            ENumType.eFuelType m_FuelType;
            ENumType.eVehicleStatus m_VehicleStatus = ENumType.eVehicleStatus.AtWork;
            ENumType.eVehicleList m_VehicleType;
            ENumType.eCarColor m_CarColor;
            ENumType.eCarDoorsNumber m_CarDoorsNumber;

        public string ModelName {
            set { m_ModelName = value; }
            get { return m_ModelName; }
        }

        public string RegistrationNumber {
            set { m_RegistrationNumber = value; }
            get { return m_RegistrationNumber; }
        }

        public string WheelManufacturer {
            set { m_WheelManufacturer = value; }
            get { return m_WheelManufacturer; }
        }

        public ENumType.eVehicleList VehicleType {
            set { m_VehicleType = value; }
            get { return m_VehicleType; }
        }

        public ENumType.eEnergytype EngineType {
            set { m_EngineType = value; }
            get { return m_EngineType; }
        }

        public string OwnerName {
            set { m_OwnerName = value; }
            get { return m_OwnerName; }
        }

        public string OwnerPhoneNumber {
            set { m_OwnerPhoneNumber = value; }
            get { return m_OwnerPhoneNumber; }
        }

        public ENumType.eFuelType FuelType {
            set { m_FuelType = value; }
            get { return m_FuelType; }
        }

        public float EnergyPercentageLeft {
            set { m_EnergyPercentageLeft = value; }
            get { return m_EnergyPercentageLeft; }
        }

        public float MaxEnergyCapacity {
            set { m_MaxEnergyCapacity = value; }
            get { return m_MaxEnergyCapacity; }
        }

        public float WheelCurrentAirPressure {
            set { m_WheelCurrentAirPressure = value; }
            get { return m_WheelCurrentAirPressure; }
        }

        public float WheelMaxAirPressure {
            set { m_WheelMaxAirPressure = value; }
            get { return m_WheelMaxAirPressure; }
        }

        public short NumberOfWheels {
            set { m_NumberOfWheels = value; }
            get { return m_NumberOfWheels; }
        }

        public ENumType.eVehicleStatus CarStatus
        {
            get { return m_VehicleStatus; }
        }
        public int EngineCapacity
        {
            set { m_EngineCapacity = value; }
            get { return m_EngineCapacity; }
        }

        public ENumType.eLicenseType MotorLicense
        {
            set { m_MotorLicense = value; }
            get { return m_MotorLicense; }
        }

        public ENumType.eCarColor CarColor
        {
            set { m_CarColor = value; }
            get { return m_CarColor; }
        }

        public ENumType.eCarDoorsNumber CarDoorsNumber
        {
            set { m_CarDoorsNumber = value; }
            get { return m_CarDoorsNumber; }
        }
        public float MaximumWeightAllow
        {
            set { m_MaximumWeightAllow = value; }
            get { return m_MaximumWeightAllow; }
        }

        public bool IsCarryingDangerousSubstance
        {
            set { m_IsCarryingDangerousSubstance = value; }
            get { return m_IsCarryingDangerousSubstance; }
        }
    }
}
