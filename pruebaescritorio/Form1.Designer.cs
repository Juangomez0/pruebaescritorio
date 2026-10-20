namespace pruebaescritorio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textNombre = new TextBox();
            Labeledad = new Label();
            textEdad = new TextBox();
            BotonGuardar = new Button();
            BotonLimpiar = new Button();
            GridDatos = new DataGridView();
            botonCerrar = new Button();
            grupoEntradDatos = new GroupBox();
            textCorreo = new TextBox();
            labelCorreo = new Label();
            grupoDatos = new GroupBox();
            textDireccion = new TextBox();
            lblDireccion = new Label();
            ((System.ComponentModel.ISupportInitialize)GridDatos).BeginInit();
            grupoEntradDatos.SuspendLayout();
            grupoDatos.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 48);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(99, 45);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(522, 31);
            textNombre.TabIndex = 1;
            textNombre.KeyPress += textNombre_KeyPress;
            // 
            // Labeledad
            // 
            Labeledad.AutoSize = true;
            Labeledad.Location = new Point(15, 98);
            Labeledad.Name = "Labeledad";
            Labeledad.Size = new Size(52, 25);
            Labeledad.TabIndex = 2;
            Labeledad.Text = "Edad";
            Labeledad.UseMnemonic = false;
            // 
            // textEdad
            // 
            textEdad.Location = new Point(99, 98);
            textEdad.Name = "textEdad";
            textEdad.Size = new Size(150, 31);
            textEdad.TabIndex = 3;
            textEdad.KeyPress += textEdad_KeyPress;
            // 
            // BotonGuardar
            // 
            BotonGuardar.Location = new Point(707, 27);
            BotonGuardar.Name = "BotonGuardar";
            BotonGuardar.Size = new Size(112, 34);
            BotonGuardar.TabIndex = 4;
            BotonGuardar.Text = "&Guardar";
            BotonGuardar.UseVisualStyleBackColor = true;
            BotonGuardar.Click += BotonGuardar_Click;
            // 
            // BotonLimpiar
            // 
            BotonLimpiar.Location = new Point(707, 80);
            BotonLimpiar.Name = "BotonLimpiar";
            BotonLimpiar.Size = new Size(112, 34);
            BotonLimpiar.TabIndex = 5;
            BotonLimpiar.Text = "&Limpiar";
            BotonLimpiar.UseVisualStyleBackColor = true;
            BotonLimpiar.Click += BotonLimpiar_Click;
            // 
            // GridDatos
            // 
            GridDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridDatos.Dock = DockStyle.Fill;
            GridDatos.Location = new Point(3, 27);
            GridDatos.Name = "GridDatos";
            GridDatos.RowHeadersWidth = 62;
            GridDatos.Size = new Size(1119, 468);
            GridDatos.TabIndex = 6;
            // 
            // botonCerrar
            // 
            botonCerrar.Location = new Point(707, 137);
            botonCerrar.Name = "botonCerrar";
            botonCerrar.Size = new Size(112, 34);
            botonCerrar.TabIndex = 7;
            botonCerrar.Text = "Cerrar";
            botonCerrar.UseVisualStyleBackColor = true;
            botonCerrar.Click += botonCerrar_Click;
            // 
            // grupoEntradDatos
            // 
            grupoEntradDatos.Controls.Add(textDireccion);
            grupoEntradDatos.Controls.Add(lblDireccion);
            grupoEntradDatos.Controls.Add(textCorreo);
            grupoEntradDatos.Controls.Add(labelCorreo);
            grupoEntradDatos.Controls.Add(botonCerrar);
            grupoEntradDatos.Controls.Add(BotonLimpiar);
            grupoEntradDatos.Controls.Add(textNombre);
            grupoEntradDatos.Controls.Add(label1);
            grupoEntradDatos.Controls.Add(textEdad);
            grupoEntradDatos.Controls.Add(Labeledad);
            grupoEntradDatos.Controls.Add(BotonGuardar);
            grupoEntradDatos.Dock = DockStyle.Top;
            grupoEntradDatos.Location = new Point(0, 0);
            grupoEntradDatos.Name = "grupoEntradDatos";
            grupoEntradDatos.Size = new Size(1125, 266);
            grupoEntradDatos.TabIndex = 8;
            grupoEntradDatos.TabStop = false;
            grupoEntradDatos.Text = "Ingrese los datos";
            // 
            // textCorreo
            // 
            textCorreo.Location = new Point(99, 155);
            textCorreo.Name = "textCorreo";
            textCorreo.Size = new Size(368, 31);
            textCorreo.TabIndex = 9;
            textCorreo.KeyPress += textCorreo_KeyPress;
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.Location = new Point(15, 155);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(66, 25);
            labelCorreo.TabIndex = 8;
            labelCorreo.Text = "Correo";
            // 
            // grupoDatos
            // 
            grupoDatos.Controls.Add(GridDatos);
            grupoDatos.Dock = DockStyle.Fill;
            grupoDatos.Location = new Point(0, 266);
            grupoDatos.Name = "grupoDatos";
            grupoDatos.Size = new Size(1125, 498);
            grupoDatos.TabIndex = 9;
            grupoDatos.TabStop = false;
            grupoDatos.Text = "Datos registrados";
            // 
            // textDireccion
            // 
            textDireccion.Location = new Point(106, 212);
            textDireccion.Name = "textDireccion";
            textDireccion.Size = new Size(368, 31);
            textDireccion.TabIndex = 11;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(15, 215);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(85, 25);
            lblDireccion.TabIndex = 10;
            lblDireccion.Text = "Dirección";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 764);
            Controls.Add(grupoDatos);
            Controls.Add(grupoEntradDatos);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)GridDatos).EndInit();
            grupoEntradDatos.ResumeLayout(false);
            grupoEntradDatos.PerformLayout();
            grupoDatos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textNombre;
        private Label Labeledad;
        private TextBox textEdad;
        private Button BotonGuardar;
        private Button BotonLimpiar;
        private DataGridView GridDatos;
        private Button botonCerrar;
        private GroupBox grupoEntradDatos;
        private GroupBox grupoDatos;
        private Label labelCorreo;
        private TextBox textCorreo;
        private TextBox textDireccion;
        private Label lblDireccion;
    }
}
