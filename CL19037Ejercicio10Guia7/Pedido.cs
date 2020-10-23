using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL19037Ejercicio10Guia7
{
    class Pedido
    {
        int fQ, rV, qL, agua, soda, chocolate, cafe;

        public int Agua
        {
            get
            {
                return agua;
            }

            set
            {
                agua = value;
            }
        }
        public int Cafe
        {
            get
            {
                return cafe;
            }

            set
            {
                cafe = value;
            }
        }
        public int Chocolate
        {
            get
            {
                return chocolate;
            }

            set
            {
                chocolate = value;
            }
        }
        public int FQ
        {
            get
            {
                return fQ;
            }

            set
            {
                fQ = value;
            }
        }
        public int QL
        {
            get
            {
                return qL;
            }

            set
            {
                qL = value;
            }
        }
        public int RV
        {
            get
            {
                return rV;
            }

            set
            {
                rV = value;
            }
        }
        public int Soda
        {
            get
            {
                return soda;
            }

            set
            {
                soda = value;
            }
        }

        public double TotalFQ()
        {
            double total;
            total = fQ * 0.50;
            return total;
        }
        public double TotalRV()
        {
            double total;
            total = rV * 0.75;
            return total;
        }
        public double TotalQL()
        {
            double total;
            total = qL * 1.00;
            return total;
        }
        public double TotalAgua()
        {
            double total;
            total = agua * 0.35;
            return total;
        }
        public double TotalSoda()
        {
            double total;
            total = soda * 0.60;
            return total;
        }
        public double TotalChocolate()
        {
            double total;
            total = chocolate * 0.75;
            return total;
        }
        public double TotalCafe()
        {
            double total;
            total = cafe * 0.50;
            return total;
        }
    }
}
