namespace SistemaInventario
{
    partial class FormMovimentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cmbTipoMovimiento = new Label();
            txtCantidad = new Label();
            lblTitulo = new Label();
            cmbProducto = new ComboBox();
            textCantidad = new TextBox();
            comboBox1 = new ComboBox();
            btnRegistrar = new Button();
            lblLista = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 103);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 1;
            label1.Text = "Producto";
            label1.Click += label1_Click;
            // 
            // cmbTipoMovimiento
            // 
            cmbTipoMovimiento.AutoSize = true;
            cmbTipoMovimiento.Location = new Point(117, 173);
            cmbTipoMovimiento.Name = "cmbTipoMovimiento";
            cmbTipoMovimiento.Size = new Size(39, 20);
            cmbTipoMovimiento.TabIndex = 2;
            cmbTipoMovimiento.Text = "Tipo";
            // 
            // txtCantidad
            // 
            txtCantidad.AutoSize = true;
            txtCantidad.Location = new Point(424, 111);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(69, 20);
            txtCantidad.TabIndex = 3;
            txtCantidad.Text = "Cantidad";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 23F);
            lblTitulo.Location = new Point(163, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(446, 52);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Gestion De Movimientos";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(221, 103);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(151, 28);
            cmbProducto.TabIndex = 5;
            cmbProducto.SelectedIndexChanged += cmbProducto_SelectedIndexChanged;
            // 
            // textCantidad
            // 
            textCantidad.Location = new Point(537, 104);
            textCantidad.Name = "textCantidad";
            textCantidad.Size = new Size(125, 27);
            textCantidad.TabIndex = 6;
            textCantidad.TextChanged += textCantidad_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(221, 170);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(340, 258);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar ";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblLista
            // 
            lblLista.AutoSize = true;
            lblLista.Location = new Point(69, 318);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(155, 20);
            lblLista.TabIndex = 11;
            lblLista.Text = "Lista De Movimientos:";
            lblLista.Click += lblLista_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 360);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(690, 189);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FormMovimentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 561);
            Controls.Add(dataGridView1);
            Controls.Add(lblLista);
            Controls.Add(btnRegistrar);
            Controls.Add(comboBox1);
            Controls.Add(textCantidad);
            Controls.Add(cmbProducto);
            Controls.Add(lblTitulo);
            Controls.Add(txtCantidad);
            Controls.Add(cmbTipoMovimiento);
            Controls.Add(label1);
            Name = "FormMovimentos";
            Text = "FormMovimentos";
            Load += FormMovimentos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label cmbTipoMovimiento;
        private Label txtCantidad;
        private Label lblTitulo;
        private ComboBox cmbProducto;
        private TextBox textCantidad;
        private ComboBox comboBox1;
        private Button btnRegistrar;
        private Label lblLista;
        private DataGridView dataGridView1;
    }
}