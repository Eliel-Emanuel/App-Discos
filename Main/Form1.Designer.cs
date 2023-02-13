namespace Main
{
    partial class FrmDisco
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgvDisco = new System.Windows.Forms.DataGridView();
            this.PbxDisco = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDisco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxDisco)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvDisco
            // 
            this.DgvDisco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDisco.Location = new System.Drawing.Point(13, 13);
            this.DgvDisco.Name = "DgvDisco";
            this.DgvDisco.Size = new System.Drawing.Size(472, 275);
            this.DgvDisco.TabIndex = 0;
            this.DgvDisco.SelectionChanged += new System.EventHandler(this.DgvDisco_SelectionChanged);
            // 
            // PbxDisco
            // 
            this.PbxDisco.Location = new System.Drawing.Point(492, 13);
            this.PbxDisco.Name = "PbxDisco";
            this.PbxDisco.Size = new System.Drawing.Size(296, 275);
            this.PbxDisco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxDisco.TabIndex = 1;
            this.PbxDisco.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 294);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 36);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(143, 294);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(121, 36);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(274, 294);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 36);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 381);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.PbxDisco);
            this.Controls.Add(this.DgvDisco);
            this.Name = "FrmDisco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmDisco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDisco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxDisco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDisco;
        private System.Windows.Forms.PictureBox PbxDisco;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnDelete;
    }
}

