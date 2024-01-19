using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_03
{
    internal class ProductData
    {
        public int ProdId;

        private Product[] products;
        public ProductData(Product[] products)
        {
            this.products = products;
        }
        public Product this[int index]
        {

            get
            {

                if (index >= 0 && index < products.Length)
                {
                    return products[index];
                }
                else { return null; }
            }
            private set
            {
                if (index >= 0 && index < products.Length)
                {
                    products[index] = value;
                    ProdId = index;
                }

            }
        }
    }
}
