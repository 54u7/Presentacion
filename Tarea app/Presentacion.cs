using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_app
{
    public partial class Presentacion : Form
    {
        public Presentacion()
        {
            InitializeComponent();
        }

        private void btnEditor_Click(object sender, EventArgs e)
        {
            if (btnPaint.Enabled)
            {
                //Form1 form = new Form1();
                //form.Enabled = false;
                formPaint formP = new formPaint();
                formP.Visible = true;
            }
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            formEdit formE = new formEdit();
            formE.Visible = true;
        }
    }
}
