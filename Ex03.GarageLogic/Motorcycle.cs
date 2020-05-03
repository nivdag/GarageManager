using System;

namespace Ex03.GarageLogic
{
    class Motorcycle : VehicleBase
    {
        protected readonly int r_EngineVolume;
        protected readonly ENumType.eLicenseType r_LicenseType;

        public Motorcycle(int i_Volume, ENumType.eLicenseType i_Type, Form i_FilledForm) : base(i_FilledForm)
        {
            r_EngineVolume = i_Volume;
            r_LicenseType = i_Type;
        }
       /* public override void FillEnergySource(params object[] list)
        {
            m_MyEngine.FillEnergy(list);
        }*/
    }
}
