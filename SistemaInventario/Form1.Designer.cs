namespace SistemaInventario
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGestionarProductos = new Button();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGestionarProductos
            // 
            btnGestionarProductos.BackColor = SystemColors.GradientInactiveCaption;
            btnGestionarProductos.ForeColor = SystemColors.ActiveCaptionText;
            btnGestionarProductos.Location = new Point(372, 395);
            btnGestionarProductos.Name = "btnGestionarProductos";
            btnGestionarProductos.Size = new Size(161, 56);
            btnGestionarProductos.TabIndex = 0;
            btnGestionarProductos.Text = "Iniciar sesion ";
            btnGestionarProductos.UseVisualStyleBackColor = false;
            btnGestionarProductos.Click += btnGestionarProductos_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Teal;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Snap ITC", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(235, 66);
            label1.Margin = new Padding(10, 0, 10, 0);
            label1.Name = "label1";
            label1.Size = new Size(515, 103);
            label1.TabIndex = 1;
            label1.Text = "PiruStock";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnGestionarProductos);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(4);
            panel1.Size = new Size(971, 555);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(320, 291);
            label3.Name = "label3";
            label3.Size = new Size(116, 25);
            label3.TabIndex = 4;
            label3.Text = "contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(320, 217);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 3;
            label2.Text = "Run:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(316, 315);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(271, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(316, 241);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(271, 27);
            textBox1.TabIndex = 2;
            // 
            // FormPrincipal
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(977, 561);
            Controls.Add(panel1);
            ForeColor = Color.CornflowerBlue;
            HelpButton = true;
            Name = "FormPrincipal";
            Padding = new Padding(3);
            Text = "Sistema de Inventario - Menú";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGestionarProductos;
        private Label label1;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}
