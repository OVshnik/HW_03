using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_03
{
    internal class Courier
    {
        internal float DelDistance { get; private set; }
        internal float DelPrice { get; private set; }
        internal float UnitDelPrice { get; private set; }
        internal byte CourierSpeed { get; private set; }
        internal byte DelTime { get; private set; }
        internal string Name {get;private set;}
        internal string PhoneNum { get;private set;}
        internal string Vehicle { get; private set; }
        internal string VehicleNumber {get;private set;}
        internal float CountDelPrice(float distance, float uPrice)
        {
            distance = DelDistance;
            uPrice = UnitDelPrice;
            DelPrice = distance * uPrice;
            return DelPrice;
        }
        internal byte CountDelTime(float distance, byte courierSpeed)
        {
            _ = distance / (float)courierSpeed;
            var time = DelTime;
            return DelTime;
        }
        internal float CountDelDistance(in string address)
        {
            // Логика расчета расстояния в зависимости от адреса
            return DelDistance;
        }

    }
}
