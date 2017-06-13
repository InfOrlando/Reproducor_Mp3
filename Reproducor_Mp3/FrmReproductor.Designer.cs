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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Reproductor
            // 
            this.Reproductor.Enabled = true;
            this.Reproductor.Location = new System.Drawing.Point(251, 74);
            this.Reproductor.Name = "Reproductor";
            this.Reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reproductor.OcxState")));
            this.Reproductor.Size = new System.Drawing.Size(450, 387);
            this.Reproductor.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(12, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(179, 55);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Cargar Archivos";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // listBoxCanciones
            // 
            this.listBoxCanciones.FormattingEnabled = true;
            this.listBoxCanciones.ItemHeight = 16;
            this.listBoxCanciones.Location = new System.Drawing.Point(3, 73);
            this.listBoxCanciones.Name = "listBoxCanciones";
            this.listBoxCanciones.Size = new System.Drawing.Size(197, 468);
            this.listBoxCanciones.TabIndex = 2;
            this.listBoxCanciones.SelectedIndexChanged += new System.EventHandler(this.listBoxCanciones_SelectedIndexChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(592, 13);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(179, 54);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Guardar a la \r\nBiblioteca";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnDesplegarBiblioteca
            // 
            this.btnDesplegarBiblioteca.Image = ((System.Drawing.Image)(resources.GetObject("btnDesplegarBiblioteca.Image")));
            this.btnDesplegarBiblioteca.Location = new System.Drawing.Point(834, 12);
            this.btnDesplegarBiblioteca.Name = "btnDesplegarBiblioteca";
            this.btnDesplegarBiblioteca.Size = new System.Drawing.Size(179, 55);
            this.btnDesplegarBiblioteca.TabIndex = 4;
            this.btnDesplegarBiblioteca.Text = "Ver Biblioteca";
            this.btnDesplegarBiblioteca.Click += new System.EventHandler(this.btnDesplegarBiblioteca_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(852, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(312, 467);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Visible = false;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // FrmReproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 599);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDesplegarBiblioteca);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.listBoxCanciones);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.Reproductor);
            this.Name = "FrmReproductor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReproductor";
            this.Load += new System.EventHandler(this.FrmReproductor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Reproductor;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private System.Windows.Forms.ListBox listBoxCanciones;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnDesplegarBiblioteca;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}