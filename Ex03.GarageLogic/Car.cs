using System;

namespace Ex03.GarageLogic
{
   class Car : VehicleBase
    {
        protected readonly ENumType.eCarDoorsNumber r_NumOfDoors;
        protected ENumType.eCarColor m_CarColour;

        public Car(ENumType.eCarColor i_Colour, ENumType.eCarDoorsNumber i_DoorsNum, Form i_FilledForm) : base(i_FilledForm)
        {
            m_CarColour = i_Colour;
            r_NumOfDoors = i_DoorsNum;            
        }
       /* public override void FillEnergySource(params object[] list)
        {
            m_MyEngine.FillEnergy(list);
        }*/
    }
}
