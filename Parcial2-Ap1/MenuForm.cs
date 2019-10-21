using Parcial2_Ap1.UI.Consultas;
using Parcial2_Ap1.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_Ap1
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void RegsitroDeCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCategorias registro = new rCategorias();
            registro.MdiParent = this;
            registro.Show();
        }

        private void ResgistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rRegistro registro = new rRegistro();
            registro.MdiParent = this;
            registro.Show();
        }

        private void CategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cRegistro registro = new cRegistro();
            registro.MdiParent = this;
            registro.Show();
        }

        private void RegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
