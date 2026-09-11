using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionMDI
{
    public partial class VentanaHijo : Form
    {
        public VentanaHijo()
        {
            InitializeComponent();
        }

        private void VentanaHijo_Load(object sender, EventArgs e)
        {

        }
        public void RecibirMensaje(string mensaje)
        {
            // Aquí haces lo que necesites con el mensaje, por ejemplo asignarlo a un Label o TextBox
            // lblMensaje.Text = mensaje; 
        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {
            VentanaHijo ventanaHijo = Application.OpenForms.OfType<VentanaHijo>().FirstOrDefault();

            if (ventanaHijo != null)
            {
                // Si ya está abierta, simplemente le envías el nuevo mensaje
                ventanaHijo.RecibirMensaje("Nuevo mensaje con la ventana ya abierta");
                ventanaHijo.BringToFront();
            }
            else
            {
                ventanaHijo = new VentanaHijo();
                ventanaHijo.MdiParent = this;
                ventanaHijo.Show();
                // Llamas al método justo después de mostrarla
                ventanaHijo.RecibirMensaje("Mensaje inicial");
            }
        }
    }
}
