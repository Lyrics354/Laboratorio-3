using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace EjemploGrid
{
    public partial class Form1 : Form
    {
        //ArrayList para almacenar los objetos Persona
        //ArrayList pertenece al espacio de nombres System.Collections

        ArrayList listaPersonas = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Persona miColaborador1 = new Persona();

            miColaborador1.Id = 1;
            miColaborador1.Nombres = "Elena Carolina";
            miColaborador1.Apellidos = "Gonzalez Rodriguez";
            miColaborador1.Correo = "elena.gonzalez@ejemplo.com";
            miColaborador1.FechaNacimiento = new DateTime(1990, 5, 15);
            listaPersonas.Add(miColaborador1);
            dgvdatos.DataSource = listaPersonas;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                errorProvider1.SetError(txtID, "Ingrese un ID");
                txtID.Focus();
                return; // <-- Interrumpe y finaliza la ejecución del método actual
            }
            else
            {
                errorProvider1.SetError(txtID, "");
            }

            if (txtNombres.Text == "")
            {
                errorProvider1.SetError(txtNombres, "Ingrese los nombres del Colaborador");
                txtNombres.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtNombres, "");
            }

            if (txtApellidos.Text == "")
            {
                errorProvider1.SetError(txtApellidos, "Ingrese los apellidos del Colaborador");
                txtApellidos.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtApellidos, "");
            }

            if (Utilidades.EsCorreoValido(txtCorreo.Text) == false)
            {
                errorProvider1.SetError(txtCorreo, "Ingrese un correo válido");
                txtCorreo.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtCorreo, "");
            }

            decimal salario1;
            if (!decimal.TryParse(txtSalario.Text, out salario1))
            {
                errorProvider1.SetError(txtSalario, "Ingrese un salario válido");
                txtSalario.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtSalario, "");
            }

            Persona colaborador1 = new Persona();
            colaborador1.Id = int.Parse(txtID.Text);
            colaborador1.Nombres = txtNombres.Text;
            colaborador1.Apellidos = txtApellidos.Text;
            colaborador1.Correo = txtCorreo.Text;
            colaborador1.Salario = salario1;
            colaborador1.FechaNacimiento = dtpFechaNacimiento.Value;
            listaPersonas.Add(colaborador1);
            dgvdatos.DataSource = null; // Limpiar el DataSource antes de asignar la nueva lista
            dgvdatos.DataSource = listaPersonas;
        }

        private void btnBorrarTodo_Click_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro que desea borrar todos los datos?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                // 1. Vaciar la lista (incluye el dato de prueba cargado en Form1_Load)
                listaPersonas.Clear();
                dgvdatos.DataSource = null;
                dgvdatos.DataSource = listaPersonas;

                // 2. Limpiar los campos del formulario
                txtID.Text = "";
                txtNombres.Text = "";
                txtApellidos.Text = "";
                txtCorreo.Text = "";
                txtSalario.Text = "";
                dtpFechaNacimiento.Value = DateTime.Now;

                // 3. Limpiar los errores del errorProvider por si quedaron marcados
                errorProvider1.Clear();

                MessageBox.Show("Todos los datos han sido eliminados.");
            }
        }
    }
}