using Ex03.GarageLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.ConsoleUI
{
    public class GarageManager
    {
        int m_Choice;
        string m_RegistrationNumber;
        DataBase m_DataBase = new DataBase();
        Form m_NewUserForm;

        public void Run()
        {
            bool programIsRunning = true;
            while (programIsRunning)
            {
                //VehicleBase Vehicle = VehicleFactory.CreateVehicle("motorcycle");
                //Vehicle.FillEnergySource(4.5f);

                Console.WriteLine("Please Enter your choice");
                PrintEnum(ENumType.eMenuChoises.AddAirToTires);

                string userInput = Console.ReadLine();
                Console.Clear();
                /// check if user choice is valid: 
                try
                {
                    m_Choice = int.Parse(userInput);

                    switch ((ENumType.eMenuChoises)m_Choice)
                    {
                        case ENumType.eMenuChoises.InsertVehicle:
                            {
                                Console.WriteLine("Enter registration number");
                                m_RegistrationNumber = Console.ReadLine();
                                Console.Clear();
                                if (m_DataBase.CheckIfVehicleIsInList(m_RegistrationNumber))
                                {
                                    //to do
                                }
                                else
                                {
                                    m_NewUserForm = new Form();
                                    m_NewUserForm.RegistrationNumber = m_RegistrationNumber;
                                    GetDetailsFromUser(m_NewUserForm);
                                    VehicleFactory.CreateVehicle(m_NewUserForm.VehicleType, m_NewUserForm);
                                }

                                break;
                            }
                        case ENumType.eMenuChoises.ViewRegistrationNumbers:
                            {
                                ViewRegistrationNumbers();
                                break;
                            }
                        case ENumType.eMenuChoises.ChangeVehicleStatus:
                            {
                                ChangeVehicleStatus();
                                break;
                            }
                        case ENumType.eMenuChoises.AddAirToTires:
                            {
                                AddAirToTires();
                                break;
                            }
                        case ENumType.eMenuChoises.FuelVehicle:
                            {
                                FuelVehicle();
                                break;
                            }
                        case ENumType.eMenuChoises.ChargeVehicle:
                            {
                                ChargeVehicle();
                                break;
                            }
                        case ENumType.eMenuChoises.ViewFullDetails:
                            {
                                break;
                            }
                        case ENumType.eMenuChoises.Exit:
                            {
                                programIsRunning = false;
                                break;
                            }
                        default:
                            string msg = string.Format(
 @"Error, invalid option selected
Press enter to continue");
                            throw new Exception(msg);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                }
                Console.Clear();
            }
        }

        public void PrintEnum<T>(T i_MyEnum)
        {
            int currentOptionNumber = 1;
            string input;
            int i;
            int length;
            //since we print the actual enum name, we need to put space before upperCase

            foreach (T option in Enum.GetValues(i_MyEnum.GetType()))
            {
                input = option.ToString();
                length = input.Length;

                for (i = 1; i < length; i++)
                {
                    if (char.IsUpper(input[i]))
                    {
                        input = input.Insert(i, " ");
                        i++;
                    }
                }
                Console.WriteLine(currentOptionNumber.ToString() + ". " + input);
                currentOptionNumber++;
            }
        }

        public void GetDetailsFromUser(Form i_NewUserForm)
        {
            string input;
            try
            {
                Console.WriteLine("Enter owner's name");
                input = Console.ReadLine();
                i_NewUserForm.OwnerName = input;
                Console.Clear();

                Console.WriteLine("Enter owner's phone number");
                input = Console.ReadLine();
                i_NewUserForm.OwnerPhoneNumber = input;
                Console.Clear();

                Console.WriteLine("Please Enter the vehicle type");
                PrintEnum(ENumType.eVehicleList.Car);
                input = Console.ReadLine();
                i_NewUserForm.VehicleType = (ENumType.eVehicleList)Enum.Parse(typeof(ENumType.eVehicleList), input, true);
                Console.Clear();

                switch (i_NewUserForm.VehicleType)
                {

                    case ENumType.eVehicleList.Car:
                        {
                            i_NewUserForm.NumberOfWheels = 4;
                            Console.WriteLine("Please Enter the car's color");
                            PrintEnum(ENumType.eCarColor.Black);
                            input = Console.ReadLine();
                            i_NewUserForm.CarColor = (ENumType.eCarColor)Enum.Parse(typeof(ENumType.eCarColor), input, true);
                            Console.Clear();

                            Console.WriteLine("Please Enter the car's doors number");
                            PrintEnum(ENumType.eCarDoorsNumber.Five);
                            input = Console.ReadLine();
                            i_NewUserForm.CarDoorsNumber = (ENumType.eCarDoorsNumber)Enum.Parse(typeof(ENumType.eCarDoorsNumber), input, true);
                            Console.Clear();
                            break;
                        }

                    case ENumType.eVehicleList.Motorcycle:
                        {
                            i_NewUserForm.NumberOfWheels = 2;
                            Console.WriteLine("Please Enter the License type");
                            PrintEnum(ENumType.eLicenseType.A);
                            input = Console.ReadLine();
                            i_NewUserForm.MotorLicense = (ENumType.eLicenseType)Enum.Parse(typeof(ENumType.eLicenseType), input, true);
                            Console.Clear();

                            Console.WriteLine("Enter Engine capacity");
                            input = Console.ReadLine();
                            i_NewUserForm.WheelMaxAirPressure = int.Parse(input);
                            Console.Clear();
                            break;
                        }

                    case ENumType.eVehicleList.Truck:
                        {
                            i_NewUserForm.NumberOfWheels = 12;
                            Console.WriteLine("Is The truck Carrying dangerous substance? Y/N ");
                            input = Console.ReadLine();
                            Console.Clear();

                            if (input.Equals("Y") || input.Equals("y"))
                            {
                                i_NewUserForm.IsCarryingDangerousSubstance = true;
                            }
                            else if (input.Equals("N") || input.Equals("n"))
                            {
                                i_NewUserForm.IsCarryingDangerousSubstance = false;
                            }
                            else
                            {
                                throw new SystemException("Incorrect input");
                            }
                            Console.WriteLine("What is the maximum weight that the truck can carry");
                            input = Console.ReadLine();
                            i_NewUserForm.MaximumWeightAllow = int.Parse(input);
                            Console.Clear();
                            break;
                        }
                }

                Console.WriteLine("Enter wheels Manufacturer name");
                input = Console.ReadLine();
                i_NewUserForm.WheelManufacturer = input;
                Console.Clear();
                Console.WriteLine("Enter wheels Maximum air pressure");
                input = Console.ReadLine();
                i_NewUserForm.WheelMaxAirPressure = float.Parse(input);
                Console.Clear();
                Console.WriteLine("Enter wheels current air pressure");
                input = Console.ReadLine();
                Console.Clear();
                if (float.Parse(input) > i_NewUserForm.WheelMaxAirPressure)
                {
                    throw new ValueOutOfRangeException(float.Parse(input), i_NewUserForm.WheelMaxAirPressure, 0);
                }
                else
                {
                    i_NewUserForm.WheelCurrentAirPressure = float.Parse(input);
                }

                Console.WriteLine("Enter model name");
                input = Console.ReadLine();
                i_NewUserForm.ModelName = input;
                Console.WriteLine("Please Enter the Engine type");
                PrintEnum(ENumType.eEnergytype.Elecrtic);
                input = Console.ReadLine();
                i_NewUserForm.EngineType = (ENumType.eEnergytype)Enum.Parse(typeof(ENumType.eEnergytype), input, true); ;
                string energySourceType = "battery charge";
                if (input.Equals("Gasoline") || input.Equals("1") || input.Equals("gasoline"))
                {
                    energySourceType = "fuel tank";
                    Console.WriteLine("Please Enter the fuel type");
                    PrintEnum(ENumType.eFuelType.Octan95);
                    input = Console.ReadLine();
                    i_NewUserForm.FuelType = (ENumType.eFuelType)Enum.Parse(typeof(ENumType.eFuelType), input, true);
                }

                Console.WriteLine("Enter maximum " + energySourceType);
                input = Console.ReadLine();
                i_NewUserForm.MaxEnergyCapacity = float.Parse(input);
                Console.Clear();
                Console.WriteLine("Enter current " + energySourceType);
                input = Console.ReadLine();
                i_NewUserForm.EnergyPercentageLeft = float.Parse(input);
                Console.Clear();
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect format");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Incorrect input");
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message, ex);
            }
        }

        public void ViewRegistrationNumbers()
        {
            Console.WriteLine("Please choose the wanted filltering option");
            PrintEnum(ENumType.eVehicleRegistrationNumberListWithFilterring.AtWork);

            int option = int.Parse(Console.ReadLine());

            switch ((ENumType.eVehicleRegistrationNumberListWithFilterring)option)
            {
                case ENumType.eVehicleRegistrationNumberListWithFilterring.ShowAll:
                    {
                        foreach (VehicleBase vehicle in m_DataBase.ListOfVehicles)
                        {
                            Console.WriteLine(vehicle.r_RegistrationNumber);
                        }
                        break;
                    }
                case ENumType.eVehicleRegistrationNumberListWithFilterring.AtWork:
                    {
                        foreach (VehicleBase vehicle in m_DataBase.ListOfVehicles)
                        {
                            if (vehicle.Status.Equals(ENumType.eVehicleStatus.AtWork))
                            {
                                Console.WriteLine(vehicle.r_RegistrationNumber);
                            }
                        }
                        break;
                    }
                case ENumType.eVehicleRegistrationNumberListWithFilterring.Fixed:
                    {
                        foreach (VehicleBase vehicle in m_DataBase.ListOfVehicles)
                        {
                            if (vehicle.Status.Equals(ENumType.eVehicleStatus.Fixed))
                            {
                                Console.WriteLine(vehicle.r_RegistrationNumber);
                            }
                        }
                        break;
                    }
                case ENumType.eVehicleRegistrationNumberListWithFilterring.Paid:
                    {
                        foreach (VehicleBase vehicle in m_DataBase.ListOfVehicles)
                        {
                            if (vehicle.Status.Equals(ENumType.eVehicleStatus.Paid))
                            {
                                Console.WriteLine(vehicle.r_RegistrationNumber);
                            }
                        }
                        break;
                    }
            }
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
        }

        public void AddAirToTires()
        {
            Console.WriteLine("Enter vehicle registration number:");
            string userRegistrationNumber = Console.ReadLine();
            DataBase.FillTires(userRegistrationNumber);
        }

        public void FuelVehicle()
        {
            Console.WriteLine("Enter vehicle registration number:");
            string userRegistrationNumber = Console.ReadLine();
            Console.WriteLine("Please Enter the fuel type");
            PrintEnum(ENumType.eFuelType.Octan95);
            string userFuelChoice = Console.ReadLine();
            ENumType.eFuelType typeToAdd = (ENumType.eFuelType)Enum.Parse(typeof(ENumType.eFuelType), 
                                                                                userFuelChoice, true);
            Console.WriteLine("Enter amount:");
            float AmountToAdd = float.Parse(Console.ReadLine());
            DataBase.FuelVehicle(userRegistrationNumber, typeToAdd, AmountToAdd);
        }

        public void ChangeVehicleStatus()
        {
            ENumType.eVehicleStatus newUserStatus;
            Console.WriteLine("Enter vehicle registration number:");
            string userRegistrationNumber = Console.ReadLine();
            Console.WriteLine("Choose new status:");
            PrintEnum(ENumType.eVehicleStatus.AtWork);
            string newStatusStr = Console.ReadLine();
            /// convert to the required enum
            if (newStatusStr.Equals("At work") || newStatusStr.Equals("1") || newStatusStr.Equals("at work"))
            {
                newUserStatus = ENumType.eVehicleStatus.AtWork;
            }
            else if (newStatusStr.Equals("Fixed") || newStatusStr.Equals("2") || newStatusStr.Equals("fixed"))
            {
                newUserStatus = ENumType.eVehicleStatus.Fixed;
            }
            else if (newStatusStr.Equals("Paid") || newStatusStr.Equals("3") || newStatusStr.Equals("paid"))
            {
                newUserStatus = ENumType.eVehicleStatus.Paid;
            }
            else
            {
                throw new SystemException("Invalid Status");
            }

            DataBase.ChangeOwnersVehicleStatus(userRegistrationNumber, newUserStatus);
        }

        private void ChargeVehicle()
        {
            Console.WriteLine("Enter vehicle registration number:");
            string userRegistrationNumber = Console.ReadLine();
            Console.WriteLine("Enter battery time to add:");
            float userTimeToAdd = float.Parse(Console.ReadLine());
            DataBase.ChargeVehicle(userRegistrationNumber, userTimeToAdd);
        }

    }
}