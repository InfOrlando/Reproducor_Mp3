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

        List<Biblioteca> bibliotecas = new List<Biblioteca>();

       // bool Play = false;

        string[] ArchivosMP3;
        string[] rutasArchivos;
        public FrmReproductor()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            listBoxCanciones.Items.Clear();

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
       
            string NombreArchivo = "Nombre.txt";

            string NombreURL = "URL.txt";

            FileStream archivo = new FileStream(NombreArchivo, FileMode.Append, FileAccess.Write);
            StreamWriter Escribir = new StreamWriter(archivo);

            FileStream archivo2 = new FileStream(NombreURL, FileMode.Append, FileAccess.Write);
            StreamWriter Escribir2 = new StreamWriter(archivo2);


            foreach (object nombre in ArchivosMP3)
            {
                Escribir.WriteLine(nombre.ToString());
            }


            foreach (object rutas in rutasArchivos)
            {
                Escribir2.WriteLine(rutas.ToString());
                            
            }
            

         

            Escribir.Close();
            Escribir2.Close();


            MessageBox.Show("Archivos Guardados en la Biblioteca");

         

        }

        private void FrmReproductor_Load(object sender, EventArgs e)
        {

           
        }

        private void btnDesplegarBiblioteca_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();

            string nombrearchivo = "C:\\Users\\Orlando Perez\\Source\\Repos\\ProyectoFinal2PrograIII\\Reproducor_Mp3\\Reproducor_Mp3\\bin\\Debug\\Nombre.txt";
            string rutaarchivo = "C:\\Users\\Orlando Perez\\Source\\Repos\\ProyectoFinal2PrograIII\\Reproducor_Mp3\\Reproducor_Mp3\\bin\\Debug\\URL.txt";

            FileStream stream = new FileStream(nombrearchivo, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);

            FileStream streamRuta = new FileStream(rutaarchivo, FileMode.Open, FileAccess.Read);
            StreamReader leerRuta = new StreamReader(streamRuta);



            while (leer.Peek() > -1)
            {
                Biblioteca biblioteca = new Biblioteca();

                biblioteca.URL = leerRuta.ReadLine();

                biblioteca.Nombre = leer.ReadLine();
           

                bibliotecas.Add(biblioteca);
 




            }
            //Cerrar el archivo
            leer.Close();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bibliotecas;
            dataGridView1.Refresh();


            dataGridView1.Columns[1].Visible = false;


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           
              Reproductor.URL = dataGridView1.CurrentRow.Cells[1].Value.ToString();

        }
    }
}