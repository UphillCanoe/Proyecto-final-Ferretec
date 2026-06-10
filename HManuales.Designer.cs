namespace FerreTec
{
    partial class HManuales
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
            pictureBox1 = new PictureBox();
            picIcono = new PictureBox();
            lblCategoria = new Label();
            flowProductos = new FlowLayoutPanel();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIcono).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 86);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.MenuHighlight;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.ImageLocation = "C:\\Users\\PC\\Downloads\\CSharp\\VS\\FerreTec\\FerreTec\\Gemini_Generated_Image_5uprva5uprva5upr-removebg-preview.png";
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(802, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // picIcono
            // 
            picIcono.ImageLocation = "";
            picIcono.Location = new Point(12, 91);
            picIcono.Name = "picIcono";
            picIcono.Size = new Size(62, 58);
            picIcono.SizeMode = PictureBoxSizeMode.StretchImage;
            picIcono.TabIndex = 2;
            picIcono.TabStop = false;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(415, 91);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(38, 15);
            lblCategoria.TabIndex = 3;
            lblCategoria.Text = "label1";
            // 
            // flowProductos
            // 
            flowProductos.AutoScroll = true;
            flowProductos.Location = new Point(80, 132);
            flowProductos.Name = "flowProductos";
            flowProductos.Size = new Size(693, 306);
            flowProductos.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(27, 25);
            button1.Name = "button1";
            button1.Size = new Size(125, 47);
            button1.TabIndex = 5;
            button1.Text = "<- Regresar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // HManuales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(flowProductos);
            Controls.Add(lblCategoria);
            Controls.Add(picIcono);
            Controls.Add(panel1);
            Name = "HManuales";
            Text = "HManuales";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIcono).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox picIcono;
        private Label lblCategoria;
        private FlowLayoutPanel flowProductos;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private PictureBox pictureBox4;
        private Button button1;
    }
}