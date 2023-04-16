using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_VarYSec_Ejercicio5
{
    public partial class fCompra : Form
    {
        public fCompra()
        {
            InitializeComponent();
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bVuelto_Click(object sender, EventArgs e)
        {
            string nombre = tNombre.Text;
            double monto = Convert.ToDouble(tMonto.Text);
            double pago = Convert.ToDouble(tPago.Text);
            double vuelto = pago - monto;
            MessageBox.Show(nombre + " su vuelto es de $" + vuelto);
        }
    }
}
