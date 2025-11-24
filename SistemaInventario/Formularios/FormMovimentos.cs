using SistemaInventario.Modelos;
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
    public partial class FormMovimentos : Form
    {
        private void ActualizarDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = GestorArchivos.CargarMovs();
        }
        private object? movimientos;

        public FormMovimentos()
        {
            InitializeComponent();
        }

        private void FormMovimentos_Load(object sender, EventArgs e)
        {
            List<Producto> listaProductos = GestorArchivos.CargarProds();

            
            cmbProducto.DataSource = listaProductos;
            cmbProducto.DisplayMember = "Nombre";
            cmbProducto.ValueMember = "Id";

            
            comboBox1.Items.Add("ENTRADA");
            comboBox1.Items.Add("SALIDA");
            comboBox1.SelectedIndex = 0;

            ActualizarDataGridView();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void lblLista_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedValue == null || !int.TryParse(textCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Por favor, seleccione un producto y use una cantidad numérica válida.", "Error");
                return;
            }

            int nuevoId = GestorArchivos.GenerarID();
            int productoIdSeleccionado = (int)cmbProducto.SelectedValue!;
            string tipo = comboBox1.SelectedItem!.ToString();

            Movimiento nuevoMovimiento = new Movimiento(
                nuevoId,
                productoIdSeleccionado,
                DateTime.Now,
                cantidad,
                tipo
            );

            if (GestorArchivos.ActualizarStock(productoIdSeleccionado, cantidad, tipo))
            {
                List<Movimiento> listaMovimientos = GestorArchivos.CargarMovs();
                listaMovimientos.Add(nuevoMovimiento);
                GestorArchivos.GuardarMovs(listaMovimientos);

                MessageBox.Show("Movimiento y Stock actualizados con éxito.", "Registro OK");

                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Error: Stock insuficiente para realizar esta salida.", "Advertencia");
            }
        }
        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == dataGridView1.NewRowIndex)
                return;

            Movimiento movimientoSeleccionado = (Movimiento)dataGridView1.Rows[e.RowIndex].DataBoundItem;

            if (movimientoSeleccionado != null)
            {
                cmbProducto.SelectedValue = movimientoSeleccionado.ID_ProductoRelacionado;

                textCantidad.Text = movimientoSeleccionado.CantidadMovida.ToString();

                comboBox1.SelectedItem = movimientoSeleccionado.TipoDeOperacion;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
