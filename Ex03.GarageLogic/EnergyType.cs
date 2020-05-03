using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public abstract class EnergyType
    {
        protected float m_CurrentAmount;
        protected float m_MaximumAmount;

        public abstract void FillEnergy(params object[] list);
    }
}