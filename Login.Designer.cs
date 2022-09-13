namespace OOPrision
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblMensaje = new System.Windows.Forms.Label();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(197, 127);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(186, 20);
            this.TxtUsuario.TabIndex = 2;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Location = new System.Drawing.Point(197, 177);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.PasswordChar = '*';
            this.TxtContraseña.Size = new System.Drawing.Size(186, 20);
            this.TxtContraseña.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(502, 58);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bienvenido al Sistema ";
            // 
            // LblMensaje
            // 
            this.LblMensaje.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMensaje.ForeColor = System.Drawing.Color.Black;
            this.LblMensaje.Location = new System.Drawing.Point(0, 343);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(530, 23);
            this.LblMensaje.TabIndex = 5;
            this.LblMensaje.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.Location = new System.Drawing.Point(227, 251);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(116, 32);
            this.BtnIngresar.TabIndex = 6;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OOPrision.Properties.Resources.Logo_de_Prision___Copy__2_;
            this.pictureBox1.Location = new System.Drawing.Point(441, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OOPrision.Properties.Resources.Logo_de_Prision___Copy__2_;
            this.pictureBox2.Location = new System.Drawing.Point(12, 127);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(530, 366);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.LblMensaje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso al Sistema ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblMensaje;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

