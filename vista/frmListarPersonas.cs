using controlador;
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
        public frmListarPersonas()
        {
            InitializeComponent();
            logicaPersona = new personaBL();
            dgvPersonas.DataSource = logicaPersona.listar();
        }
    }
}
