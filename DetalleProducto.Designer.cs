namespace FerreTec
{
    partial class DetalleProducto
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
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnAgregarStock = new Button();
            dataGridView1 = new DataGridView();
            Regresar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(Regresar);
            panel1.Controls.Add(pictureBox5);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 86);
            panel1.TabIndex = 9;
            // 
            // pictureBox5
            // 
            pictureBox5.Dock = DockStyle.Fill;
            pictureBox5.ImageLocation = "C:\\Users\\PC\\Downloads\\CSharp\\VS\\FerreTec\\FerreTec\\Gemini_Generated_Image_5uprva5uprva5upr-removebg-preview.png";
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(799, 86);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(53, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnAgregarStock
            // 
            btnAgregarStock.BackColor = Color.FromArgb(255, 128, 0);
            btnAgregarStock.ForeColor = SystemColors.ControlLightLight;
            btnAgregarStock.Location = new Point(458, 347);
            btnAgregarStock.Name = "btnAgregarStock";
            btnAgregarStock.Size = new Size(179, 82);
            btnAgregarStock.TabIndex = 16;
            btnAgregarStock.Text = "Agregar Stock";
            btnAgregarStock.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(303, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(490, 224);
            dataGridView1.TabIndex = 22;
            // 
            // Regresar
            // 
            Regresar.BackColor = Color.FromArgb(255, 128, 0);
            Regresar.ForeColor = Color.White;
            Regresar.Location = new Point(11, 24);
            Regresar.Name = "Regresar";
            Regresar.Size = new Size(114, 47);
            Regresar.TabIndex = 23;
            Regresar.Text = "<- Regresar";
            Regresar.UseVisualStyleBackColor = false;
            Regresar.Click += Regresar_Click;
            // 
            // DetalleProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnAgregarStock);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "DetalleProducto";
            Text = "DetalleProducto";
            Load += DetalleProducto_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox1;
        private Button btnAgregarStock;
        private DataGridView dataGridView1;
        private Button Regresar;
    }
}