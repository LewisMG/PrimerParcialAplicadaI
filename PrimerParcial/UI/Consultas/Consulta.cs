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
                case 0://Id
                    filtro = t => t.GrupoId.Equals(CriterioTextBox.Text)
                    && (t.Fecha.Day >= DesdedateTimePicker.Value.Day) && (t.Fecha.Month >= DesdedateTimePicker.Value.Month) 
                    && (t.Fecha.Year >= DesdedateTimePicker.Value.Year) && (t.Fecha.Day <= HastadateTimePicker.Value.Day)    
                    && (t.Fecha.Month <= HastadateTimePicker.Value.Month) && (t.Fecha.Year <= HastadateTimePicker.Value.Year);
                    break;

                case 1://descripcion
                    filtro = t => t.Descripcion.Equals(CriterioTextBox.Text)
                    && (t.Fecha.Day >= DesdedateTimePicker.Value.Day) && (t.Fecha.Month >= DesdedateTimePicker.Value.Month)
                    && (t.Fecha.Year >= DesdedateTimePicker.Value.Year) && (t.Fecha.Day <= HastadateTimePicker.Value.Day)
                    && (t.Fecha.Month <= HastadateTimePicker.Value.Month) && (t.Fecha.Year <= HastadateTimePicker.Value.Year);
                    break;
                case 2://Cantidad de estudiantes
                    filtro = t => t.Cantidad.Equals(CriterioTextBox.Text)
                    && (t.Fecha.Day >= DesdedateTimePicker.Value.Day) && (t.Fecha.Month >= DesdedateTimePicker.Value.Month)
                    && (t.Fecha.Year >= DesdedateTimePicker.Value.Year) && (t.Fecha.Day <= HastadateTimePicker.Value.Day)
                    && (t.Fecha.Month <= HastadateTimePicker.Value.Month) && (t.Fecha.Year <= HastadateTimePicker.Value.Year);
                    break;
                case 3://Grupos deseados
                    filtro = t => t.GruposDeseados.Equals(CriterioTextBox.Text)
                    && (t.Fecha.Day >= DesdedateTimePicker.Value.Day) && (t.Fecha.Month >= DesdedateTimePicker.Value.Month)
                    && (t.Fecha.Year >= DesdedateTimePicker.Value.Year) && (t.Fecha.Day <= HastadateTimePicker.Value.Day)
                    && (t.Fecha.Month <= HastadateTimePicker.Value.Month) && (t.Fecha.Year <= HastadateTimePicker.Value.Year);
                    break;
                case 4://Integrantes
                    filtro = t => t.Integrantes.Equals(CriterioTextBox.Text)
                    && (t.Fecha.Day >= DesdedateTimePicker.Value.Day) && (t.Fecha.Month >= DesdedateTimePicker.Value.Month)
                    && (t.Fecha.Year >= DesdedateTimePicker.Value.Year) && (t.Fecha.Day <= HastadateTimePicker.Value.Day)
                    && (t.Fecha.Month <= HastadateTimePicker.Value.Month) && (t.Fecha.Year <= HastadateTimePicker.Value.Year);
                    break;
                case 5://todos
                    filtro=  x=> true;
                    break;

            }

            ConsultaDataGridView.DataSource = BLL.GruposBLL.GetList(filtro);
        }
    }
}
