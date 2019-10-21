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
    public partial class rCategorias : Form
    {
        public rCategorias()
        {
            InitializeComponent();
        }

        private void RCategorias_Load(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            MyErrorProvider.Clear();

            CategoriaIdNumericUpDown.Value = 0;
            DescripcionTextBox.Text = string.Empty;
        }

        private void LlenaCampo(Categorias categoria)
        {
            CategoriaIdNumericUpDown.Value = categoria.CategoriaId;
            DescripcionTextBox.Text = categoria.Decripcion;
        }

        private Categorias LlenaClase()
        {
            Categorias categoria = new Categorias();

            categoria.CategoriaId = Convert.ToInt32(CategoriaIdNumericUpDown.Value);
            categoria.Decripcion = DescripcionTextBox.Text;

            return categoria;
        }

        private bool Validar()
        {
            MyErrorProvider.Clear();
            bool paso = true;

            if (string.IsNullOrWhiteSpace(DescripcionTextBox.Text))
            {
                MyErrorProvider.SetError(DescripcionTextBox, "El campo descripcion no puede estar vacio");
                DescripcionTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();

            Categorias categoria = repositorio.Buscar((int)CategoriaIdNumericUpDown.Value);

            return (categoria != null);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();

            bool paso = false;
            MyErrorProvider.Clear();

            if (!Validar())
                return;

            Categorias categoria = LlenaClase();

            if (CategoriaIdNumericUpDown.Value == 0)
                paso = repositorio.Guardar(categoria);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se encuentra en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = repositorio.Modificar(categoria);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Categoria guardada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No fue posible guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void BorrarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();

            int id;
            int.TryParse(Convert.ToString(CategoriaIdNumericUpDown.Value), out id);

            Categorias categoria = repositorio.Buscar(id);

            Limpiar();

            if (categoria != null)
                repositorio.Eliminar(id);
            else
            {
                MyErrorProvider.SetError(CategoriaIdNumericUpDown, "No se puede eliminar una categoria que no existe");
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();

            int id;
            int.TryParse(Convert.ToString(CategoriaIdNumericUpDown.Value), out id);

            Categorias categoria = repositorio.Buscar(id);

            Limpiar();

            if (categoria != null)
                LlenaCampo(categoria);
            else
                MessageBox.Show("Categoria no encontrada");
        }
    }
}
