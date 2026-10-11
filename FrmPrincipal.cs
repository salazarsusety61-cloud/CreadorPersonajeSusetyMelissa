using System;
using System.Windows.Forms;

namespace CreadorPersonajes
{
    public partial class FrmPrincipal : Form
    {
        private const int PUNTOS_TOTALES = 20;

        public FrmPrincipal()
        {
            InitializeComponent();

            cboClase.Items.AddRange(new string[]
            {
                "Guardián del Volcán",
                "Sabio de la Bruma",
                "Centinela de la Selva",
                "Custodio de las Aguas"
            });

            cboClase.SelectedIndex = 0;
            this.CancelButton = btnCerrar;
            ActualizarPuntos();
        }

        private void ActualizarPuntos()
        {
            int usados = (int)(nudFuerza.Value + nudAgilidad.Value +
                              nudInteligencia.Value + nudResistencia.Value) - 4;
            lblPuntos.Text = $"Puntos restantes: {PUNTOS_TOTALES - usados}";
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Escribe un nombre para el personaje.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int usadosTotales = (int)(nudFuerza.Value + nudAgilidad.Value +
                                      nudInteligencia.Value + nudResistencia.Value) - 4;
            if (usadosTotales > PUNTOS_TOTALES)
            {
                MessageBox.Show("Te pasaste de los 20 puntos permitidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int f = (int)nudFuerza.Value;
            int a = (int)nudAgilidad.Value;
            int i = (int)nudInteligencia.Value;
            int r = (int)nudResistencia.Value;
            string clase = cboClase.SelectedItem.ToString();
            string atrPrincipal = "";

            switch (clase)
            {
                case "Guardián del Volcán":
                    f += 5; r += 3; atrPrincipal = "Fuerza";
                    break;
                case "Sabio de la Bruma":
                    a += 2; i += 6; atrPrincipal = "Inteligencia";
                    break;
                case "Centinela de la Selva":
                    f += 2; a += 5; i += 1; atrPrincipal = "Agilidad";
                    break;
                case "Custodio de las Aguas":
                    i += 4; r += 4; atrPrincipal = "Inteligencia";
                    break;
            }

            int nivel = 1;
            int vida = 50 + r * 10 + nivel * 5;
            int ataque = 0;

            if (atrPrincipal == "Fuerza") ataque = f * 3 + nivel * 2;
            if (atrPrincipal == "Agilidad") ataque = a * 3 + nivel * 2;
            if (atrPrincipal == "Inteligencia") ataque = i * 3 + nivel * 2;

            int defensa = r * 2 + a;
            int poder = vida / 10 + ataque + defensa;
            string rango = poder < 60 ? "Novato" :
                           poder < 100 ? "Veterano" :
                           poder < 150 ? "Élite" : "Legendario";

            lblResultado.Text = $"{txtNombre.Text}\n" +
                                $"Clase: {clase}\n" +
                                $"Nivel: {nivel} | Rango: {rango}\n" +
                                $"Vida: {vida} | Ataque: {ataque} | Defensa: {defensa}\n" +
                                $"Poder: {poder}";
        }

        private void btnReglas_Click(object sender, EventArgs e)
        {
            FrmReglas vr = new FrmReglas();
            vr.ShowDialog();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            nudFuerza.Value = 1;
            nudAgilidad.Value = 1;
            nudInteligencia.Value = 1;
            nudResistencia.Value = 1;
            cboClase.SelectedIndex = 0;
            lblResultado.Text = "Personaje creado...";
            ActualizarPuntos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nudFuerza_ValueChanged(object sender, EventArgs e) => ActualizarPuntos();
        private void nudAgilidad_ValueChanged(object sender, EventArgs e) => ActualizarPuntos();
        private void nudInteligencia_ValueChanged(object sender, EventArgs e) => ActualizarPuntos();
        private void nudResistencia_ValueChanged(object sender, EventArgs e) => ActualizarPuntos();

        private void nudAgilidad_Click(object sender, EventArgs e)
        {

        }

        private void nudInteligencia_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void nudResistencia_ValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}