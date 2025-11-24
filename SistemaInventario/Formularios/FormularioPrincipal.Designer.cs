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
            btnReportes = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnMovimientos
            // 
            btnMovimientos.Location = new Point(273, 196);
            btnMovimientos.Name = "btnMovimientos";
            btnMovimientos.Size = new Size(243, 76);
            btnMovimientos.TabIndex = 0;
            btnMovimientos.Text = "Registrar Movimientos";
            btnMovimientos.UseVisualStyleBackColor = true;
            btnMovimientos.Click += btnMovimientos_Click;
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(273, 117);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(243, 73);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Gestion de productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(273, 278);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(243, 89);
            btnReportes.TabIndex = 2;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnEventos_Click;
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
            Controls.Add(btnReportes);
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
        private Button btnReportes;
        private Label label1;
    }
}