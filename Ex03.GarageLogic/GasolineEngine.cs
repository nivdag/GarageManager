using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
     class GasolineEngine : EnergyType
    {
        ENumType.eFuelType m_CurrentGasolineType;
        
        public GasolineEngine(float i_CurrentAmount, float i_MaximumAmount, ENumType.eFuelType i_CurrentGasolineType)
        {
            m_CurrentAmount = i_CurrentAmount;
            m_MaximumAmount = i_MaximumAmount;
            m_CurrentGasolineType = i_CurrentGasolineType;
        }

        public override void FillEnergy(params object[] list)
        {
            if(list.Length != 2)
            {
                throw new ArgumentException("This vehicle is electric");
            }
            else if (m_CurrentGasolineType != (ENumType.eFuelType)list[0])
            {
                throw new ArgumentException("incorrect fuel type");
            }

            else if ((m_CurrentAmount + (float)list[1]) > m_MaximumAmount)
            {
                throw new ValueOutOfRangeException((float)list[1], (m_MaximumAmount - m_CurrentAmount), 0);
            }

            m_CurrentAmount += (float)list[1];
        }
    }
}
