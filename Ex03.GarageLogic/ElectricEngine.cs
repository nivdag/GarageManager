using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class ElectricEngine : EnergyType
    {

       public ElectricEngine(float i_CurrentAmount,float i_MaximumAmount)
        {
            m_CurrentAmount = i_CurrentAmount;
            m_MaximumAmount = i_MaximumAmount;
        }

        public override void FillEnergy(params object[] list)
        {
            if(list.Length != 1)
            {
                throw new ArgumentException("The vehicle runs on a fuel");                  
            }
            if ((m_CurrentAmount + (float)list[0]) > m_MaximumAmount)
            {
                throw new ValueOutOfRangeException((float)list[0], m_MaximumAmount, 0);
            }

            m_CurrentAmount += (float)list[0];
        }
    }
}
