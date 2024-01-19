using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_03
{
    internal class ProdBaskcet

    {
        internal byte amountProd
        {
            get { return amountProd; }
            private set
            {
                amountProd = Convert.ToByte(selectedProd.Length);
            }
        }
        internal double SumPrice
        {
            get
            {
                return SumPrice;
            }
            set { 
                Product product = new Product();
                SumPrice = amountProd * product.ProdPrice;
            }
        }
        internal string[] selectedProd;
        private Product[] product;
        internal string[] SelectProduct()
        {

            for (int i = 0; i < product.Length; i++)
            {
                Console.WriteLine($"Product schedule:\n{product[i]}");
            }
            Console.WriteLine("Please choose products");
            string[] array = new string[0];
            for (int j = 0; j < array.Length; j++)
            {
                array[j] = Console.ReadLine();
            }
            selectedProd = array;
            return selectedProd;
        }
    }
}
