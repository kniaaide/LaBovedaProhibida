namespace LaBovedaProhibida
{
    partial class FormPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.lblIntentos = new System.Windows.Forms.Label();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnPista = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblTitulo.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Lime;
            this.lblTitulo.Location = new System.Drawing.Point(80, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(450, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = ">> LA BOVEDA PROHIBIDA <<";

            this.lblNivel.Font = new System.Drawing.Font("Courier New", 10F);
            this.lblNivel.ForeColor = System.Drawing.Color.Yellow;
            this.lblNivel.Location = new System.Drawing.Point(20, 55);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(200, 20);
            this.lblNivel.TabIndex = 1;
            this.lblNivel.Text = "Sistema: 1 / 5";

            this.lblPuntaje.Font = new System.Drawing.Font("Courier New", 10F);
            this.lblPuntaje.ForeColor = System.Drawing.Color.Cyan;
            this.lblPuntaje.Location = new System.Drawing.Point(200, 55);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(200, 20);
            this.lblPuntaje.TabIndex = 2;
            this.lblPuntaje.Text = "Puntaje: 0";

            this.lblTimer.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.lblTimer.ForeColor = System.Drawing.Color.Red;
            this.lblTimer.Location = new System.Drawing.Point(400, 55);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(150, 20);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "Tiempo: 60s";

            this.lblPregunta.Font = new System.Drawing.Font("Courier New", 10F);
            this.lblPregunta.ForeColor = System.Drawing.Color.White;
            this.lblPregunta.Location = new System.Drawing.Point(20, 90);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(550, 180);
            this.lblPregunta.TabIndex = 4;
            this.lblPregunta.Text = "";

            this.lblIntentos.Font = new System.Drawing.Font("Courier New", 10F);
            this.lblIntentos.ForeColor = System.Drawing.Color.Orange;
            this.lblIntentos.Location = new System.Drawing.Point(20, 280);
            this.lblIntentos.Name = "lblIntentos";
            this.lblIntentos.Size = new System.Drawing.Size(300, 20);
            this.lblIntentos.TabIndex = 5;
            this.lblIntentos.Text = "Intentos restantes: 3";

            this.txtRespuesta.BackColor = System.Drawing.Color.DarkGreen;
            this.txtRespuesta.Font = new System.Drawing.Font("Courier New", 11F);
            this.txtRespuesta.ForeColor = System.Drawing.Color.White;
            this.txtRespuesta.Location = new System.Drawing.Point(20, 315);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(350, 30);
            this.txtRespuesta.TabIndex = 6;

            this.btnValidar.BackColor = System.Drawing.Color.DarkRed;
            this.btnValidar.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold);
            this.btnValidar.ForeColor = System.Drawing.Color.White;
            this.btnValidar.Location = new System.Drawing.Point(385, 313);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(100, 35);
            this.btnValidar.TabIndex = 7;
            this.btnValidar.Text = "HACKEAR";
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.BtnValidar_Click);

            this.btnPista.BackColor = System.Drawing.Color.DarkBlue;
            this.btnPista.Font = new System.Drawing.Font("Courier New", 8F);
            this.btnPista.ForeColor = System.Drawing.Color.White;
            this.btnPista.Location = new System.Drawing.Point(20, 365);
            this.btnPista.Name = "btnPista";
            this.btnPista.Size = new System.Drawing.Size(150, 30);
            this.btnPista.TabIndex = 8;
            this.btnPista.Text = "PISTA (-20pts)";
            this.btnPista.UseVisualStyleBackColor = false;
            this.btnPista.Click += new System.EventHandler(this.BtnPista_Click);

            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 470);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.lblIntentos);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.btnPista);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "La Boveda Prohibida";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Label lblIntentos;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Button btnPista;
    }
}