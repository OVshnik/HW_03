using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_03
{
    class PickPointDelivery : Delivery
    {
        internal string PickPointAddress;
        public override string Address
        {
            get
            {
                return PickPointAddress;
            }
            protected set
            {
                PickPointAddress = base.Address;
            }
        }

        bool PayStatus;

        public override DateTime DelDate { get; set; }

        private Client client;

        public PickPointDelivery()
        {
            client = new Client();
        }
        public override void ShowClientInfo()
        {
            base.ShowClientInfo();
            Console.WriteLine($"{client.Name},\n{client.SureName},\n{client.PhoneNumber}");
        }
        public override void Payment()
        {
            // Логика оплаты заказа
            base.Payment();
            ProdBaskcet pb = new ProdBaskcet();
            double cb = client.CardBalance;
            double sum = pb.SumPrice;
            if (cb < sum)
            {
                Console.WriteLine("Isufficient funds on card");
                PayStatus = false;
            }
            else
            {
                Console.WriteLine("Payment was successful");
                PayStatus = true;
            }
        }
        public override void DelInfo()
        {
            Console.WriteLine($"Delivery date:{DelDate}");
            // Логика определения статуса доставки
            DeliveryStatus ds = new DeliveryStatus();
            if (PayStatus == false)
            {
                ds = DeliveryStatus.Canceled;
            }
            else 
            {
                ds = DeliveryStatus.Accepted;
                // Логика реализации доаствки
                ds = DeliveryStatus.AwaitInPickPoint;
                Console.WriteLine("Еhe order is waiting at the pick-up point");
            }

        }
    }
}
