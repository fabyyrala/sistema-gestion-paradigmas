namespace OOPrision
{
    partial class GrillaReclusos
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
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.BtnVer = new System.Windows.Forms.Button();
            this.TxtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Location = new System.Drawing.Point(44, 86);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(85, 33);
            this.BtnSeleccionar.TabIndex = 0;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.UseVisualStyleBackColor = true;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(304, 86);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(84, 33);
            this.BtnAgregar.TabIndex = 1;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(422, 86);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(83, 33);
            this.BtnModificar.TabIndex = 2;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Location = new System.Drawing.Point(551, 86);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(82, 33);
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
            this.DgvLista.Location = new System.Drawing.Point(12, 162);
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.ReadOnly = true;
            this.DgvLista.Size = new System.Drawing.Size(711, 294);
            this.DgvLista.TabIndex = 4;
            // 
            // BtnVer
            // 
            this.BtnVer.Location = new System.Drawing.Point(170, 86);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(85, 33);
            this.BtnVer.TabIndex = 5;
            this.BtnVer.Text = "Ver";
            this.BtnVer.UseVisualStyleBackColor = true;
            this.BtnVer.Click += new System.EventHandler(this.BtnVer_Click);
            // 
            // TxtFiltro
            // 
            this.TxtFiltro.Location = new System.Drawing.Point(12, 136);
            this.TxtFiltro.Name = "TxtFiltro";
            this.TxtFiltro.Size = new System.Drawing.Size(711, 20);
            this.TxtFiltro.TabIndex = 6;
            this.TxtFiltro.TextChanged += new System.EventHandler(this.TxtFiltro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "Gestion de Reclusos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OOPrision.Properties.Resources.Logo_de_Prision___Copy__2_;
            this.pictureBox1.Location = new System.Drawing.Point(327, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // GrillaReclusos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(735, 468);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtFiltro);
            this.Controls.Add(this.BtnVer);
            this.Controls.Add(this.DgvLista);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnSeleccionar);
            this.Name = "GrillaReclusos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GrillaReclusos";
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.Button BtnVer;
        private System.Windows.Forms.TextBox TxtFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}