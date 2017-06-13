namespace Reproducor_Mp3
{
    partial class FrmReproductor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReproductor));
            this.Reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.listBoxCanciones = new System.Windows.Forms.ListBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnDesplegarBiblioteca = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).BeginInit();
            this.SuspendLayout();
            // 
            // Reproductor
            // 
            this.Reproductor.Enabled = true;
            this.Reproductor.Location = new System.Drawing.Point(122, 30);
            this.Reproductor.Name = "Reproductor";
            this.Reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reproductor.OcxState")));
            this.Reproductor.Size = new System.Drawing.Size(583, 50);
            this.Reproductor.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(142, 108);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(152, 80);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Cargar Archivos";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // listBoxCanciones
            // 
            this.listBoxCanciones.FormattingEnabled = true;
            this.listBoxCanciones.ItemHeight = 16;
            this.listBoxCanciones.Location = new System.Drawing.Point(122, 194);
            this.listBoxCanciones.Name = "listBoxCanciones";
            this.listBoxCanciones.Size = new System.Drawing.Size(215, 260);
            this.listBoxCanciones.TabIndex = 2;
            this.listBoxCanciones.SelectedIndexChanged += new System.EventHandler(this.listBoxCanciones_SelectedIndexChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(368, 108);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(131, 80);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Guardar a la \r\nBiblioteca";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnDesplegarBiblioteca
            // 
            this.btnDesplegarBiblioteca.Image = ((System.Drawing.Image)(resources.GetObject("btnDesplegarBiblioteca.Image")));
            this.btnDesplegarBiblioteca.Location = new System.Drawing.Point(557, 108);
            this.btnDesplegarBiblioteca.Name = "btnDesplegarBiblioteca";
            this.btnDesplegarBiblioteca.Size = new System.Drawing.Size(131, 80);
            this.btnDesplegarBiblioteca.TabIndex = 4;
            this.btnDesplegarBiblioteca.Text = "Ver Biblioteca";
            // 
            // FrmReproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 475);
            this.Controls.Add(this.btnDesplegarBiblioteca);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.listBoxCanciones);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.Reproductor);
            this.Name = "FrmReproductor";
            this.Text = "FrmReproductor";
            this.Load += new System.EventHandler(this.FrmReproductor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Reproductor;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private System.Windows.Forms.ListBox listBoxCanciones;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnDesplegarBiblioteca;
    }
}