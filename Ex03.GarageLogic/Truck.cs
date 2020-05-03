using System;

namespace Ex03.GarageLogic
{
    class Truck : VehicleBase
    {
        protected bool m_IsCarryingDangerousGoods;
        protected readonly float r_MaximumLoad;

        public Truck(bool i_DangerousGoods, float i_MaxLoad, Form i_FilledForm) : base(i_FilledForm)
        {
            m_IsCarryingDangerousGoods = i_DangerousGoods;
            r_MaximumLoad = i_MaxLoad;
        }
        /*public override void FillEnergySource(params object[] list)
        {
            m_MyEngine.FillEnergy(list);
        }*/
    }
}
