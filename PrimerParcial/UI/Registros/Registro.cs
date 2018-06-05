using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrimerParcial.Entidades;

namespace PrimerParcial.UI.Registros
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private Grupos LlenaClase()
        {
            Grupos grupo = new Grupos();

            grupo.GrupoId = Convert.ToInt32(GrupoIdnumericUpDown.Value);
            grupo.Descripcion = descripcionTextBox.Text;
            grupo.Cantidad = Convert.ToInt32(CantidadnumericUpDown.Value);
            grupo.GruposDeseados = Convert.ToInt32(GDeseadosnumericUpDown.Value);
            grupo.Fecha = fechaDateTime.Value;
            return grupo;
        }

        private void LimpiarCampos()
        {
            GrupoIdnumericUpDown.Value = 0;
            descripcionTextBox.Clear();
            CantidadnumericUpDown.Value = 0;
            GDeseadosnumericUpDown.Value = 0;
        }

        private bool Validar(int validar)
        {
            bool paso = false;
            if (validar == 1 && GrupoIdnumericUpDown.Value == 0)
            {
                GeneralerrorProvider.SetError(GrupoIdnumericUpDown, "Ingrese un ID");
                paso = true;
            }
            if (validar == 2 && descripcionTextBox.Text == String.Empty)
            {
                GeneralerrorProvider.SetError(descripcionTextBox, "Ingrese una Descripcion");
                paso = true;
            }
            if (validar == 2 && CantidadnumericUpDown.Value == 0)
            {
                GeneralerrorProvider.SetError(CantidadnumericUpDown, "Ingrese Cantidad en Existencia");
                paso = true;
            }
            if (validar == 2 && GDeseadosnumericUpDown.Value == 0)
            {
                GeneralerrorProvider.SetError(GDeseadosnumericUpDown, "Ingrese el Precio");
                paso = true;
            }
            return paso;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GeneralerrorProvider.Clear();
            if (Validar(1))
            {
                MessageBox.Show("Ingrese un ID");
                return;
            }

            int id = Convert.ToInt32(GrupoIdnumericUpDown.Value);
            Grupos grupo = BLL.GruposBLL.Buscar(id);

            if (grupo != null)
            {
                GrupoIdnumericUpDown.Value = grupo.GrupoId;
                descripcionTextBox.Text = grupo.Descripcion;
                CantidadnumericUpDown.Value = grupo.Cantidad;
                GDeseadosnumericUpDown.Value = grupo.GruposDeseados;
            }
            else
                MessageBox.Show("No se encontro!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            GeneralerrorProvider.Clear();
            LimpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar(2))
            {
                MessageBox.Show("LLenar los campos marcados");
                return;
            }

            GeneralerrorProvider.Clear();

            if (GrupoIdnumericUpDown.Value == 0)
            {
                if (BLL.GruposBLL.Guardar(LlenaClase()))
                {
                    MessageBox.Show("Guardado!!", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
            }
            else
            {
                if (BLL.GruposBLL.Modificar(LlenaClase()))
                {
                    MessageBox.Show("Guardado!!", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo Guardar!!", "Fallo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            GeneralerrorProvider.Clear();

            if (Validar(1))
            {
                MessageBox.Show("Ingresar un ID");
                return;
            }

            int id = Convert.ToInt32(GrupoIdnumericUpDown.Value);

            if (BLL.GruposBLL.Eliminar(id))
                MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            LimpiarCampos();
        }
    }
}
