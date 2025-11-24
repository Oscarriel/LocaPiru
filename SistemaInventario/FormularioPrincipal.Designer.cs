namespace SistemaInventario
{
    partial class FormularioPrincipal
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
            btnMovimientos = new Button();
            btnProductos = new Button();
            btnEventos = new Button();
            btnCategorias = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnMovimientos
            // 
            btnMovimientos.Location = new Point(272, 168);
            btnMovimientos.Name = "btnMovimientos";
            btnMovimientos.Size = new Size(243, 76);
            btnMovimientos.TabIndex = 0;
            btnMovimientos.Text = "Registrar Movimientos";
            btnMovimientos.UseVisualStyleBackColor = true;
            btnMovimientos.Click += btnMovimientos_Click;
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(272, 89);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(243, 73);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Gestion de productos";
            btnProductos.UseVisualStyleBackColor = true;
            // 
            // btnEventos
            // 
            btnEventos.Location = new Point(272, 336);
            btnEventos.Name = "btnEventos";
            btnEventos.Size = new Size(243, 89);
            btnEventos.TabIndex = 2;
            btnEventos.Text = "Eventos";
            btnEventos.UseVisualStyleBackColor = true;
            // 
            // btnCategorias
            // 
            btnCategorias.Location = new Point(272, 250);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(243, 80);
            btnCategorias.TabIndex = 3;
            btnCategorias.Text = "Categorias";
            btnCategorias.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(251, 25);
            label1.Name = "label1";
            label1.Size = new Size(280, 38);
            label1.TabIndex = 4;
            label1.Text = "Gestor de inventarios";
            label1.Click += label1_Click;
            // 
            // FormularioPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnCategorias);
            Controls.Add(btnEventos);
            Controls.Add(btnProductos);
            Controls.Add(btnMovimientos);
            Name = "FormularioPrincipal";
            Text = "Inicio";
            Load += FormularioPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMovimientos;
        private Button btnProductos;
        private Button btnEventos;
        private Button btnCategorias;
        private Label label1;
    }
}