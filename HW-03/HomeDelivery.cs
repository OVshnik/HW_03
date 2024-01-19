using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_03
{
    class HomeDelivery : Delivery
    {

        bool PayStatus;
        public override DateTime DelDate { get; set; }

        private Client client;

        public HomeDelivery()
        {
            client = new Client();
        }
        private Courier c;
        public HomeDelivery(Courier c)
        {
            this.c = c;
        }
        public override void ShowClientInfo()
        {
            // Информация о клиенте
            base.ShowClientInfo();
            Console.WriteLine($"{client.Name},\n{client.SureName},\n{client.ClientAddress},\n{client.PhoneNumber}");
        }
        public override void Payment()
        {
            // Логика оплаты заказа и доставки
            base.Payment();
            ProdBaskcet pb = new ProdBaskcet();
            double cb = client.CardBalance;
            double sum = c.DelPrice + pb.SumPrice;
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
            Console.WriteLine($"Delivery date:{DelDate}\n,Courier name:{c.Name},Phone number:{c.PhoneNum}");
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
                ds = DeliveryStatus.Delivered;
            }

        }

    }
}
