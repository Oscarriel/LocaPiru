namespace SistemaInventario
{
    partial class FormularioReportes
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
            dgvReporte = new DataGridView();
            lblTotal = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            SuspendLayout();
            // 
            // dgvReporte
            // 
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.Location = new Point(48, 3);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.RowHeadersWidth = 51;
            dgvReporte.Size = new Size(696, 321);
            dgvReporte.TabIndex = 0;
            dgvReporte.CellContentClick += dgvReporte_CellContentClick;
            // 
            // lblTotal
            // 
            lblTotal.BackColor = SystemColors.ActiveBorder;
            lblTotal.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(196, 400);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(390, 41);
            lblTotal.TabIndex = 1;
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            lblTotal.Click += lblTotal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(351, 348);
            label1.Name = "label1";
            label1.Size = new Size(73, 31);
            label1.TabIndex = 2;
            label1.Text = "Total:";
            label1.Click += label1_Click;
            // 
            // FormularioReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblTotal);
            Controls.Add(dgvReporte);
            Name = "FormularioReportes";
            Text = "FormularioReportes";
            Load += FormularioReportes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvReporte;
        private Label lblTotal;
        private Label label1;
    }
}