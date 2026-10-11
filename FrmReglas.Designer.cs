namespace CreadorPersonajes
{
    partial class FrmReglas
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
            lblTextoReglas = new Label();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // lblTextoReglas
            // 
            lblTextoReglas.BackColor = Color.White;
            lblTextoReglas.Location = new Point(20, 20);
            lblTextoReglas.Name = "lblTextoReglas";
            lblTextoReglas.Size = new Size(420, 300);
            lblTextoReglas.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(160, 340);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(100, 35);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmReglas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 450);
            Controls.Add(btnCerrar);
            Controls.Add(lblTextoReglas);
            Name = "FrmReglas";
            Text = "Reglas del Juego";
            ResumeLayout(false);
        }

        #endregion
        private Label lblTextoReglas;
        private Button btnCerrar;
    }
}