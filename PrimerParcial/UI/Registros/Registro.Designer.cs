namespace PrimerParcial.UI.Registros
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label grupoIdLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label gruposDeseadosLabel;
            System.Windows.Forms.Label integrantesLabel;
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTime = new System.Windows.Forms.DateTimePicker();
            this.GrupoIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CantidadnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.GDeseadosnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.GeneralerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.IntegrantesTextBox = new System.Windows.Forms.TextBox();
            this.gruposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            grupoIdLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            gruposDeseadosLabel = new System.Windows.Forms.Label();
            integrantesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrupoIdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GDeseadosnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grupoIdLabel
            // 
            grupoIdLabel.AutoSize = true;
            grupoIdLabel.Location = new System.Drawing.Point(21, 37);
            grupoIdLabel.Name = "grupoIdLabel";
            grupoIdLabel.Size = new System.Drawing.Size(51, 13);
            grupoIdLabel.TabIndex = 5;
            grupoIdLabel.Text = "Grupo Id:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(21, 112);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 7;
            descripcionLabel.Text = "Descripcion:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(21, 72);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 9;
            fechaLabel.Text = "Fecha:";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(21, 193);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(52, 13);
            cantidadLabel.TabIndex = 11;
            cantidadLabel.Text = "Cantidad:";
            // 
            // gruposDeseadosLabel
            // 
            gruposDeseadosLabel.AutoSize = true;
            gruposDeseadosLabel.Location = new System.Drawing.Point(21, 227);
            gruposDeseadosLabel.Name = "gruposDeseadosLabel";
            gruposDeseadosLabel.Size = new System.Drawing.Size(95, 13);
            gruposDeseadosLabel.TabIndex = 13;
            gruposDeseadosLabel.Text = "Grupos Deseados:";
            // 
            // integrantesLabel
            // 
            integrantesLabel.AutoSize = true;
            integrantesLabel.Location = new System.Drawing.Point(21, 263);
            integrantesLabel.Name = "integrantesLabel";
            integrantesLabel.Size = new System.Drawing.Size(63, 13);
            integrantesLabel.TabIndex = 17;
            integrantesLabel.Text = "Integrantes:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::PrimerParcial.Properties.Resources.icons8_Search_16;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(212, 37);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(65, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::PrimerParcial.Properties.Resources.icons8_Delete_32;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(322, 327);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(106, 55);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::PrimerParcial.Properties.Resources.icons8_Save_Close_32;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(171, 327);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(106, 55);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::PrimerParcial.Properties.Resources.icons8_Add_Property_32;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.Location = new System.Drawing.Point(12, 327);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(106, 55);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gruposBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(93, 109);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(143, 61);
            this.descripcionTextBox.TabIndex = 8;
            // 
            // fechaDateTime
            // 
            this.fechaDateTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.gruposBindingSource, "Fecha", true));
            this.fechaDateTime.Location = new System.Drawing.Point(93, 68);
            this.fechaDateTime.Name = "fechaDateTime";
            this.fechaDateTime.Size = new System.Drawing.Size(143, 20);
            this.fechaDateTime.TabIndex = 10;
            // 
            // GrupoIdnumericUpDown
            // 
            this.GrupoIdnumericUpDown.Location = new System.Drawing.Point(93, 37);
            this.GrupoIdnumericUpDown.Name = "GrupoIdnumericUpDown";
            this.GrupoIdnumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.GrupoIdnumericUpDown.TabIndex = 15;
            // 
            // CantidadnumericUpDown
            // 
            this.CantidadnumericUpDown.Location = new System.Drawing.Point(136, 185);
            this.CantidadnumericUpDown.Name = "CantidadnumericUpDown";
            this.CantidadnumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.CantidadnumericUpDown.TabIndex = 16;
            this.CantidadnumericUpDown.ValueChanged += new System.EventHandler(this.CantidadnumericUpDown_ValueChanged);
            // 
            // GDeseadosnumericUpDown
            // 
            this.GDeseadosnumericUpDown.Location = new System.Drawing.Point(136, 225);
            this.GDeseadosnumericUpDown.Name = "GDeseadosnumericUpDown";
            this.GDeseadosnumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.GDeseadosnumericUpDown.TabIndex = 17;
            this.GDeseadosnumericUpDown.ValueChanged += new System.EventHandler(this.GDeseadosnumericUpDown_ValueChanged);
            // 
            // GeneralerrorProvider
            // 
            this.GeneralerrorProvider.ContainerControl = this;
            // 
            // IntegrantesTextBox
            // 
            this.IntegrantesTextBox.Location = new System.Drawing.Point(136, 263);
            this.IntegrantesTextBox.Name = "IntegrantesTextBox";
            this.IntegrantesTextBox.ReadOnly = true;
            this.IntegrantesTextBox.Size = new System.Drawing.Size(100, 20);
            this.IntegrantesTextBox.TabIndex = 18;
            this.IntegrantesTextBox.TextChanged += new System.EventHandler(this.IntegrantesTextBox_TextChanged);
            // 
            // gruposBindingSource
            // 
            this.gruposBindingSource.DataSource = typeof(PrimerParcial.Entidades.Grupos);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 402);
            this.Controls.Add(this.IntegrantesTextBox);
            this.Controls.Add(integrantesLabel);
            this.Controls.Add(this.GDeseadosnumericUpDown);
            this.Controls.Add(this.CantidadnumericUpDown);
            this.Controls.Add(this.GrupoIdnumericUpDown);
            this.Controls.Add(gruposDeseadosLabel);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTime);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(grupoIdLabel);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrupoIdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GDeseadosnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.BindingSource gruposBindingSource;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTime;
        private System.Windows.Forms.NumericUpDown GrupoIdnumericUpDown;
        private System.Windows.Forms.NumericUpDown CantidadnumericUpDown;
        private System.Windows.Forms.NumericUpDown GDeseadosnumericUpDown;
        private System.Windows.Forms.ErrorProvider GeneralerrorProvider;
        private System.Windows.Forms.TextBox IntegrantesTextBox;
    }
}