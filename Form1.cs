using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionWindows2
{
    public partial class VentanaAplicacion1 : Form
    {
        public VentanaAplicacion1()
        {
            InitializeComponent();
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            if (CajaNombre.Text == "")
                CajaNombre.BackColor = Color.Red;
            else
                CajaNombre.BackColor = System.Drawing.SystemColors.Control;
            if (CajaApellido.Text == "")
                CajaApellido.BackColor = Color.Red;
            else
                CajaApellido.BackColor = System.Drawing.SystemColors.Control;
            if (CajaEdad.Text == "")
                CajaEdad.BackColor = Color.Red;
            else
                CajaEdad.BackColor = System.Drawing.SystemColors.Control;
            if (CajaDireccion.Text == "")
                CajaDireccion.BackColor = Color.Red;
            else
                CajaDireccion.BackColor = System.Drawing.SystemColors.Control;
            if (CajaNombre.Text != "" & CajaApellido.Text != "" & CajaEdad.Text != "" & CajaDireccion.Text != "")
                CajaResultado.Text = CajaApellido.Text+"\r\n"+CajaNombre.Text + "\r\n" + CajaEdad.Text + "\r\n" + CajaDireccion.Text;
        }

        private void CajaEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void CajaApellido_TextChanged(object sender, EventArgs e)
        {
            CajaApellido.BackColor = System.Drawing.SystemColors.Control;
        }

        private void CajaNombre_TextChanged(object sender, EventArgs e)
        {
            CajaNombre.BackColor = System.Drawing.SystemColors.Control;
        }

        private void CajaEdad_TextChanged(object sender, EventArgs e)
        {
            CajaEdad.BackColor = System.Drawing.SystemColors.Control;
        }

        private void CajaDireccion_TextChanged(object sender, EventArgs e)
        {
            CajaDireccion.BackColor = System.Drawing.SystemColors.Control;
        }
    }
}
