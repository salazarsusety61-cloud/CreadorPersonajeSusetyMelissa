using System;
using System.Windows.Forms;

namespace CreadorPersonajes
{
    public partial class FrmReglas : Form
    {
        public FrmReglas()
        {
            InitializeComponent();

            lblTextoReglas.Text = @"REGLAS DEL JUEGO — Guardianes del Talamanca

--- CLASES Y BONIFICACIONES ---
Guardián del Volcán:   Fuerza +5, Resistencia +3 | Principal: Fuerza
Sabio de la Bruma:     Agilidad +2, Inteligencia +6 | Principal: Inteligencia
Centinela de la Selva: Fuerza +2, Agilidad +5, Inteligencia +1 | Principal: Agilidad
Custodio de las Aguas: Inteligencia +4, Resistencia +4 | Principal: Inteligencia

--- ATRIBUTOS ---
Reparte exactamente 20 puntos, 1 mínimo y 10 máximo por atributo.

--- FÓRMULAS ---
Nivel = experiencia / 1000 + 1
Vida = 50 + Resistencia * 10 + Nivel * 5
Ataque = AtributoPrincipal * 3 + Nivel * 2
Defensa = Resistencia * 2 + Agilidad
Poder = Vida / 10 + Ataque + Defensa

--- RANGOS ---
< 60 → Novato
60–99 → Veterano
100–149 → Élite
>= 150 → Legendario";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}