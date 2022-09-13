namespace OOPrision
{
    partial class GrillaCeldas
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
            this.BtnVer = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.CbxEsMaximaSeguridad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnVer
            // 
            this.BtnVer.Location = new System.Drawing.Point(18, 99);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(102, 32);
            this.BtnVer.TabIndex = 0;
            this.BtnVer.Text = "Ver";
            this.BtnVer.UseVisualStyleBackColor = true;
            this.BtnVer.Click += new System.EventHandler(this.BtnVer_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(154, 99);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(102, 32);
            this.BtnAgregar.TabIndex = 1;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(293, 99);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(102, 32);
            this.BtnModificar.TabIndex = 2;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Location = new System.Drawing.Point(414, 99);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(102, 32);
            this.BtnBorrar.TabIndex = 3;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // DgvLista
            // 
            this.DgvLista.AllowUserToAddRows = false;
            this.DgvLista.AllowUserToDeleteRows = false;
            this.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLista.Location = new System.Drawing.Point(12, 157);
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.ReadOnly = true;
            this.DgvLista.Size = new System.Drawing.Size(711, 299);
            this.DgvLista.TabIndex = 4;
            // 
            // CbxEsMaximaSeguridad
            // 
            this.CbxEsMaximaSeguridad.FormattingEnabled = true;
            this.CbxEsMaximaSeguridad.Items.AddRange(new object[] {
            "Todos",
            "Maxima Seguridad",
            "Común"});
            this.CbxEsMaximaSeguridad.Location = new System.Drawing.Point(550, 106);
            this.CbxEsMaximaSeguridad.Name = "CbxEsMaximaSeguridad";
            this.CbxEsMaximaSeguridad.Size = new System.Drawing.Size(138, 21);
            this.CbxEsMaximaSeguridad.TabIndex = 5;
            this.CbxEsMaximaSeguridad.SelectedIndexChanged += new System.EventHandler(this.CbxEsMaximaSeguridad_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Gestion de Celdas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OOPrision.Properties.Resources.Logo_de_Prision___Copy__2_;
            this.pictureBox1.Location = new System.Drawing.Point(293, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // GrillaCeldas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(735, 468);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbxEsMaximaSeguridad);
            this.Controls.Add(this.DgvLista);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnVer);
            this.Name = "GrillaCeldas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grilla de Celdas";
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVer;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.ComboBox CbxEsMaximaSeguridad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}