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
using System.IO;

namespace Reproducor_Mp3
{
    public partial class FrmReproductor : DevExpress.XtraEditors.XtraForm
    {
       // bool Play = false;

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

                Reproductor.URL = rutasArchivos[0];
                listBoxCanciones.SelectedIndex = 0;
            }
        }

        private void listBoxCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reproductor.URL = rutasArchivos[listBoxCanciones.SelectedIndex];
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string NombreArchivo = "Musica.txt";

            FileStream archivo = new FileStream(NombreArchivo, FileMode.Append, FileAccess.Write);
            StreamWriter Escribir = new StreamWriter(archivo);


           // StreamWriter sw = new StreamWriter("C:\\test.txt");

            foreach (object lista in rutasArchivos)
            {
                Escribir.WriteLine(lista.ToString());
            }

            Escribir.Close();
        }

        private void FrmReproductor_Load(object sender, EventArgs e)
        {
          /*  StreamReader sr = new StreamReader(Convert.ToString("C:\\test.txt"));
            while (sr.Peek() >= 0)
            {
                listBoxCanciones.Items.Add(Convert.ToString(sr.ReadLine()));
            }
            sr.Close();*/
        }
    }
}