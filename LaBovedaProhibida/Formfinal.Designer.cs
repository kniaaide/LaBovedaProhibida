namespace LaBovedaProhibida
{
    partial class FormFinal
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
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnJugarOtraVez = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblResultado.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold);
            this.lblResultado.ForeColor = System.Drawing.Color.Lime;
            this.lblResultado.Location = new System.Drawing.Point(40, 40);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(380, 40);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = ">> BOVEDA HACKEADA <<";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            
            this.lblNombre.Font = new System.Drawing.Font("Courier New", 11F);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(100, 100);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(280, 25);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Hacker: ";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblPuntaje.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.lblPuntaje.ForeColor = System.Drawing.Color.Yellow;
            this.lblPuntaje.Location = new System.Drawing.Point(80, 135);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(300, 30);
            this.lblPuntaje.TabIndex = 2;
            this.lblPuntaje.Text = "Puntaje final: 0 pts";
            this.lblPuntaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblMensaje.Font = new System.Drawing.Font("Courier New", 9F);
            this.lblMensaje.ForeColor = System.Drawing.Color.Gray;
            this.lblMensaje.Location = new System.Drawing.Point(40, 180);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(380, 30);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.Text = "";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

           
            this.btnJugarOtraVez.BackColor = System.Drawing.Color.DarkGreen;
            this.btnJugarOtraVez.Font = new System.Drawing.Font("Courier New", 8F);
            this.btnJugarOtraVez.ForeColor = System.Drawing.Color.White;
            this.btnJugarOtraVez.Location = new System.Drawing.Point(80, 235);
            this.btnJugarOtraVez.Name = "btnJugarOtraVez";
            this.btnJugarOtraVez.Size = new System.Drawing.Size(130, 35);
            this.btnJugarOtraVez.TabIndex = 4;
            this.btnJugarOtraVez.Text = "Jugar de nuevo";
            this.btnJugarOtraVez.UseVisualStyleBackColor = false;
            this.btnJugarOtraVez.Click += new System.EventHandler(this.BtnJugarOtraVez_Click);

        
            this.btnSalir.BackColor = System.Drawing.Color.DarkRed;
            this.btnSalir.Font = new System.Drawing.Font("Courier New", 8F);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(240, 235);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 35);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);

         
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(460, 320);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnJugarOtraVez);
            this.Controls.Add(this.btnSalir);
            this.Name = "FormFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultado Final";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnJugarOtraVez;
        private System.Windows.Forms.Button btnSalir;
    }
}