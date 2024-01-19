using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_03
{
    class ShopDelivery : Delivery
    {
        internal string ShopAddress;
        public override string Address
        {
            get
            {
                return ShopAddress;
            }
            protected set
            {
                ShopAddress = base.Address;
            }
        }

        public override DateTime DelDate { get; set; }

        private Courier c;
        public ShopDelivery(Courier c)
        {
            this.c = c;
        }
        public override void DelInfo()
        {
            Console.WriteLine($"Delivery date:{DelDate}\nShop address:{ShopAddress}\nCourier name:{c.Name}\nCourier phone number:{c.PhoneNum}\nVehicle number:{c.VehicleNumber}");
            // Логика определения статуса доставки
            DeliveryStatus ds = new DeliveryStatus();
                ds = DeliveryStatus.Accepted;
                // Логика реализации доcтавки
                ds = DeliveryStatus.Shipped;
                Console.WriteLine("Order shipped");
            }

        }

    }




