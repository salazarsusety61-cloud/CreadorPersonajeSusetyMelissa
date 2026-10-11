namespace CreadorPersonajes
{
    partial class FrmPrincipal
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblClase = new Label();
            cboClase = new ComboBox();
            lblFuerza = new Label();
            nudFuerza = new NumericUpDown();
            lblAgilidad = new Label();
            nudAgilidad = new NumericUpDown();
            lblInteligencia = new Label();
            nudInteligencia = new NumericUpDown();
            lblResistencia = new Label();
            nudResistencia = new NumericUpDown();
            lblPuntos = new Label();
            lblResultado = new Label();
            btnCrear = new Button();
            btnReglas = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            lblTextoReglas = new Label();
            ((System.ComponentModel.ISupportInitialize)nudFuerza).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAgilidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudInteligencia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudResistencia).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(16, 24);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(161, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre del personaje:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(190, 24);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 1;
            // 
            // lblClase
            // 
            lblClase.AutoSize = true;
            lblClase.Location = new Point(16, 70);
            lblClase.Name = "lblClase";
            lblClase.Size = new Size(47, 20);
            lblClase.TabIndex = 2;
            lblClase.Text = "Clase:";
            // 
            // cboClase
            // 
            cboClase.FormattingEnabled = true;
            cboClase.Location = new Point(71, 70);
            cboClase.Name = "cboClase";
            cboClase.Size = new Size(208, 28);
            cboClase.TabIndex = 3;
            // 
            // lblFuerza
            // 
            lblFuerza.AutoSize = true;
            lblFuerza.Location = new Point(16, 125);
            lblFuerza.Name = "lblFuerza";
            lblFuerza.Size = new Size(55, 20);
            lblFuerza.TabIndex = 4;
            lblFuerza.Text = "Fuerza:";
            // 
            // nudFuerza
            // 
            nudFuerza.Location = new Point(71, 126);
            nudFuerza.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudFuerza.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudFuerza.Name = "nudFuerza";
            nudFuerza.Size = new Size(150, 27);
            nudFuerza.TabIndex = 5;
            nudFuerza.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudFuerza.Click += nudFuerza_ValueChanged;
            // 
            // lblAgilidad
            // 
            lblAgilidad.AutoSize = true;
            lblAgilidad.Location = new Point(19, 176);
            lblAgilidad.Name = "lblAgilidad";
            lblAgilidad.Size = new Size(69, 20);
            lblAgilidad.TabIndex = 6;
            lblAgilidad.Text = "Agilidad:";
            // 
            // nudAgilidad
            // 
            nudAgilidad.Location = new Point(91, 175);
            nudAgilidad.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudAgilidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAgilidad.Name = "nudAgilidad";
            nudAgilidad.Size = new Size(150, 27);
            nudAgilidad.TabIndex = 7;
            nudAgilidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudAgilidad.ValueChanged += nudAgilidad_ValueChanged;
            nudAgilidad.Click += nudAgilidad_Click;
            // 
            // lblInteligencia
            // 
            lblInteligencia.AutoSize = true;
            lblInteligencia.Location = new Point(17, 230);
            lblInteligencia.Name = "lblInteligencia";
            lblInteligencia.Size = new Size(89, 20);
            lblInteligencia.TabIndex = 8;
            lblInteligencia.Text = "Inteligencia:";
            // 
            // nudInteligencia
            // 
            nudInteligencia.Location = new Point(106, 229);
            nudInteligencia.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudInteligencia.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudInteligencia.Name = "nudInteligencia";
            nudInteligencia.Size = new Size(150, 27);
            nudInteligencia.TabIndex = 9;
            nudInteligencia.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudInteligencia.ValueChanged += nudInteligencia_ValueChanged;
            // 
            // lblResistencia
            // 
            lblResistencia.AutoSize = true;
            lblResistencia.Location = new Point(15, 277);
            lblResistencia.Name = "lblResistencia";
            lblResistencia.Size = new Size(85, 20);
            lblResistencia.TabIndex = 10;
            lblResistencia.Text = "Resistencia:";
            // 
            // nudResistencia
            // 
            nudResistencia.Location = new Point(102, 279);
            nudResistencia.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudResistencia.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudResistencia.Name = "nudResistencia";
            nudResistencia.Size = new Size(150, 27);
            nudResistencia.TabIndex = 11;
            nudResistencia.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudResistencia.ValueChanged += nudResistencia_ValueChanged;
            // 
            // lblPuntos
            // 
            lblPuntos.AutoSize = true;
            lblPuntos.Location = new Point(21, 325);
            lblPuntos.Name = "lblPuntos";
            lblPuntos.Size = new Size(139, 20);
            lblPuntos.TabIndex = 12;
            lblPuntos.Text = "Puntos restantes: 20";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(14, 367);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(125, 20);
            lblResultado.TabIndex = 13;
            lblResultado.Text = "Personaje creado.";
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(24, 545);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(94, 29);
            btnCrear.TabIndex = 14;
            btnCrear.Text = "Crear Personaje";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnReglas
            // 
            btnReglas.Location = new Point(123, 545);
            btnReglas.Name = "btnReglas";
            btnReglas.Size = new Size(94, 29);
            btnReglas.TabIndex = 15;
            btnReglas.Text = "Ver Reglas";
            btnReglas.UseVisualStyleBackColor = true;
            btnReglas.Click += btnReglas_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(221, 545);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(325, 546);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 29);
            btnCerrar.TabIndex = 17;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblTextoReglas
            // 
            lblTextoReglas.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTextoReglas.Location = new Point(426, 24);
            lblTextoReglas.Name = "lblTextoReglas";
            lblTextoReglas.Size = new Size(450, 350);
            lblTextoReglas.TabIndex = 18;
            lblTextoReglas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 641);
            Controls.Add(lblTextoReglas);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnReglas);
            Controls.Add(btnCrear);
            Controls.Add(lblResultado);
            Controls.Add(lblPuntos);
            Controls.Add(nudResistencia);
            Controls.Add(lblResistencia);
            Controls.Add(nudInteligencia);
            Controls.Add(lblInteligencia);
            Controls.Add(nudAgilidad);
            Controls.Add(lblAgilidad);
            Controls.Add(nudFuerza);
            Controls.Add(lblFuerza);
            Controls.Add(cboClase);
            Controls.Add(lblClase);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "FrmPrincipal";
            Text = "Creador de Personaje";
            ((System.ComponentModel.ISupportInitialize)nudFuerza).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAgilidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudInteligencia).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudResistencia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblClase;
        private ComboBox cboClase;
        private Label lblFuerza;
        private NumericUpDown nudFuerza;
        private Label lblAgilidad;
        private NumericUpDown nudAgilidad;
        private Label lblInteligencia;
        private NumericUpDown nudInteligencia;
        private Label lblResistencia;
        private NumericUpDown nudResistencia;
        private Label lblPuntos;
        private Label lblResultado;
        private Button btnCrear;
        private Button btnReglas;
        private Button btnLimpiar;
        private Button btnCerrar;
        private Label lblTextoReglas;
    }
}
