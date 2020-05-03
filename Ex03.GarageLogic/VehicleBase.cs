using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class VehicleBase
    {
        protected readonly string r_ModelName;
        public readonly string r_RegistrationNumber;
        protected readonly float r_MaxEnergyCapacity;
        protected float m_EnergyPercentage;
        protected Wheel[] m_MyWheel;
        protected EnergyType m_MyEngine;
        protected Owner m_MyOwner;

        public VehicleBase(Form i_Form) {
            r_ModelName = i_Form.ModelName;
            r_RegistrationNumber = i_Form.RegistrationNumber;
            m_EnergyPercentage = i_Form.EnergyPercentageLeft;
            r_MaxEnergyCapacity = i_Form.MaxEnergyCapacity;
            m_MyWheel = new Wheel[i_Form.NumberOfWheels];
            m_MyOwner = new Owner(i_Form);
            for (int i = 0; i < i_Form.NumberOfWheels; i++)
            {
                m_MyWheel[i] = new Wheel(i_Form.WheelManufacturer, i_Form.WheelCurrentAirPressure, i_Form.WheelMaxAirPressure);
            }
            CheckAndCreateEngineType(i_Form.EngineType, i_Form.FuelType);
        }

        public void FillEnergySource(params object[] list)
        {
            m_MyEngine.FillEnergy(list);
        }

        public void FillAir(float i_AirToAdd)
        {
            foreach (Wheel wheel in m_MyWheel)
            {
                wheel.AirPump(i_AirToAdd);
            }
        }

        public float AirPressure
        {
            get { return m_MyWheel[0].m_CurrentAirPressure; }
        }

        void CheckAndCreateEngineType(ENumType.eEnergytype i_EngineType, ENumType.eFuelType i_FuelType)
        {
            switch (i_EngineType)
            { 
                 case ENumType.eEnergytype.Gasoline:
                      {
                         m_MyEngine =  new GasolineEngine(m_EnergyPercentage, r_MaxEnergyCapacity, i_FuelType);
                        break;
                      }
                case ENumType.eEnergytype.Elecrtic:
                     {
                m_MyEngine = new ElectricEngine(m_EnergyPercentage, r_MaxEnergyCapacity);
                        break;
                     }
            }
        }

        public float MaxAirPressure
        {
            get { return m_MyWheel[0].r_MaxAirPressure; }
        }

        public ENumType.eVehicleStatus Status
        {
            set { m_MyOwner.Status = value; }
            get { return m_MyOwner.Status; }
        }
    }
}