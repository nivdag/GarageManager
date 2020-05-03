namespace Ex03.GarageLogic
{
    public class Owner
    {
        private string m_Name;
        private string m_PhoneNumber;
        private ENumType.eVehicleStatus m_VehicleStatus;

        public Owner(Form i_Form)
        {
            m_Name = i_Form.OwnerName;
            m_PhoneNumber = i_Form.OwnerPhoneNumber;
            m_VehicleStatus = ENumType.eVehicleStatus.AtWork;
        }

        public ENumType.eVehicleStatus Status
        {
            get { return m_VehicleStatus; }
            set { this.m_VehicleStatus = value; }
        }
    }
}
