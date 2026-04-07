namespace LaBovedaProhibida
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void BtnJugar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Escribe tu nombre para continuar");
                return;
            }

            FormPrincipal juego = new FormPrincipal(txtNombre.Text.Trim());
            juego.Show();
            this.Hide();
        }

        private void BtnRecords_Click(object sender, EventArgs e)
        {
            GestorArchivos archivos = new GestorArchivos();
            List<string> records = archivos.ObtenerRecords();

            if (records.Count == 0)
            {
                MessageBox.Show("No hay records todavia. Se el primero!");
                return;
            }

            string mensaje = "=== TABLA DE RECORDS ===\n\n";
            foreach (string record in records)
            {
                string[] partes = record.Split(',');
                mensaje += $"{partes[0]} - {partes[1]} pts - {partes[2]}\n";
            }

            MessageBox.Show(mensaje);
        }
    }
}