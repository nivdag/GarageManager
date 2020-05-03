using System;

namespace Ex03.GarageLogic
{
    public class ValueOutOfRangeException : Exception
    {
        private float MaxValue;
        private float MinValue;

        public ValueOutOfRangeException(float i_Value, float i_MaxVal, float i_MinVal)
            : base(string.Format("Error, {0} is not in range ({1}-{2})", i_Value, i_MinVal, i_MaxVal))
        {
            MaxValue = i_MaxVal;
            MinValue = i_MinVal;
        }
    }
}