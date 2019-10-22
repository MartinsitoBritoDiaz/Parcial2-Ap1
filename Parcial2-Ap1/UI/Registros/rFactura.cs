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

namespace Parcial2_Ap1.UI.Registros
{
    public partial class rFactura : Form
    {
        public List<CategoriaDetalle> Detalle { get; set; }
        public rFactura()
        {
            InitializeComponent();
            this.Detalle = new List<CategoriaDetalle>();
        }

        private void CargarGrid()
        {
            DetalleDataGridView.DataSource = null;
            DetalleDataGridView.DataSource = this.Detalle;
        }

        private void Limpiar()
        {
            MyErrorProvider.Clear();

            IdNumericUpDown.Value = 0;
            EstudianteTextBox.Text = string.Empty;
            CategoriaComboBox.ResetText();
            CantidadTextBox.Text = string.Empty;
            PrecioTextBox.Text = string.Empty;
            ImporteTextBox.Text = string.Empty;
            TotalTextBox.Text = string.Empty;

            this.Detalle = new List<CategoriaDetalle>();
            CargarGrid();
        }

        private void LlenaCampo(Factura factura)
        {
            IdNumericUpDown.Value = factura.FacturaId;
            EstudianteTextBox.Text = factura.Estudiante;
            TotalTextBox.Text = Convert.ToString(factura.Total);
            this.Detalle = factura.categoriaDetalle;

            CargarGrid();
        }

        private Factura LlenaClase()
        {
            Factura factura = new Factura();

            factura.FacturaId = Convert.ToInt32(IdNumericUpDown.Value);
            factura.Estudiante = EstudianteTextBox.Text;
            factura.Total = Convert.ToDouble(TotalTextBox.Text);
            factura.categoriaDetalle = this.Detalle;

            return factura;
        }

        private bool Validar()
        {
            MyErrorProvider.Clear();
            bool paso = true;

            if (string.IsNullOrWhiteSpace(EstudianteTextBox.Text))
            {
                MyErrorProvider.SetError(EstudianteTextBox, "El campo estudiante no puede estar vacio");
                EstudianteTextBox.Focus();
                paso = false;
            }

            if (this.Detalle.Count == 0)
            {
                MyErrorProvider.SetError(DetalleDataGridView, "Debe de agregar una categoria al detalle");
                DetalleDataGridView.Focus();
                paso = false;
            }

            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            FacturaRepositorio repositorio = new FacturaRepositorio();

            Factura factura = repositorio.Buscar((int)IdNumericUpDown.Value);

            return (factura != null);
        }

        private bool ValidarDetalle()
        {
            MyErrorProvider.Clear();
            bool paso = true;

            if (string.IsNullOrWhiteSpace(CantidadTextBox.Text))
            {
                MyErrorProvider.SetError(CantidadTextBox, "El campo cantidad no puede estar vacio");
                CantidadTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(PrecioTextBox.Text))
            {
                MyErrorProvider.SetError(PrecioTextBox, "El campo precio no puede estar vacio");
                PrecioTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(CategoriaComboBox.Text))
            {
                MyErrorProvider.SetError(CategoriaComboBox, "El campo categoria no puede estar vacio, debe de seleccionar una categoria");
                CategoriaComboBox.Focus();
                paso = false;
            }

            if (Convert.ToInt32(CantidadTextBox.Text) < 0)
            {
                MyErrorProvider.SetError(CantidadTextBox, "El campo cantidad no puede ser menor a 0");
                CantidadTextBox.Focus();
                paso = false;
            }

            if (Convert.ToDouble(PrecioTextBox.Text) < 0)
            {
                MyErrorProvider.SetError(PrecioTextBox, "El campo precio no puede ser negativo");
                PrecioTextBox.Focus();
                paso = false;
            }

            return paso;
        }
        private void RFactura_Load(object sender, EventArgs e)
        {
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();

            foreach (var item in repositorio.GetList(c => true))
            {
                CategoriaComboBox.Items.Add(item.Decripcion);
            }

            CantidadTextBox.Text = Convert.ToString(0);
            PrecioTextBox.Text = Convert.ToString(0);
            ImporteTextBox.Text = Convert.ToString(0);

        }

        private void ImpoorteLabel_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double total = 0;

            if (!ValidarDetalle())
                return;

            if (DetalleDataGridView.DataSource != null)
                this.Detalle = (List<CategoriaDetalle>)DetalleDataGridView.DataSource;

            this.Detalle.Add(
                new CategoriaDetalle(
                    categoriaId: 0,
                    cantidad: Convert.ToInt32(CantidadTextBox.Text),
                    precio: Convert.ToDouble(PrecioTextBox.Text),
                    importe: Convert.ToDouble(ImporteTextBox.Text),
                    facturaId: Convert.ToInt32(IdNumericUpDown.Value)
                    )
                );

            CargarGrid();
            CategoriaComboBox.Focus();
            CategoriaComboBox.ResetText();
            CantidadTextBox.Text = string.Empty;
            PrecioTextBox.Text = string.Empty;
            ImporteTextBox.Text = string.Empty;

            foreach (var item in this.Detalle)
            {
                 total += Convert.ToDouble(item.Importe);
            }

            TotalTextBox.Text = Convert.ToString(total);
        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            double montoTotal = 0;

            if (DetalleDataGridView.Rows.Count > 0 && DetalleDataGridView.CurrentRow != null)
            {
                Detalle.RemoveAt(DetalleDataGridView.CurrentRow.Index);

                CargarGrid();
            }

            foreach (var item in this.Detalle)
            {
                montoTotal += item.Cantidad * item.Precio;
            }

            TotalTextBox.Text = Convert.ToString(montoTotal);

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            FacturaRepositorio repositorio = new FacturaRepositorio();
            bool paso = false;

            if (!Validar())
                return;

            Factura factura = LlenaClase();

            if (IdNumericUpDown.Value == 0)
                paso = repositorio.Guardar(factura);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se encuentra en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = repositorio.Modificar(factura);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
                MessageBox.Show("No se puede guardar", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void BorrarButton_Click(object sender, EventArgs e)
        {
            FacturaRepositorio repositorio = new FacturaRepositorio();

            int id;
            int.TryParse(Convert.ToString(IdNumericUpDown.Value), out id);

            Factura factura = repositorio.Buscar(id);
            Limpiar();

            if(factura != null)
            {
                repositorio.Eliminar(id);
                MessageBox.Show("Factura eliminada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MyErrorProvider.SetError(IdNumericUpDown,"No se puede eliminar una factura que no existe");
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            FacturaRepositorio repositorio = new FacturaRepositorio();

            int id;
            int.TryParse(Convert.ToString(IdNumericUpDown.Value), out id);

            Factura factura = repositorio.Buscar(id);

            Limpiar();

            if (factura != null)
            {
                LlenaCampo(factura);
            }
            else
            {
                MessageBox.Show("Factura no encontrada");
            }
        }

        private void PrecioTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(PrecioTextBox.Text) || string.IsNullOrWhiteSpace(CantidadTextBox.Text)))
                if(!(PrecioTextBox.Text == "-" || CantidadTextBox.Text == "-"))
                    ImporteTextBox.Text = Convert.ToString(Convert.ToDouble(PrecioTextBox.Text) * Convert.ToDouble(CantidadTextBox.Text));
        }

        private void DetalleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
