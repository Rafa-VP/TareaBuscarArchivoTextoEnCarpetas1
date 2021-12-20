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

        private void button1_Click(object sender, EventArgs e)
        {
            string directorio = this.txtRuta.Text + "\\" + this.lstCarpetas.SelectedItem;
            

            DirectoryInfo di = new DirectoryInfo(directorio);

            lstArchivos.Items.Clear();
            foreach (var archivo in di.GetFiles())
            {
                this.lstArchivos.Items.Add(archivo);
            }


        }

       


        private void btnAbrir_Click(object sender, EventArgs e)
        {
            
            try
            {
                string directorio = this.txtRuta.Text + "\\" + this.lstCarpetas.SelectedItem;
                string file = directorio + "\\" + this.lstArchivos.SelectedItem;

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

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }

        private void txtRuta_KeyDown(object sender, KeyEventArgs e)
        {
            
                if (e.KeyCode == Keys.Enter)
                {
                    btnAceptar_Click((object)sender, (EventArgs)e);
                }
            
        }
    }
}
