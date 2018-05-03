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
    public partial class frmListarPersonas : Form
    {
        private personaBL logicaPersona;
        private Persona personaSeleccionada;
        private int posicion;
        public frmListarPersonas()
        {
            InitializeComponent();
            logicaPersona = new personaBL();
            dgvPersonas.DataSource = logicaPersona.listar();
        }

        public Persona PersonaSeleccionada { get => personaSeleccionada; set => personaSeleccionada = value; }
        public int Posicion { get => posicion; set => posicion = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            personaSeleccionada = (Persona)dgvPersonas.CurrentRow.DataBoundItem;
            posicion = dgvPersonas.CurrentRow.Index;
            this.DialogResult = DialogResult.OK;
        }
    }
}
