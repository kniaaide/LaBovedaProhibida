namespace LaBovedaProhibida
{
    public partial class FormFinal : Form
    {
        public FormFinal(string nombre, int puntaje, bool gano)
        {
            InitializeComponent();

            // seteamos los textos segun el resultado
            lblNombre.Text = $"Hacker: {nombre}";
            lblPuntaje.Text = $"Puntaje final: {puntaje} pts";

            if (gano)
            {
                lblResultado.Text = ">> BOVEDA HACKEADA <<";
                lblResultado.ForeColor = Color.Lime;
            }
            else
            {
                lblResultado.Text = ">> ACCESO BLOQUEADO <<";
                lblResultado.ForeColor = Color.Red;
            }

            if (puntaje >= 400)
                lblMensaje.Text = "Eres un hacker de nivel elite";
            else if (puntaje >= 200)
                lblMensaje.Text = "Buen trabajo, pero puedes mejorar";
            else
                lblMensaje.Text = "Necesitas practicar mas";
        }

        private void BtnJugarOtraVez_Click(object sender, EventArgs e)
        {
            FormInicio inicio = new FormInicio();
            inicio.Show();
            this.Close();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}