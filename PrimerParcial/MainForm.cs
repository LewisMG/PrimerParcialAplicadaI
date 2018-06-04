using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrimerParcial.UI.Registros;
using PrimerParcial.UI.Consultas;

namespace PrimerParcial
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro ver = new Registro();
            ver.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta ver = new Consulta();
            ver.Show();
        }
    }
}
