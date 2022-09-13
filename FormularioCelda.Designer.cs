namespace OOPrision
{
    partial class FormularioCelda
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ChkEsMaximaSeguridad = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NudNumero = new System.Windows.Forms.NumericUpDown();
            this.NudCapacidad = new System.Windows.Forms.NumericUpDown();
            this.DgvReclusos = new System.Windows.Forms.DataGridView();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnQuitar = new System.Windows.Forms.Button();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NudNumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReclusos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Capacidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // ChkEsMaximaSeguridad
            // 
            this.ChkEsMaximaSeguridad.AutoSize = true;
            this.ChkEsMaximaSeguridad.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkEsMaximaSeguridad.Location = new System.Drawing.Point(86, 113);
            this.ChkEsMaximaSeguridad.Name = "ChkEsMaximaSeguridad";
            this.ChkEsMaximaSeguridad.Size = new System.Drawing.Size(146, 17);
            this.ChkEsMaximaSeguridad.TabIndex = 3;
            this.ChkEsMaximaSeguridad.Text = "Es Maxima Seguridad";
            this.ChkEsMaximaSeguridad.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Reclusos:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // NudNumero
            // 
            this.NudNumero.Location = new System.Drawing.Point(86, 31);
            this.NudNumero.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NudNumero.Name = "NudNumero";
            this.NudNumero.Size = new System.Drawing.Size(161, 20);
            this.NudNumero.TabIndex = 5;
            // 
            // NudCapacidad
            // 
            this.NudCapacidad.Location = new System.Drawing.Point(86, 74);
            this.NudCapacidad.Name = "NudCapacidad";
            this.NudCapacidad.Size = new System.Drawing.Size(161, 20);
            this.NudCapacidad.TabIndex = 6;
            // 
            // DgvReclusos
            // 
            this.DgvReclusos.AllowUserToAddRows = false;
            this.DgvReclusos.AllowUserToDeleteRows = false;
            this.DgvReclusos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvReclusos.Location = new System.Drawing.Point(12, 161);
            this.DgvReclusos.Name = "DgvReclusos";
            this.DgvReclusos.ReadOnly = true;
            this.DgvReclusos.Size = new System.Drawing.Size(755, 245);
            this.DgvReclusos.TabIndex = 7;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(309, 132);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 8;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnQuitar
            // 
            this.BtnQuitar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuitar.Location = new System.Drawing.Point(424, 132);
            this.BtnQuitar.Name = "BtnQuitar";
            this.BtnQuitar.Size = new System.Drawing.Size(75, 23);
            this.BtnQuitar.TabIndex = 9;
            this.BtnQuitar.Text = "Quitar";
            this.BtnQuitar.UseVisualStyleBackColor = true;
            this.BtnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmar.Location = new System.Drawing.Point(353, 415);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.BtnConfirmar.TabIndex = 10;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(449, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(324, 35);
            this.label5.TabIndex = 11;
            this.label5.Text = "Formulario de Celdas";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OOPrision.Properties.Resources.Logo_de_Prision___Copy__2_;
            this.pictureBox1.Location = new System.Drawing.Point(584, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FormularioCelda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(777, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.BtnQuitar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.DgvReclusos);
            this.Controls.Add(this.NudCapacidad);
            this.Controls.Add(this.NudNumero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChkEsMaximaSeguridad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormularioCelda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Celdas";
            ((System.ComponentModel.ISupportInitialize)(this.NudNumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReclusos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ChkEsMaximaSeguridad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NudNumero;
        private System.Windows.Forms.NumericUpDown NudCapacidad;
        private System.Windows.Forms.DataGridView DgvReclusos;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnQuitar;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}