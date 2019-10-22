namespace Parcial2_Ap1.UI.Registros
{
    partial class rFactura
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
            this.IdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.IdLabel = new System.Windows.Forms.Label();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.BorrarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.EstudianteLabel = new System.Windows.Forms.Label();
            this.EstudianteTextBox = new System.Windows.Forms.TextBox();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RemoverButton = new System.Windows.Forms.Button();
            this.DetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.CategoriaLabel = new System.Windows.Forms.Label();
            this.CategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.CantidadLabel = new System.Windows.Forms.Label();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.PrecioLabel = new System.Windows.Forms.Label();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.SimboloXLabel = new System.Windows.Forms.Label();
            this.SimboloIgualLabel = new System.Windows.Forms.Label();
            this.ImporteTextBox = new System.Windows.Forms.TextBox();
            this.ImporteLabel = new System.Windows.Forms.Label();
            this.agregarButton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).BeginInit();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // IdNumericUpDown
            // 
            this.IdNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdNumericUpDown.Location = new System.Drawing.Point(129, 22);
            this.IdNumericUpDown.Name = "IdNumericUpDown";
            this.IdNumericUpDown.Size = new System.Drawing.Size(55, 24);
            this.IdNumericUpDown.TabIndex = 9;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.Location = new System.Drawing.Point(25, 24);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(19, 18);
            this.IdLabel.TabIndex = 8;
            this.IdLabel.Text = "Id";
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaLabel.Location = new System.Drawing.Point(315, 24);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(49, 18);
            this.FechaLabel.TabIndex = 10;
            this.FechaLabel.Text = "Fecha";
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MyErrorProvider.SetIconAlignment(this.FechaDateTimePicker, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.FechaDateTimePicker.Location = new System.Drawing.Point(370, 22);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(142, 24);
            this.FechaDateTimePicker.TabIndex = 11;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuscarButton.Image = global::Parcial2_Ap1.Properties.Resources.imgBuscar;
            this.BuscarButton.Location = new System.Drawing.Point(192, 17);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(37, 32);
            this.BuscarButton.TabIndex = 7;
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // BorrarButton
            // 
            this.BorrarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarButton.Image = global::Parcial2_Ap1.Properties.Resources.imgEliminar;
            this.BorrarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BorrarButton.Location = new System.Drawing.Point(431, 473);
            this.BorrarButton.Name = "BorrarButton";
            this.BorrarButton.Size = new System.Drawing.Size(81, 51);
            this.BorrarButton.TabIndex = 5;
            this.BorrarButton.Text = "Borrar";
            this.BorrarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BorrarButton.UseVisualStyleBackColor = true;
            this.BorrarButton.Click += new System.EventHandler(this.BorrarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuardarButton.Image = global::Parcial2_Ap1.Properties.Resources.imgGuardar;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(234, 473);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(81, 51);
            this.GuardarButton.TabIndex = 4;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NuevoButton.Image = global::Parcial2_Ap1.Properties.Resources.imgNuevo;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(21, 473);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(81, 51);
            this.NuevoButton.TabIndex = 3;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // EstudianteLabel
            // 
            this.EstudianteLabel.AutoSize = true;
            this.EstudianteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstudianteLabel.Location = new System.Drawing.Point(25, 67);
            this.EstudianteLabel.Name = "EstudianteLabel";
            this.EstudianteLabel.Size = new System.Drawing.Size(77, 18);
            this.EstudianteLabel.TabIndex = 16;
            this.EstudianteLabel.Text = "Estudiante";
            // 
            // EstudianteTextBox
            // 
            this.EstudianteTextBox.Location = new System.Drawing.Point(129, 66);
            this.EstudianteTextBox.Name = "EstudianteTextBox";
            this.EstudianteTextBox.Size = new System.Drawing.Size(383, 22);
            this.EstudianteTextBox.TabIndex = 17;
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.agregarButton);
            this.GroupBox.Controls.Add(this.ImporteTextBox);
            this.GroupBox.Controls.Add(this.ImporteLabel);
            this.GroupBox.Controls.Add(this.SimboloIgualLabel);
            this.GroupBox.Controls.Add(this.SimboloXLabel);
            this.GroupBox.Controls.Add(this.PrecioTextBox);
            this.GroupBox.Controls.Add(this.PrecioLabel);
            this.GroupBox.Controls.Add(this.CantidadTextBox);
            this.GroupBox.Controls.Add(this.CantidadLabel);
            this.GroupBox.Controls.Add(this.CategoriaComboBox);
            this.GroupBox.Controls.Add(this.CategoriaLabel);
            this.GroupBox.Controls.Add(this.TotalTextBox);
            this.GroupBox.Controls.Add(this.label1);
            this.GroupBox.Controls.Add(this.RemoverButton);
            this.GroupBox.Controls.Add(this.DetalleDataGridView);
            this.GroupBox.Location = new System.Drawing.Point(21, 122);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(491, 322);
            this.GroupBox.TabIndex = 18;
            this.GroupBox.TabStop = false;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(379, 280);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(104, 22);
            this.TotalTextBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Total";
            // 
            // RemoverButton
            // 
            this.RemoverButton.Image = global::Parcial2_Ap1.Properties.Resources.Remover;
            this.RemoverButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoverButton.Location = new System.Drawing.Point(6, 273);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(102, 36);
            this.RemoverButton.TabIndex = 17;
            this.RemoverButton.Text = "Remover";
            this.RemoverButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoverButton.UseVisualStyleBackColor = true;
            this.RemoverButton.Click += new System.EventHandler(this.RemoverButton_Click);
            // 
            // DetalleDataGridView
            // 
            this.DetalleDataGridView.AllowUserToAddRows = false;
            this.DetalleDataGridView.AllowUserToDeleteRows = false;
            this.DetalleDataGridView.AllowUserToOrderColumns = true;
            this.DetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleDataGridView.Location = new System.Drawing.Point(7, 94);
            this.DetalleDataGridView.Name = "DetalleDataGridView";
            this.DetalleDataGridView.ReadOnly = true;
            this.DetalleDataGridView.RowHeadersWidth = 51;
            this.DetalleDataGridView.RowTemplate.Height = 24;
            this.DetalleDataGridView.Size = new System.Drawing.Size(478, 173);
            this.DetalleDataGridView.TabIndex = 16;
            this.DetalleDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DetalleDataGridView_CellContentClick);
            // 
            // CategoriaLabel
            // 
            this.CategoriaLabel.AutoSize = true;
            this.CategoriaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriaLabel.Location = new System.Drawing.Point(3, 18);
            this.CategoriaLabel.Name = "CategoriaLabel";
            this.CategoriaLabel.Size = new System.Drawing.Size(72, 18);
            this.CategoriaLabel.TabIndex = 20;
            this.CategoriaLabel.Text = "Categoria";
            // 
            // CategoriaComboBox
            // 
            this.CategoriaComboBox.FormattingEnabled = true;
            this.CategoriaComboBox.Location = new System.Drawing.Point(6, 48);
            this.CategoriaComboBox.Name = "CategoriaComboBox";
            this.CategoriaComboBox.Size = new System.Drawing.Size(95, 24);
            this.CategoriaComboBox.TabIndex = 21;
            // 
            // CantidadLabel
            // 
            this.CantidadLabel.AutoSize = true;
            this.CantidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadLabel.Location = new System.Drawing.Point(136, 18);
            this.CantidadLabel.Name = "CantidadLabel";
            this.CantidadLabel.Size = new System.Drawing.Size(66, 18);
            this.CantidadLabel.TabIndex = 22;
            this.CantidadLabel.Text = "Cantidad";
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Location = new System.Drawing.Point(139, 48);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(78, 22);
            this.CantidadTextBox.TabIndex = 23;
            // 
            // PrecioLabel
            // 
            this.PrecioLabel.AutoSize = true;
            this.PrecioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioLabel.Location = new System.Drawing.Point(243, 18);
            this.PrecioLabel.Name = "PrecioLabel";
            this.PrecioLabel.Size = new System.Drawing.Size(51, 18);
            this.PrecioLabel.TabIndex = 24;
            this.PrecioLabel.Text = "Precio";
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Location = new System.Drawing.Point(246, 48);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(78, 22);
            this.PrecioTextBox.TabIndex = 25;
            this.PrecioTextBox.TextChanged += new System.EventHandler(this.PrecioTextBox_TextChanged);
            // 
            // SimboloXLabel
            // 
            this.SimboloXLabel.AutoSize = true;
            this.SimboloXLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimboloXLabel.Location = new System.Drawing.Point(223, 49);
            this.SimboloXLabel.Name = "SimboloXLabel";
            this.SimboloXLabel.Size = new System.Drawing.Size(18, 18);
            this.SimboloXLabel.TabIndex = 26;
            this.SimboloXLabel.Text = "X";
            // 
            // SimboloIgualLabel
            // 
            this.SimboloIgualLabel.AutoSize = true;
            this.SimboloIgualLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimboloIgualLabel.Location = new System.Drawing.Point(332, 49);
            this.SimboloIgualLabel.Name = "SimboloIgualLabel";
            this.SimboloIgualLabel.Size = new System.Drawing.Size(17, 18);
            this.SimboloIgualLabel.TabIndex = 27;
            this.SimboloIgualLabel.Text = "=";
            // 
            // ImporteTextBox
            // 
            this.ImporteTextBox.Location = new System.Drawing.Point(359, 48);
            this.ImporteTextBox.Name = "ImporteTextBox";
            this.ImporteTextBox.ReadOnly = true;
            this.ImporteTextBox.Size = new System.Drawing.Size(78, 22);
            this.ImporteTextBox.TabIndex = 29;
            // 
            // ImporteLabel
            // 
            this.ImporteLabel.AutoSize = true;
            this.ImporteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImporteLabel.Location = new System.Drawing.Point(356, 18);
            this.ImporteLabel.Name = "ImporteLabel";
            this.ImporteLabel.Size = new System.Drawing.Size(58, 18);
            this.ImporteLabel.TabIndex = 28;
            this.ImporteLabel.Text = "Importe";
            this.ImporteLabel.Click += new System.EventHandler(this.ImpoorteLabel_Click);
            // 
            // agregarButton
            // 
            this.agregarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarButton.Image = global::Parcial2_Ap1.Properties.Resources.icons8_más_64;
            this.agregarButton.Location = new System.Drawing.Point(448, 40);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(37, 32);
            this.agregarButton.TabIndex = 30;
            this.agregarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.agregarButton.UseVisualStyleBackColor = true;
            this.agregarButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // rFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 536);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.EstudianteTextBox);
            this.Controls.Add(this.EstudianteLabel);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.FechaLabel);
            this.Controls.Add(this.IdNumericUpDown);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.BorrarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Name = "rFactura";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.RFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).EndInit();
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BorrarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.NumericUpDown IdNumericUpDown;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label EstudianteLabel;
        private System.Windows.Forms.TextBox EstudianteTextBox;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.TextBox ImporteTextBox;
        private System.Windows.Forms.Label ImporteLabel;
        private System.Windows.Forms.Label SimboloIgualLabel;
        private System.Windows.Forms.Label SimboloXLabel;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.Label PrecioLabel;
        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.Label CantidadLabel;
        private System.Windows.Forms.ComboBox CategoriaComboBox;
        private System.Windows.Forms.Label CategoriaLabel;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RemoverButton;
        private System.Windows.Forms.DataGridView DetalleDataGridView;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}