using SistemaInventario.Modelos; // Necesario para ver la clase Producto
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
    public partial class FormularioReportes : Form
    {
        public FormularioReportes()
        {
            InitializeComponent();
        }

        // ESTE ES EL EVENTO IMPORTANTE: Se ejecuta al abrir la ventana
        private void FormularioReportes_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            // 1. Traemos la lista de productos desde el archivo
            var listaProductos = GestorArchivos.CargarProds();

            // 2. Usamos LINQ para crear una tabla "al vuelo" con el cálculo incluido
            var reporte = listaProductos.Select(p => new
            {
                ID = p.Id,
                Producto = p.Nombre,
                Precio = p.Precio,
                Stock = p.Stock,
                // Aquí está el truco: Calculamos Precio * Stock para saber cuánto dinero hay en ese ítem
                ValorAcumulado = p.Precio * p.Stock
            }).ToList();

            // 3. Llenamos la tabla visual
            dgvReporte.DataSource = null;
            dgvReporte.DataSource = reporte;

            // 4. Le damos formato de dinero ($) a las columnas de plata para que se vea profesional
            if (dgvReporte.Columns["Precio"] != null)
            {
                dgvReporte.Columns["Precio"].DefaultCellStyle.Format = "C0"; // "C0" significa Moneda sin decimales
            }
            if (dgvReporte.Columns["ValorAcumulado"] != null)
            {
                dgvReporte.Columns["ValorAcumulado"].DefaultCellStyle.Format = "C0";
            }

            // 5. Calculamos el TOTAL FINAL de toda la tienda
            // Usamos la función que ya tenías lista en tu GestorArchivos
            decimal totalGeneral = GestorArchivos.CalcularValorTotalInventario();

            // 6. Lo mostramos en la etiqueta grande
            lblTotal.Text = $"{totalGeneral:C0}";
        }

        // Estos eventos están vacíos porque se generaron al hacer doble clic por error.
        // Puedes dejarlos así, no molestan.
        private void lblTotal_Click(object sender, EventArgs e) { }
        private void dgvReporte_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}