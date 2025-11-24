using SistemaInventario.Modelos; // Importante para reconocer "Producto"
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInventario
{
    public partial class FormularioProductos : Form
    {
        public FormularioProductos()
        {
            InitializeComponent();
        }

        // --- 1. CARGAR DATOS AL INICIO ---
        private void FormularioProductos_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        // Método auxiliar para refrescar la tabla
        private void CargarGrilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = GestorArchivos.CargarProds();
        }

        // Método auxiliar para limpiar las cajas de texto
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtStock.Enabled = true;
            txtStock.BackColor = System.Drawing.Color.White;
        }

        // --- 2. GUARDAR (CREAR NUEVO) ---
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MessageBox.Show("Completa todos los campos.");
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) ||
                !int.TryParse(txtStock.Text, out int stock))
            {
                MessageBox.Show("Precio y Stock deben ser números.");
                return;
            }

            // Cargar lista para calcular ID
            List<Producto> lista = GestorArchivos.CargarProds();

            int nuevoId = 1;
            if (lista.Count > 0)
            {
                nuevoId = lista.Max(p => p.Id) + 1;
            }

            // Crear y Guardar
            Producto nuevo = new Producto(nuevoId, txtNombre.Text, precio, stock);
            lista.Add(nuevo);

            GestorArchivos.GuardarProds(lista);

            MessageBox.Show("Producto guardado.");
            LimpiarCampos();
            CargarGrilla();
        }

        // --- 3. EDITAR (MODIFICAR) ---
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un producto de la tabla.");
                return;
            }

            // Obtenemos el producto seleccionado de la fila
            Producto seleccionado = (Producto)dataGridView1.CurrentRow.DataBoundItem;

            // Validar los nuevos datos
            if (!decimal.TryParse(txtPrecio.Text, out decimal nuevoPrecio) ||
                !int.TryParse(txtStock.Text, out int nuevoStock) ||
                string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Datos inválidos. Revisa los campos.");
                return;
            }

            // Buscar en la lista y actualizar
            List<Producto> lista = GestorArchivos.CargarProds();
            Producto aEditar = lista.FirstOrDefault(p => p.Id == seleccionado.Id);

            if (aEditar != null)
            {
                aEditar.Nombre = txtNombre.Text;
                aEditar.Precio = nuevoPrecio;
                aEditar.Stock = nuevoStock;

                GestorArchivos.GuardarProds(lista);
                CargarGrilla();
                LimpiarCampos();
                MessageBox.Show("Producto editado.");
            }
        }

        // --- 4. ELIMINAR ---
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un producto.");
                return;
            }

            Producto seleccionado = (Producto)dataGridView1.CurrentRow.DataBoundItem;

            if (MessageBox.Show("¿Borrar a " + seleccionado.Nombre + "?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                List<Producto> lista = GestorArchivos.CargarProds();
                Producto aBorrar = lista.FirstOrDefault(p => p.Id == seleccionado.Id);

                if (aBorrar != null)
                {
                    lista.Remove(aBorrar);
                    GestorArchivos.GuardarProds(lista);
                    CargarGrilla();
                    LimpiarCampos();
                    MessageBox.Show("Eliminado.");
                }
            }
        }

        // --- 5. EVENTO AL HACER CLIC EN LA TABLA (Rellena las cajas) ---
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Nota: A veces es mejor usar el evento CellClick, pero este también sirve si haces clic en el contenido.
            if (dataGridView1.CurrentRow != null)
            {
                Producto p = (Producto)dataGridView1.CurrentRow.DataBoundItem;
                txtNombre.Text = p.Nombre;
                txtPrecio.Text = p.Precio.ToString();
                txtStock.Text = p.Stock.ToString();
                txtStock.Enabled = false;
                txtStock.BackColor = System.Drawing.Color.LightGray;
            }
        }

        // Eventos vacíos que generaste (puedes dejarlos así o borrarlos si no los usas)
        private void label3_Click(object sender, EventArgs e) { }
        private void txtNombre_TextChanged(object sender, EventArgs e) { }
        private void lblPrecio_Click(object sender, EventArgs e) { }
        private void txtPrecio_TextChanged(object sender, EventArgs e) { }
        private void lblStock_Click(object sender, EventArgs e) { }
        private void txtStock_TextChanged(object sender, EventArgs e) { }
    }
}