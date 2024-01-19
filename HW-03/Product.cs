using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_03
{
    internal class Product
    {
        public int ProdId
        {
            get { return ProdId; }
            private set { ProdId = value; }
        }
        public string ProdName
        {
            get { return ProdName; }
            private set { ProdName = value; }
        }
        public string ProdDescription
        {
            get { return ProdDescription; }
            private set { ProdDescription = value; }
        }
        public double ProdPrice
        {
            get { return ProdPrice; }
            private set { ProdPrice = value; }
        }

    }
}
