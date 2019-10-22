using Parcial2_Ap1.BLL;
using Parcial2_Ap1.Entitdades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_Ap1.UI.Consultas
{
    public partial class cRegistro : Form
    {
        public cRegistro()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            FacturaRepositorio repositorio = new FacturaRepositorio();

            List<Factura> lista = new List<Factura>();

            if(CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        lista = repositorio.GetList(f => true);
                        break;

                    case 1:
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        lista = repositorio.GetList(f => f.FacturaId == id);
                        break;

                    case 2:
                        lista = repositorio.GetList(f => f.Estudiante.Contains(CriterioTextBox.Text));
                        break;

                    case 3:
                        double total = Convert.ToDouble(CriterioTextBox.Text);
                        lista = repositorio.GetList(f => f.Total == total);
                        break;
                }

                lista = lista.Where(f => f.Fecha >= DesdeDateTimePicker.Value && f.Fecha <= HastaDateTimePicker.Value).ToList();
            }
            else
            {
                lista = repositorio.GetList(f => true);
            }

            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = lista;

        }
    }
}
