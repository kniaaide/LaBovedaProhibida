using LaBovedaProhibida.Modelos;

namespace LaBovedaProhibida
{
    public partial class FormPrincipal : Form
    {
        private GestorNiveles gestor;
        private GestorArchivos archivos;
        private System.Windows.Forms.Timer timer;

        private int puntaje = 0;
        private int segundosRestantes = 60;
        private string nombreJugador = "";

        public FormPrincipal(string nombre)
        {
            nombreJugador = nombre;
            gestor = new GestorNiveles();
            archivos = new GestorArchivos();
            InitializeComponent();
            IniciarTimer();
            MostrarAcertijo();
        }

        private void IniciarTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            segundosRestantes--;
            lblTimer.Text = $"Tiempo: {segundosRestantes}s";

            if (segundosRestantes <= 0)
            {
                timer.Stop();
                MessageBox.Show("Se acabo el tiempo! El banco activo las alarmas...");
                TerminarJuego();
            }
        }

        private void MostrarAcertijo()
        {
            Acertijo acertijo = gestor.ObtenerAcertijoActual();
            lblNivel.Text = $"Sistema: {gestor.NivelActual + 1} / {gestor.TotalNiveles}";
            lblPregunta.Text = acertijo.Pregunta;
            lblIntentos.Text = $"Intentos restantes: {acertijo.Intentos}";
            lblPuntaje.Text = $"Puntaje: {puntaje}";
            txtRespuesta.Clear();
            txtRespuesta.Focus();
            segundosRestantes = 60;
        }

        private void BtnValidar_Click(object sender, EventArgs e)
        {
            Acertijo acertijo = gestor.ObtenerAcertijoActual();
            string respuesta = txtRespuesta.Text;

            if (respuesta == "")
            {
                MessageBox.Show("Debes escribir una respuesta!");
                return;
            }

            if (acertijo.ValidarRespuesta(respuesta))
            {
                puntaje += 100 + (acertijo.Intentos * 10) + segundosRestantes;
                MessageBox.Show("ACCESO CONCEDIDO >> Sistema vulnerado!");
                gestor.AvanzarNivel();

                if (gestor.JuegoTerminado())
                {
                    timer.Stop();
                    TerminarJuego();
                }
                else
                {
                    MostrarAcertijo();
                }
            }
            else
            {
                acertijo.Intentos--;
                lblIntentos.Text = $"Intentos restantes: {acertijo.Intentos}";

                if (acertijo.Intentos <= 0)
                {
                    timer.Stop();
                    MessageBox.Show("Sin intentos. El sistema te bloqueo.");
                    TerminarJuego();
                }
                else
                {
                    MessageBox.Show($"ACCESO DENEGADO. Intentos restantes: {acertijo.Intentos}");
                }
            }
        }

        private void BtnPista_Click(object sender, EventArgs e)
        {
            Acertijo acertijo = gestor.ObtenerAcertijoActual();
            puntaje -= 20;
            if (puntaje < 0) puntaje = 0;
            lblPuntaje.Text = $"Puntaje: {puntaje}";
            MessageBox.Show("PISTA: " + acertijo.Pista);
        }

        private void TerminarJuego()
        {
            archivos.GuardarRecord(nombreJugador, puntaje);
            FormFinal formFinal = new FormFinal(nombreJugador, puntaje, gestor.JuegoTerminado());
            formFinal.Show();
            this.Close();
        }
    }
}