namespace OOPrision
{
    partial class FormularioRecluso
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
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.CbxSexo = new System.Windows.Forms.ComboBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.NudEstaEnCelda = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NudEstaEnCelda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sexo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(72, 21);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(219, 20);
            this.TxtNombre.TabIndex = 3;
            // 
            // CbxSexo
            // 
            this.CbxSexo.FormattingEnabled = true;
            this.CbxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.CbxSexo.Location = new System.Drawing.Point(72, 77);
            this.CbxSexo.Name = "CbxSexo";
            this.CbxSexo.Size = new System.Drawing.Size(176, 21);
            this.CbxSexo.TabIndex = 4;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(92, 132);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDescripcion.Size = new System.Drawing.Size(439, 185);
            this.TxtDescripcion.TabIndex = 5;
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmar.Location = new System.Drawing.Point(245, 404);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.BtnConfirmar.TabIndex = 6;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Esta en Celda N°:";
            // 
            // NudEstaEnCelda
            // 
            this.NudEstaEnCelda.Location = new System.Drawing.Point(118, 350);
            this.NudEstaEnCelda.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NudEstaEnCelda.Name = "NudEstaEnCelda";
            this.NudEstaEnCelda.Size = new System.Drawing.Size(120, 20);
            this.NudEstaEnCelda.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(423, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Formulario de Reclusos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OOPrision.Properties.Resources.Logo_de_Prision___Copy__2_;
            this.pictureBox1.Location = new System.Drawing.Point(528, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // FormularioRecluso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NudEstaEnCelda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.CbxSexo);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormularioRecluso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioRecluso";
            ((System.ComponentModel.ISupportInitialize)(this.NudEstaEnCelda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.ComboBox CbxSexo;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NudEstaEnCelda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}