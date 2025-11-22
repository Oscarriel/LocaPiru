namespace SistemaInventario
{
    partial class FormProductos
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            dgvProductos = new DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Teal;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Sylfaen", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(28, 44);
            label1.Name = "label1";
            label1.Size = new Size(95, 26);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Teal;
            label2.Font = new Font("Sylfaen", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(40, 89);
            label2.Name = "label2";
            label2.Size = new Size(78, 26);
            label2.TabIndex = 0;
            label2.Text = "Precio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Teal;
            label3.Font = new Font("Sylfaen", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(53, 131);
            label3.Name = "label3";
            label3.Size = new Size(70, 26);
            label3.TabIndex = 0;
            label3.Text = "Stock:";
            label3.Click += label3_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(120, 39);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(384, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(120, 84);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(384, 27);
            txtPrecio.TabIndex = 1;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(120, 127);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(384, 27);
            txtStock.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(537, 37);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(138, 34);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(537, 84);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(138, 34);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(537, 127);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(138, 34);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar/Guardar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnModificar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Sylfaen", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(101, 221);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(550, 193);
            dgvProductos.TabIndex = 3;
            dgvProductos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(829, 442);
            panel1.TabIndex = 4;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(837, 450);
            Controls.Add(dgvProductos);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FormProductos";
            Padding = new Padding(4);
            Text = "FormProductos";
            Load += FormProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnEditar;
        private DataGridView dgvProductos;
        private Panel panel1;
    }
}