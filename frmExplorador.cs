using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TareaBuscarArchivoTextoEnCarpetas
{
    public partial class frmExplorador : Form
    {
        public frmExplorador()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string carpeta = this.txtRuta.Text;
            DirectoryInfo di = new DirectoryInfo(carpeta);

            //recorro la lista de archivo y lo almaceno en el listbox
            lstCarpetas.Items.Clear();
            foreach (var archivo in di.GetDirectories())
            {
                this.lstCarpetas.Items.Add(archivo);
            }
        }

        private void txtRuta_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstCarpetas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lstArchivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnArchivos_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string carpeta = this.txtRuta.Text;
            string directorio = this.txtRuta.Text + "\\" + this.lstCarpetas.SelectedItem;
            this.txtRuta.Text = directorio;

            DirectoryInfo di = new DirectoryInfo(directorio);

            lstArchivos.Items.Clear();
            foreach (var archivo in di.GetFiles())
            {
                this.lstArchivos.Items.Add(archivo);
            }


        }

        private void lstResultado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            this.txtRuta.Text = this.txtRuta.Text + "\\" + this.lstArchivos.SelectedItem;
            try
            {
                
                string file = this.txtRuta.Text;

                Console.WriteLine("RUTA SELECCIONADA:" + file);

                FileStream archivo = new FileStream(file, FileMode.Open);
                StreamReader sr = new StreamReader(archivo);

                //lectura de la primera línea del archivo
                string cad, aux = "";
                cad = sr.ReadLine();
                while (cad != null)
                {
                    aux += cad + Environment.NewLine;
                    cad = sr.ReadLine();
                }
                this.txtResultado.Text = aux;
                //cerrar el flujo
                sr.Close();
            }
            catch (IOException e1)
            {
                MessageBox.Show(e1.Message.ToString(), "Mensaje para los papus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
