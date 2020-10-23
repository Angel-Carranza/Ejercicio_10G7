using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CL19037Ejercicio10Guia7
{
    public partial class Form1 : Form
    {
        Pedido Orden = new Pedido();
        public Form1()
        {
            InitializeComponent();
            ttAyuda.SetToolTip(lbPedido, "cunado haga su pedido se le recomienda segir el orden que se le plantea en el menu");
        }

        private void btnOrdenarMiaz_Click(object sender, EventArgs e)
        {
            int count = 0, cfq = 0, crv = 0, cql = 0;
            bool correcto;
            double totalG = 0;
            double fq, rv, ql, tot;
            int pedido;
            do
            {
                correcto = int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Bienvenido, que desea comer\n\nLe ofrecemos pupusas.\n1. Frijol con queso $0.50 c/u\n2. Revueltas $0.75 c/u\n3. Queso con loroco $1.00 c/u\n_"), out pedido);

                if (count == 0 && correcto == true)
                {
                    Orden.FQ = pedido;
                    cfq = pedido;
                    lbPedido.Items.Add("Pupusas de maiz.");
                    lbPedido.Items.Add("1. Frijol con queso: " + pedido.ToString());
                    count++;
                }
                else if (count == 1 && correcto == true)
                {
                    Orden.RV = pedido;
                    crv = pedido;
                    lbPedido.Items.Add("2. Revueltas: " + pedido.ToString());
                    count++;
                }
                else if (count == 2 && correcto == true)
                {
                    Orden.QL = pedido;
                    cql = pedido;
                    lbPedido.Items.Add("3. Queso con loroco: " + pedido.ToString());
                    count++;
                }
            } while (count != 3);

            fq = Orden.TotalFQ();
            rv = Orden.TotalRV();
            ql = Orden.TotalQL();
            tot = fq + rv + ql;

            dgvTotalesMaiz.Rows.Add("Cantidad: " + cfq + " $" + fq, "Cantidad: " + crv + " $" + rv, "Cantidad: " + cql + " $" + ql, " $" + tot, "");
            double.TryParse(lblTotal.Text, out totalG);
            lblTotal.Text = (totalG + tot) + "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lbPedido.Items.Clear();
            lblTotal.Text = "-";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbPedido.Items.Clear();
            dgvTotalesMaiz.Rows.Clear();
            dgvTotalesArroz.Rows.Clear();
            dgvTotalesBebidas.Rows.Clear();
            lblTotal.Text = "-";
        }

        private void btnOrdenarArroz_Click(object sender, EventArgs e)
        {
            int count = 0, cfq = 0, crv = 0, cql = 0;
            double totalG = 0;
            bool correcto;
            double fq, rv, ql, tot;
            int pedido;
            do
            {
                correcto = int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Bienvenido, que desea comer\n\nLe ofrecemos pupusas.\n1. Frijol con queso $0.50 c/u\n2. Revueltas $0.75 c/u\n3. Queso con loroco $1.00 c/u\n_"), out pedido);

                if (count == 0 && correcto == true)
                {
                    Orden.FQ = pedido;
                    cfq = pedido;
                    lbPedido.Items.Add("Pupusas de arroz.");
                    lbPedido.Items.Add("1. Frijol con queso: " + pedido.ToString());
                    count++;
                }
                else if (count == 1 && correcto == true)
                {
                    Orden.RV = pedido;
                    crv = pedido;
                    lbPedido.Items.Add("2. Revueltas: " + pedido.ToString());
                    count++;
                }
                else if (count == 2 && correcto == true)
                {
                    Orden.QL = pedido;
                    cql = pedido;
                    lbPedido.Items.Add("3. Queso con loroco: " + pedido.ToString());
                    count++;
                }
            } while (count != 3);

            fq = Orden.TotalFQ();
            rv = Orden.TotalRV();
            ql = Orden.TotalQL();
            tot = fq + rv + ql;

            dgvTotalesArroz.Rows.Add("Cantidad: " + cfq + " $" + fq, "Cantidad: " + crv + " $" + rv, "Cantidad: " + cql + " $" + ql, " $" + tot, "");
            double.TryParse(lblTotal.Text, out totalG);
            lblTotal.Text = (totalG + tot) + "";
        }

        private void btnOrdenarBebidas_Click(object sender, EventArgs e)
        {
            int count = 0, cA = 0, cS = 0, cC = 0, cCa = 0;
            bool correcto;
            double agu, sod, cho, caf, tot;
            double totalG = 0;

            int pedido;
            do
            {
                correcto = int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Bienvenido, que desea beber\n\nLe ofrecemos bebidas.\n1. Agua $0.35 c/u\n2. Soda $0.60 c/u\n3. Chocolate $0.75 c/u \n4. Café $0.50 c/u\n_"), out pedido);

                if (count == 0 && correcto == true)
                {
                    Orden.Agua = pedido;
                    cA = pedido;
                    lbPedido.Items.Add("\nBebidas");
                    lbPedido.Items.Add("1. Agua " + pedido.ToString());
                    count++;
                }
                else if (count == 1 && correcto == true)
                {
                    Orden.Soda = pedido;
                    cS = pedido;
                    lbPedido.Items.Add("2. Soda " + pedido.ToString());
                    count++;
                }
                else if (count == 2 && correcto == true)
                {
                    Orden.Chocolate = pedido;
                    cC = pedido;
                    lbPedido.Items.Add("3. Chocolate " + pedido.ToString());
                    count++;
                }
                else if (count == 3 && correcto == true)
                {
                    Orden.Cafe = pedido;
                    cCa = pedido;
                    lbPedido.Items.Add("4. Café " + pedido.ToString());
                    count++;
                }
            } while (count != 4);

            agu = Orden.TotalAgua();
            sod = Orden.TotalSoda();
            cho = Orden.TotalChocolate();
            caf = Orden.TotalCafe();
            tot = agu + sod + cho + caf;

            dgvTotalesBebidas.Rows.Add("Cantidad: " + cA + " $" + agu, "Cantidad: " + cS + " $" + sod, "Cantidad: " + cC + " $" + cho, "Cantidad: " + cCa + " $" + caf, "$" + tot, "");
            double.TryParse(lblTotal.Text, out totalG);
            lblTotal.Text = (totalG + tot) + "";
        }
    }
}
