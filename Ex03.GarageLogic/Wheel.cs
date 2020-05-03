using System;

namespace Ex03.GarageLogic
{
    public class Wheel
    {
        public readonly string r_Manufacturer;
        public float m_CurrentAirPressure;
        public readonly float r_MaxAirPressure;

        public Wheel(string io_r_Manufacturer, float io_CurrentAirPressure, float io_MaxAirPressure)
        {
            r_Manufacturer = io_r_Manufacturer;
            m_CurrentAirPressure = io_CurrentAirPressure;
            r_MaxAirPressure = io_MaxAirPressure;
        }

        public void AirPump(float i_AirToAdd)
        {
            if (i_AirToAdd + m_CurrentAirPressure > r_MaxAirPressure)
            {
                throw new ValueOutOfRangeException(i_AirToAdd, (r_MaxAirPressure - m_CurrentAirPressure), 0f);
            }
            else
            {
                m_CurrentAirPressure += i_AirToAdd;
            }
        }
    }
}
