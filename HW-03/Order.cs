using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HW_03
{
    class Order<TDelivery,
    TStruct> where TDelivery : Delivery
    {
        public TDelivery Delivery;

        public int Number;

        public string Description;

        OrderStatus Status;

        public DateTime RegisterOrder;


        private ProdBaskcet prodBaskcet;
        public Order(ProdBaskcet prodBaskcet)
        {
            this.prodBaskcet = prodBaskcet;
        }
        public void OrderStatus()
        {
            //логика подтверждения заказа
            Status = HW_03.OrderStatus.Accepted;
        }
        public void GetOrderInfo()
        {    //поучение информации о заказе
            Console.WriteLine($"Order:Number-{Number}\nRegistration time-{RegisterOrder}Description-{Description}Product amount-\n{prodBaskcet.amountProd}Selected products-\n{prodBaskcet.selectedProd}Total cost-\n{prodBaskcet.SumPrice}");
        }
        public TDelivery GetDelivery()
        {
            // Логика передачи заказа в доставку
            return Delivery;
        }
    }
}
