using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_app
{
    public partial class formEdit : Form
    {
        String archivo;
        public formEdit()
        {
            InitializeComponent();
        }

        

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Texto|*.txt";

            if (open.ShowDialog() == DialogResult.OK)
            {
                archivo = open.FileName;

                using (StreamReader sr = new StreamReader(archivo))
                {
                    txtBox.Text = sr.ReadToEnd();
                }
                formEdit.ActiveForm.Text = archivo + " | NOTE";
            }
        }
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    txtBox.Clear();
                    archivo = null;
                }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "Texto|*.txt";


            if (archivo != null)
            {
                using (StreamWriter sw = new StreamWriter(archivo))
                {
                    sw.Write(txtBox.Text);
                }
            }
            else
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    archivo = save.FileName;
                    using (StreamWriter sw = new StreamWriter(save.FileName))
                    {
                        sw.Write(txtBox.Text);
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
