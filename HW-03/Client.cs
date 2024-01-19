using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_03
{
    internal class Client
    {
        internal string PhoneNumber
        {
            get
            {
                return PhoneNumber;
            }
            private set
            {
                PhoneNumber = value;
            }
        }
        internal string SureName
        {
            get
            {
                return SureName;
            }
            private set
            {
                SureName = value;
            }
        }
        internal string Name
        {
            get
            {
                return Name;
            }
            private set
            {
                Name = value;
            }
        }
        internal double CardBalance
        {
            get
            {
                return CardBalance;
            }
            private set
            {
                CardBalance = value;
            }
        }
        internal string ClientAddress;
        internal Client() { }
        internal Client(string phoneNumber, string name, string clientAddress, double cardBalance, string clientName)
        {
            PhoneNumber = phoneNumber;
            Name = name;
            ClientAddress = clientAddress;
            CardBalance= cardBalance;
            ClientAddress = clientAddress;

        }
    }
}
