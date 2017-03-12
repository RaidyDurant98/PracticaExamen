namespace DetalleFacturaProducto.UI.Registros
{
    partial class FacturasResgistroForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label facturaIdLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label costoLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label importeLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label productosLabel;
            this.facturaIdTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.costoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.precioMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.importeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.DetallegroupBox = new System.Windows.Forms.GroupBox();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.DetalledataGridView = new System.Windows.Forms.DataGridView();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.CamposVacioserrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cantidadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.productosComboBox = new System.Windows.Forms.ComboBox();
            facturaIdLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            costoLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            importeLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            productosLabel = new System.Windows.Forms.Label();
            this.DetallegroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CamposVacioserrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // facturaIdLabel
            // 
            facturaIdLabel.AutoSize = true;
            facturaIdLabel.Location = new System.Drawing.Point(66, 18);
            facturaIdLabel.Name = "facturaIdLabel";
            facturaIdLabel.Size = new System.Drawing.Size(58, 13);
            facturaIdLabel.TabIndex = 1;
            facturaIdLabel.Text = "Factura Id:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(66, 45);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 3;
            fechaLabel.Text = "Fecha:";
            // 
            // costoLabel
            // 
            costoLabel.AutoSize = true;
            costoLabel.Location = new System.Drawing.Point(66, 73);
            costoLabel.Name = "costoLabel";
            costoLabel.Size = new System.Drawing.Size(37, 13);
            costoLabel.TabIndex = 9;
            costoLabel.Text = "Costo:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(66, 99);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 11;
            precioLabel.Text = "Precio:";
            // 
            // importeLabel
            // 
            importeLabel.AutoSize = true;
            importeLabel.Location = new System.Drawing.Point(66, 160);
            importeLabel.Name = "importeLabel";
            importeLabel.Size = new System.Drawing.Size(45, 13);
            importeLabel.TabIndex = 13;
            importeLabel.Text = "Importe:";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(66, 127);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(52, 13);
            cantidadLabel.TabIndex = 20;
            cantidadLabel.Text = "Cantidad:";
            // 
            // facturaIdTextBox
            // 
            this.facturaIdTextBox.Location = new System.Drawing.Point(137, 15);
            this.facturaIdTextBox.Name = "facturaIdTextBox";
            this.facturaIdTextBox.Size = new System.Drawing.Size(49, 20);
            this.facturaIdTextBox.TabIndex = 2;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(137, 41);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 4;
            // 
            // costoMaskedTextBox
            // 
            this.costoMaskedTextBox.Location = new System.Drawing.Point(137, 70);
            this.costoMaskedTextBox.Mask = "999999999999";
            this.costoMaskedTextBox.Name = "costoMaskedTextBox";
            this.costoMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.costoMaskedTextBox.TabIndex = 10;
            // 
            // precioMaskedTextBox
            // 
            this.precioMaskedTextBox.Location = new System.Drawing.Point(137, 96);
            this.precioMaskedTextBox.Mask = "999999999999";
            this.precioMaskedTextBox.Name = "precioMaskedTextBox";
            this.precioMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.precioMaskedTextBox.TabIndex = 12;
            // 
            // importeMaskedTextBox
            // 
            this.importeMaskedTextBox.Location = new System.Drawing.Point(137, 157);
            this.importeMaskedTextBox.Mask = "999999999999";
            this.importeMaskedTextBox.Name = "importeMaskedTextBox";
            this.importeMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.importeMaskedTextBox.TabIndex = 14;
            // 
            // DetallegroupBox
            // 
            this.DetallegroupBox.Controls.Add(productosLabel);
            this.DetallegroupBox.Controls.Add(this.productosComboBox);
            this.DetallegroupBox.Controls.Add(this.Agregarbutton);
            this.DetallegroupBox.Controls.Add(this.DetalledataGridView);
            this.DetallegroupBox.Location = new System.Drawing.Point(12, 189);
            this.DetallegroupBox.Name = "DetallegroupBox";
            this.DetallegroupBox.Size = new System.Drawing.Size(402, 229);
            this.DetallegroupBox.TabIndex = 15;
            this.DetallegroupBox.TabStop = false;
            this.DetallegroupBox.Text = "Detalle";
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Location = new System.Drawing.Point(307, 13);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(75, 23);
            this.Agregarbutton.TabIndex = 8;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // DetalledataGridView
            // 
            this.DetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalledataGridView.Location = new System.Drawing.Point(9, 40);
            this.DetalledataGridView.Name = "DetalledataGridView";
            this.DetalledataGridView.Size = new System.Drawing.Size(373, 169);
            this.DetalledataGridView.TabIndex = 7;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(262, 12);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 16;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(253, 435);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton.TabIndex = 19;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(163, 435);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 18;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(69, 435);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton.TabIndex = 17;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // CamposVacioserrorProvider
            // 
            this.CamposVacioserrorProvider.ContainerControl = this;
            // 
            // cantidadNumericUpDown
            // 
            this.cantidadNumericUpDown.Location = new System.Drawing.Point(137, 125);
            this.cantidadNumericUpDown.Name = "cantidadNumericUpDown";
            this.cantidadNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.cantidadNumericUpDown.TabIndex = 21;
            // 
            // productosLabel
            // 
            productosLabel.AutoSize = true;
            productosLabel.Location = new System.Drawing.Point(6, 18);
            productosLabel.Name = "productosLabel";
            productosLabel.Size = new System.Drawing.Size(58, 13);
            productosLabel.TabIndex = 8;
            productosLabel.Text = "Productos:";
            // 
            // productosComboBox
            // 
            this.productosComboBox.FormattingEnabled = true;
            this.productosComboBox.Location = new System.Drawing.Point(70, 15);
            this.productosComboBox.Name = "productosComboBox";
            this.productosComboBox.Size = new System.Drawing.Size(121, 21);
            this.productosComboBox.TabIndex = 9;
            // 
            // FacturasResgistroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 498);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadNumericUpDown);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.DetallegroupBox);
            this.Controls.Add(facturaIdLabel);
            this.Controls.Add(this.facturaIdTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(costoLabel);
            this.Controls.Add(this.costoMaskedTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioMaskedTextBox);
            this.Controls.Add(importeLabel);
            this.Controls.Add(this.importeMaskedTextBox);
            this.Name = "FacturasResgistroForm";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.FacturasResgistroForm_Load);
            this.DetallegroupBox.ResumeLayout(false);
            this.DetallegroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CamposVacioserrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox facturaIdTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.MaskedTextBox costoMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox precioMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox importeMaskedTextBox;
        private System.Windows.Forms.GroupBox DetallegroupBox;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.DataGridView DetalledataGridView;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.ErrorProvider CamposVacioserrorProvider;
        private System.Windows.Forms.NumericUpDown cantidadNumericUpDown;
        private System.Windows.Forms.ComboBox productosComboBox;
    }
}