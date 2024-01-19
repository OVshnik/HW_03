using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_03
{
    abstract class Delivery
    {
        public virtual string Address
        { get; protected set; }
        public abstract DateTime DelDate
        { get; set; }
        public virtual void Payment()
        {
            // Логика для оплаты
            Console.WriteLine("Please select a payment option and enter one of them with a number:\n 1-cash pay,\n 2-card pay");
            byte userInput = Convert.ToByte(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    Console.WriteLine("Order success");
                    break;
                case 2:
                    Console.WriteLine("Please enter card information");
                        break;
            }
        }
        public abstract void DelInfo();

        public virtual void ShowClientInfo()
        {
            // Информация о клиенте
            Console.WriteLine("Client information:");
        }

    }
}
