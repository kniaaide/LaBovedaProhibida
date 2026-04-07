namespace LaBovedaProhibida
{
    partial class FormInicio
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
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            btnJugar = new Button();
            btnRecords = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Courier New", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Lime;
            lblTitulo.Location = new Point(40, 40);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(380, 35);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "LA BOVEDA PROHIBIDA";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Font = new Font("Courier New", 9F);
            lblSubtitulo.ForeColor = Color.Gray;
            lblSubtitulo.Location = new Point(30, 85);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(390, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Hackea los 5 sistemas de seguridad ";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            lblNombre.Font = new Font("Courier New", 10F);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(80, 140);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(200, 25);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre del hacker:";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.DarkGreen;
            txtNombre.Font = new Font("Courier New", 11F);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(80, 170);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(280, 28);
            txtNombre.TabIndex = 3;
            // 
            // btnJugar
            // 
            btnJugar.BackColor = Color.DarkRed;
            btnJugar.Font = new Font("Courier New", 10F, FontStyle.Bold);
            btnJugar.ForeColor = Color.White;
            btnJugar.Location = new Point(80, 220);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(280, 40);
            btnJugar.TabIndex = 4;
            btnJugar.Text = ">> INICIAR INFILTRACION <<";
            btnJugar.UseVisualStyleBackColor = false;
            btnJugar.Click += BtnJugar_Click;
            // 
            // btnRecords
            // 
            btnRecords.BackColor = Color.DarkBlue;
            btnRecords.Font = new Font("Courier New", 8F);
            btnRecords.ForeColor = Color.White;
            btnRecords.Location = new Point(160, 270);
            btnRecords.Name = "btnRecords";
            btnRecords.Size = new Size(120, 30);
            btnRecords.TabIndex = 5;
            btnRecords.Text = "Ver Records";
            btnRecords.UseVisualStyleBackColor = false;
            btnRecords.Click += BtnRecords_Click;
            // 
            // FormInicio
            // 
            BackColor = Color.Black;
            ClientSize = new Size(450, 320);
            Controls.Add(lblTitulo);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(btnJugar);
            Controls.Add(btnRecords);
            Name = "FormInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "La Boveda Prohibida";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnRecords;
    }
}