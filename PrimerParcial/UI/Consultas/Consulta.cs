using PrimerParcial.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace PrimerParcial.UI.Consultas
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Expression<Func<Grupos, bool>> filtro = x => true;
            
            switch (FiltroComboBox.SelectedIndex)
            {
                case 0://Nombre en este caso descripcion
                    filtro = x => x.Descripcion.Equals(CriterioTextBox.Text)
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;
            }

            ConsultaDataGridView.DataSource = BLL.GruposBLL.GetList(filtro);
        }
    }
}
