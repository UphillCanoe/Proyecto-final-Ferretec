namespace FerreTec
{
    partial class NuevoProducto
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
            pictureBox1 = new PictureBox();
            Regresar = new Button();
            pictureBox = new PictureBox();
            btnSubir = new Button();
            btnBorrar = new Button();
            dataGridView1 = new DataGridView();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
            txtMarca = new TextBox();
            comboTipo = new ComboBox();
            btnSubirImagen = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.MenuHighlight;
            pictureBox1.ImageLocation = "C:\\Users\\PC\\Downloads\\CSharp\\VS\\FerreTec\\FerreTec\\Gemini_Generated_Image_5uprva5uprva5upr-removebg-preview.png";
            pictureBox1.Location = new Point(1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(802, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Regresar
            // 
            Regresar.BackColor = Color.FromArgb(255, 128, 0);
            Regresar.ForeColor = Color.White;
            Regresar.Location = new Point(12, 26);
            Regresar.Name = "Regresar";
            Regresar.Size = new Size(144, 44);
            Regresar.TabIndex = 2;
            Regresar.Text = "<- Regresar";
            Regresar.UseVisualStyleBackColor = false;
            Regresar.Click += Regresar_Click;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(38, 121);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(161, 148);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 3;
            pictureBox.TabStop = false;
            // 
            // btnSubir
            // 
            btnSubir.BackColor = Color.MediumSeaGreen;
            btnSubir.ForeColor = SystemColors.ControlLightLight;
            btnSubir.Location = new Point(216, 438);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(109, 54);
            btnSubir.TabIndex = 4;
            btnSubir.Text = "Subir";
            btnSubir.UseVisualStyleBackColor = false;
            btnSubir.Click += btnSubir_Click_1;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.Red;
            btnBorrar.ForeColor = SystemColors.ControlLightLight;
            btnBorrar.Location = new Point(438, 438);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(108, 54);
            btnBorrar.TabIndex = 5;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 520);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 123);
            dataGridView1.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(263, 121);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(248, 23);
            txtNombre.TabIndex = 8;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(263, 176);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(248, 23);
            txtPrecio.TabIndex = 9;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(263, 226);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(248, 23);
            txtCantidad.TabIndex = 10;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(263, 277);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(248, 23);
            txtMarca.TabIndex = 11;
            txtMarca.TextChanged += txtMarca_TextChanged;
            // 
            // comboTipo
            // 
            comboTipo.FormattingEnabled = true;
            comboTipo.Location = new Point(263, 357);
            comboTipo.Name = "comboTipo";
            comboTipo.Size = new Size(170, 23);
            comboTipo.TabIndex = 12;
            comboTipo.SelectedIndexChanged += comboTipo_SelectedIndexChanged;
            // 
            // btnSubirImagen
            // 
            btnSubirImagen.Location = new Point(38, 277);
            btnSubirImagen.Name = "btnSubirImagen";
            btnSubirImagen.Size = new Size(161, 37);
            btnSubirImagen.TabIndex = 13;
            btnSubirImagen.Text = "Subir imagen";
            btnSubirImagen.UseVisualStyleBackColor = true;
            btnSubirImagen.Click += btnSubirImagen_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(263, 103);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 14;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 158);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 15;
            label2.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(259, 208);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 16;
            label3.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(263, 259);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 17;
            label4.Text = "Marca";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(263, 339);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 19;
            label6.Text = "Tipo";
            // 
            // NuevoProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 699);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSubirImagen);
            Controls.Add(comboTipo);
            Controls.Add(txtMarca);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(dataGridView1);
            Controls.Add(btnBorrar);
            Controls.Add(btnSubir);
            Controls.Add(pictureBox);
            Controls.Add(Regresar);
            Controls.Add(pictureBox1);
            Name = "NuevoProducto";
            Text = "NuevoProducto";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button Regresar;
        private PictureBox pictureBox;
        private Button btnSubir;
        private Button btnBorrar;
        private DataGridView dataGridView1;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtCantidad;
        private TextBox txtMarca;
        private ComboBox comboTipo;
        private Button btnSubirImagen;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
    }
}