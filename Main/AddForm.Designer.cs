namespace Main
{
    partial class AddForm
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbxTitulo = new System.Windows.Forms.TextBox();
            this.lblCantidadCanciones = new System.Windows.Forms.Label();
            this.tbxCantidadCanciones = new System.Windows.Forms.TextBox();
            this.lblFechaLanzamiento = new System.Windows.Forms.Label();
            this.cboxEstilo = new System.Windows.Forms.ComboBox();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.lblEdicion = new System.Windows.Forms.Label();
            this.cboxEdicion = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtpLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.lblImagen = new System.Windows.Forms.Label();
            this.tboxImagen = new System.Windows.Forms.TextBox();
            this.pbxModificar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxModificar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(13, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(35, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título";
            // 
            // tbxTitulo
            // 
            this.tbxTitulo.Location = new System.Drawing.Point(71, 24);
            this.tbxTitulo.Name = "tbxTitulo";
            this.tbxTitulo.Size = new System.Drawing.Size(207, 20);
            this.tbxTitulo.TabIndex = 0;
            // 
            // lblCantidadCanciones
            // 
            this.lblCantidadCanciones.AutoSize = true;
            this.lblCantidadCanciones.Location = new System.Drawing.Point(12, 70);
            this.lblCantidadCanciones.Name = "lblCantidadCanciones";
            this.lblCantidadCanciones.Size = new System.Drawing.Size(116, 13);
            this.lblCantidadCanciones.TabIndex = 2;
            this.lblCantidadCanciones.Text = "Cantidad de canciones";
            // 
            // tbxCantidadCanciones
            // 
            this.tbxCantidadCanciones.Location = new System.Drawing.Point(134, 67);
            this.tbxCantidadCanciones.Name = "tbxCantidadCanciones";
            this.tbxCantidadCanciones.Size = new System.Drawing.Size(144, 20);
            this.tbxCantidadCanciones.TabIndex = 1;
            // 
            // lblFechaLanzamiento
            // 
            this.lblFechaLanzamiento.AutoSize = true;
            this.lblFechaLanzamiento.Location = new System.Drawing.Point(13, 113);
            this.lblFechaLanzamiento.Name = "lblFechaLanzamiento";
            this.lblFechaLanzamiento.Size = new System.Drawing.Size(67, 13);
            this.lblFechaLanzamiento.TabIndex = 4;
            this.lblFechaLanzamiento.Text = "Lanzamiento";
            // 
            // cboxEstilo
            // 
            this.cboxEstilo.FormattingEnabled = true;
            this.cboxEstilo.Location = new System.Drawing.Point(71, 176);
            this.cboxEstilo.Name = "cboxEstilo";
            this.cboxEstilo.Size = new System.Drawing.Size(207, 21);
            this.cboxEstilo.TabIndex = 4;
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Location = new System.Drawing.Point(12, 179);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(32, 13);
            this.lblEstilo.TabIndex = 7;
            this.lblEstilo.Text = "Estilo";
            // 
            // lblEdicion
            // 
            this.lblEdicion.AutoSize = true;
            this.lblEdicion.Location = new System.Drawing.Point(12, 216);
            this.lblEdicion.Name = "lblEdicion";
            this.lblEdicion.Size = new System.Drawing.Size(42, 13);
            this.lblEdicion.TabIndex = 8;
            this.lblEdicion.Text = "Edición";
            // 
            // cboxEdicion
            // 
            this.cboxEdicion.FormattingEnabled = true;
            this.cboxEdicion.Location = new System.Drawing.Point(71, 213);
            this.cboxEdicion.Name = "cboxEdicion";
            this.cboxEdicion.Size = new System.Drawing.Size(207, 21);
            this.cboxEdicion.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(53, 262);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Accept";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(167, 262);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtpLanzamiento
            // 
            this.dtpLanzamiento.Location = new System.Drawing.Point(86, 107);
            this.dtpLanzamiento.Name = "dtpLanzamiento";
            this.dtpLanzamiento.Size = new System.Drawing.Size(192, 20);
            this.dtpLanzamiento.TabIndex = 2;
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(12, 144);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(76, 13);
            this.lblImagen.TabIndex = 13;
            this.lblImagen.Text = "Imagen (URL):";
            // 
            // tboxImagen
            // 
            this.tboxImagen.Location = new System.Drawing.Point(95, 144);
            this.tboxImagen.Name = "tboxImagen";
            this.tboxImagen.Size = new System.Drawing.Size(183, 20);
            this.tboxImagen.TabIndex = 3;
            this.tboxImagen.Leave += new System.EventHandler(this.tboxImagen_Leave);
            // 
            // pbxModificar
            // 
            this.pbxModificar.Location = new System.Drawing.Point(302, 24);
            this.pbxModificar.Name = "pbxModificar";
            this.pbxModificar.Size = new System.Drawing.Size(306, 261);
            this.pbxModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxModificar.TabIndex = 15;
            this.pbxModificar.TabStop = false;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 302);
            this.Controls.Add(this.pbxModificar);
            this.Controls.Add(this.tboxImagen);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.dtpLanzamiento);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboxEdicion);
            this.Controls.Add(this.lblEdicion);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.cboxEstilo);
            this.Controls.Add(this.lblFechaLanzamiento);
            this.Controls.Add(this.tbxCantidadCanciones);
            this.Controls.Add(this.lblCantidadCanciones);
            this.Controls.Add(this.tbxTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxModificar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox tbxTitulo;
        private System.Windows.Forms.Label lblCantidadCanciones;
        private System.Windows.Forms.TextBox tbxCantidadCanciones;
        private System.Windows.Forms.Label lblFechaLanzamiento;
        private System.Windows.Forms.ComboBox cboxEstilo;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.Label lblEdicion;
        private System.Windows.Forms.ComboBox cboxEdicion;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtpLanzamiento;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.TextBox tboxImagen;
        private System.Windows.Forms.PictureBox pbxModificar;
    }
}