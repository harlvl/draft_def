using controlador;
using modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vista
{
    public partial class frmPrincipal : Form
    {
        private int posicion;
        private personaBL logicaPersona;
        public frmPrincipal()
        {
            InitializeComponent();
            logicaPersona = new personaBL();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            frmListarPersonas f = new frmListarPersonas();
            if (f.ShowDialog() == DialogResult.OK)
            {
                txtDni.Text = f.PersonaSeleccionada.Dni.ToString();
                txtEdad.Text = f.PersonaSeleccionada.Edad.ToString();
                txtNombre.Text = f.PersonaSeleccionada.Nombre;
                posicion = f.Posicion;
                btnModificar.Enabled = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtDni.Enabled = true;
            txtEdad.Enabled = true;
            txtNombre.Enabled = true;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int dniTemp = Int32.Parse(txtDni.Text);
                int edadTemp = Int32.Parse(txtEdad.Text);
                string nombreTemp = txtNombre.Text;
                Persona p = new Persona(dniTemp, nombreTemp, edadTemp);
                txtDni.Enabled = false;
                txtEdad.Enabled = false;
                txtNombre.Enabled = false;
                //modificar en bd
                if (logicaPersona.insertar(p) > 0)
                {
                    MessageBox.Show("Insertado con exito.");
                }
                else
                {
                    MessageBox.Show("Error al insertar.");
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Ingrese datos validos.");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtDni.Enabled = true;
            txtEdad.Enabled = true;
            txtNombre.Enabled = true;
            btnGuardar.Enabled = true;
            //try
            //{
            //    int dniTemp = Int32.Parse(txtDni.Text);
            //    int edadTemp = Int32.Parse(txtEdad.Text);
            //    string nombreTemp = txtNombre.Text;
            //    Persona p = new Persona(dniTemp, nombreTemp, edadTemp);
            //    logicaPersona.insertar(p);
            //}
            //catch (Exception exc)
            //{
            //    MessageBox.Show("Error al insertar persona.", "Mensaje de error");
            //}
        }
    }
}
