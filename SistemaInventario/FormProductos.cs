using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SistemaInventario.Datos;   // Para usar Repositorio
using SistemaInventario.Modelos; // Para usar Producto

namespace SistemaInventario
{
    public partial class FormProductos : Form
    {
        // Lista temporal que mantendremos en memoria
        List<Producto> listaProductos = new List<Producto>();

        // Nombre del archivo donde guardaremos (se creará en la carpeta del .exe)
        string archivo = "productos.txt";

        public FormProductos()
        {
            InitializeComponent();
            dgvProductos.SelectionChanged += dgvProductos_SelectionChanged;
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            // 1. CARGAR (Read)
            // Usamos tu Repositorio genérico pasando el nombre del archivo y la función de conversión
            listaProductos = Repositorio.Cargar(archivo, Producto.DesdeTexto);

            ActualizarGrid();
        }

        private void ActualizarGrid()
        {
            // Refrescamos el DataGridView
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = listaProductos;
        }

        private void GuardarEnArchivo()
        {
            // Usamos tu Repositorio para guardar toda la lista
            // La expresión lambda 'p => p.ATexto()' le dice cómo convertir cada producto a string
            Repositorio.Guardar(archivo, listaProductos, p => p.ATexto());
        }

        // 2. CREAR (Create)
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación simple
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("El nombre es obligatorio.");
                    return;
                }

                // Generar ID automático (Si la lista está vacía es 1, si no, el máximo + 1)
                int nuevoId = listaProductos.Count > 0 ? listaProductos.Max(p => p.Id) + 1 : 1;

                Producto nuevoProd = new Producto(
                    nuevoId,
                    txtNombre.Text,
                    decimal.Parse(txtPrecio.Text), // Asegúrate de ingresar números válidos
                    int.Parse(txtStock.Text)
                );

                listaProductos.Add(nuevoProd);

                GuardarEnArchivo(); // Guardar cambios en txt
                ActualizarGrid();   // Mostrar en pantalla
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: Verifique que Precio y Stock sean números.\n" + ex.Message);
            }
        }

        // 3. ELIMINAR (Delete)
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                // Obtenemos el objeto seleccionado
                Producto seleccionado = (Producto)dgvProductos.SelectedRows[0].DataBoundItem;

                // Confirmación
                var resultado = MessageBox.Show($"¿Borrar {seleccionado.Name}?", "Confirmar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    listaProductos.Remove(seleccionado);
                    GuardarEnArchivo();
                    ActualizarGrid();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
            }
        }

        // Utilidad para limpiar los TextBox
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtNombre.Focus();
        }

        // Evento opcional: Cargar datos en los TextBox al hacer clic en la grilla (para Editar)
        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                Producto seleccionado = (Producto)dgvProductos.SelectedRows[0].DataBoundItem;
                txtNombre.Text = seleccionado.Name;
                txtPrecio.Text = seleccionado.Precio.ToString();
                txtStock.Text = seleccionado.Stock.ToString();
            }
        }

        // 4. EDITAR (Update) - Puedes poner esto en un botón "Modificar"
        private void btnModificar_Click(object sender, EventArgs e)
        {
            // 1. Verificar si hay una fila seleccionada
            if (dgvProductos.SelectedRows.Count > 0)
            {
                try
                {
                    // 2. Obtener el objeto seleccionado
                    Producto seleccionado = (Producto)dgvProductos.SelectedRows[0].DataBoundItem;

                    // 3. Validar que los campos no estén vacíos
                    if (string.IsNullOrWhiteSpace(txtNombre.Text))
                    {
                        MessageBox.Show("El nombre no puede estar vacío.");
                        return;
                    }

                    // 4. Actualizar valores (con protección contra errores de formato)
                    seleccionado.Name = txtNombre.Text;
                    seleccionado.Precio = decimal.Parse(txtPrecio.Text);
                    seleccionado.Stock = int.Parse(txtStock.Text);

                    // 5. Guardar y Actualizar
                    GuardarEnArchivo();
                    ActualizarGrid();
                    MessageBox.Show("Producto modificado correctamente.");
                    LimpiarCampos(); // Opcional: limpiar después de editar
                }
                catch (FormatException)
                {
                    MessageBox.Show("Error: Precio y Stock deben ser números válidos.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al editar: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto de la lista para editar.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormProductos_Load_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}