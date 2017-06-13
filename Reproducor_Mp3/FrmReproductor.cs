using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Reproducor_Mp3
{
    public partial class FrmReproductor : DevExpress.XtraEditors.XtraForm
    {
        bool Play = false;
        string[] ArchivosMP3;
        string[] rutasArchivos;
        public FrmReproductor()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog cajaDeBusquedaDeArchivos = new OpenFileDialog();
            cajaDeBusquedaDeArchivos.Multiselect = true;
            if (cajaDeBusquedaDeArchivos.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                ArchivosMP3 = cajaDeBusquedaDeArchivos.SafeFileNames;
                rutasArchivos = cajaDeBusquedaDeArchivos.FileNames;
                foreach (var ArchivosMP3 in ArchivosMP3)
                {
                    listBoxCanciones.Items.Add(ArchivosMP3);
                }
            }
        }
    }
}