namespace GestorVehiculos
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnEliminar = new Button();
            btnActualizar = new Button();
            dgvVehiculos = new DataGridView();
            btnGuardar = new Button();
            labelKilometraje = new Label();
            chkSeguro = new CheckBox();
            labelSeguro = new Label();
            dtpRevision = new DateTimePicker();
            labelRevision = new Label();
            label1 = new Label();
            nudAnio = new NumericUpDown();
            labelAnio = new Label();
            txtModelo = new TextBox();
            labelModelo = new Label();
            txtMarca = new TextBox();
            labelMarca = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            nudKilometraje = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAnio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKilometraje).BeginInit();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 192, 192);
            btnEliminar.Font = new Font("Microsoft Sans Serif", 12F);
            btnEliminar.Location = new Point(753, 250);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(136, 49);
            btnEliminar.TabIndex = 37;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(192, 192, 255);
            btnActualizar.Font = new Font("Microsoft Sans Serif", 12F);
            btnActualizar.Location = new Point(313, 250);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(136, 49);
            btnActualizar.TabIndex = 36;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // dgvVehiculos
            // 
            dgvVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehiculos.Location = new Point(11, 314);
            dgvVehiculos.Margin = new Padding(3, 4, 3, 4);
            dgvVehiculos.Name = "dgvVehiculos";
            dgvVehiculos.RowHeadersWidth = 51;
            dgvVehiculos.RowTemplate.Height = 24;
            dgvVehiculos.Size = new Size(1106, 241);
            dgvVehiculos.TabIndex = 35;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(192, 255, 192);
            btnGuardar.Font = new Font("Microsoft Sans Serif", 12F);
            btnGuardar.Location = new Point(516, 245);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(166, 58);
            btnGuardar.TabIndex = 34;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // labelKilometraje
            // 
            labelKilometraje.AutoSize = true;
            labelKilometraje.Font = new Font("Microsoft Sans Serif", 12F);
            labelKilometraje.Location = new Point(551, 190);
            labelKilometraje.Name = "labelKilometraje";
            labelKilometraje.Size = new Size(109, 25);
            labelKilometraje.TabIndex = 32;
            labelKilometraje.Text = "Kilometraje";
            // 
            // chkSeguro
            // 
            chkSeguro.AutoSize = true;
            chkSeguro.BackColor = Color.White;
            chkSeguro.Font = new Font("Microsoft Sans Serif", 12F);
            chkSeguro.Location = new Point(716, 139);
            chkSeguro.Margin = new Padding(3, 4, 3, 4);
            chkSeguro.Name = "chkSeguro";
            chkSeguro.Size = new Size(18, 17);
            chkSeguro.TabIndex = 31;
            chkSeguro.UseVisualStyleBackColor = false;
            // 
            // labelSeguro
            // 
            labelSeguro.AutoSize = true;
            labelSeguro.Font = new Font("Microsoft Sans Serif", 12F);
            labelSeguro.Location = new Point(551, 133);
            labelSeguro.Name = "labelSeguro";
            labelSeguro.Size = new Size(131, 25);
            labelSeguro.TabIndex = 30;
            labelSeguro.Text = "¿Asegurado?";
            // 
            // dtpRevision
            // 
            dtpRevision.CalendarFont = new Font("Microsoft Sans Serif", 12F);
            dtpRevision.Location = new Point(716, 75);
            dtpRevision.Margin = new Padding(3, 4, 3, 4);
            dtpRevision.Name = "dtpRevision";
            dtpRevision.Size = new Size(213, 27);
            dtpRevision.TabIndex = 29;
            // 
            // labelRevision
            // 
            labelRevision.AutoSize = true;
            labelRevision.Font = new Font("Microsoft Sans Serif", 12F);
            labelRevision.Location = new Point(551, 73);
            labelRevision.Name = "labelRevision";
            labelRevision.Size = new Size(145, 25);
            labelRevision.TabIndex = 28;
            labelRevision.Text = "Última Revisión";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Heavy", 19.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(416, 15);
            label1.Name = "label1";
            label1.Size = new Size(360, 38);
            label1.TabIndex = 27;
            label1.Text = "GESTIONAR VEHÍCULO";
            // 
            // nudAnio
            // 
            nudAnio.Font = new Font("Microsoft Sans Serif", 12F);
            nudAnio.Location = new Point(278, 188);
            nudAnio.Margin = new Padding(3, 4, 3, 4);
            nudAnio.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            nudAnio.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            nudAnio.Name = "nudAnio";
            nudAnio.Size = new Size(213, 30);
            nudAnio.TabIndex = 26;
            nudAnio.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // labelAnio
            // 
            labelAnio.AutoSize = true;
            labelAnio.Font = new Font("Microsoft Sans Serif", 12F);
            labelAnio.Location = new Point(175, 190);
            labelAnio.Name = "labelAnio";
            labelAnio.Size = new Size(48, 25);
            labelAnio.TabIndex = 25;
            labelAnio.Text = "Año";
            // 
            // txtModelo
            // 
            txtModelo.Font = new Font("Microsoft Sans Serif", 12F);
            txtModelo.Location = new Point(278, 127);
            txtModelo.Margin = new Padding(3, 4, 3, 4);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(213, 30);
            txtModelo.TabIndex = 24;
            // 
            // labelModelo
            // 
            labelModelo.AutoSize = true;
            labelModelo.Font = new Font("Microsoft Sans Serif", 12F);
            labelModelo.Location = new Point(176, 130);
            labelModelo.Name = "labelModelo";
            labelModelo.Size = new Size(77, 25);
            labelModelo.TabIndex = 23;
            labelModelo.Text = "Modelo";
            // 
            // txtMarca
            // 
            txtMarca.Font = new Font("Microsoft Sans Serif", 12F);
            txtMarca.Location = new Point(278, 69);
            txtMarca.Margin = new Padding(3, 4, 3, 4);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(213, 30);
            txtMarca.TabIndex = 22;
            // 
            // labelMarca
            // 
            labelMarca.AutoSize = true;
            labelMarca.Font = new Font("Microsoft Sans Serif", 12F);
            labelMarca.Location = new Point(176, 73);
            labelMarca.Name = "labelMarca";
            labelMarca.Size = new Size(67, 25);
            labelMarca.TabIndex = 21;
            labelMarca.Text = "Marca";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(953, 13);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(166, 126);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // nudKilometraje
            // 
            nudKilometraje.Font = new Font("Microsoft Sans Serif", 12F);
            nudKilometraje.Location = new Point(716, 188);
            nudKilometraje.Margin = new Padding(3, 4, 3, 4);
            nudKilometraje.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudKilometraje.Name = "nudKilometraje";
            nudKilometraje.Size = new Size(213, 30);
            nudKilometraje.TabIndex = 38;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 567);
            Controls.Add(nudKilometraje);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(dgvVehiculos);
            Controls.Add(btnGuardar);
            Controls.Add(labelKilometraje);
            Controls.Add(chkSeguro);
            Controls.Add(labelSeguro);
            Controls.Add(dtpRevision);
            Controls.Add(labelRevision);
            Controls.Add(label1);
            Controls.Add(nudAnio);
            Controls.Add(labelAnio);
            Controls.Add(txtModelo);
            Controls.Add(labelModelo);
            Controls.Add(txtMarca);
            Controls.Add(labelMarca);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestor de Vehículos";
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAnio).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKilometraje).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private Button btnActualizar;
        private DataGridView dgvVehiculos;
        private Button btnGuardar;
        private Label labelKilometraje;
        private CheckBox chkSeguro;
        private Label labelSeguro;
        private DateTimePicker dtpRevision;
        private Label labelRevision;
        private Label label1;
        private NumericUpDown nudAnio;
        private Label labelAnio;
        private TextBox txtModelo;
        private Label labelModelo;
        private TextBox txtMarca;
        private Label labelMarca;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private NumericUpDown nudKilometraje;
    }
}
