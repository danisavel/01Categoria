namespace _01Categoria
{
    partial class FCategoria
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
            this.TNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudDia = new System.Windows.Forms.NumericUpDown();
            this.nudMes = new System.Windows.Forms.NumericUpDown();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.BIngresar = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LCantQuerubin = new System.Windows.Forms.Label();
            this.LCantBenjamin = new System.Windows.Forms.Label();
            this.LCantInfantil = new System.Windows.Forms.Label();
            this.LCantCadete = new System.Windows.Forms.Label();
            this.LCantJuvenil = new System.Windows.Forms.Label();
            this.LCantAmateur = new System.Windows.Forms.Label();
            this.LCantVeterano = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(96, 19);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(140, 20);
            this.TNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido:";
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(96, 57);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(140, 20);
            this.TApellido.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha nac.:";
            // 
            // nudDia
            // 
            this.nudDia.Location = new System.Drawing.Point(96, 94);
            this.nudDia.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudDia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDia.Name = "nudDia";
            this.nudDia.Size = new System.Drawing.Size(40, 20);
            this.nudDia.TabIndex = 5;
            this.nudDia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudMes
            // 
            this.nudMes.Location = new System.Drawing.Point(142, 94);
            this.nudMes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudMes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMes.Name = "nudMes";
            this.nudMes.Size = new System.Drawing.Size(40, 20);
            this.nudMes.TabIndex = 6;
            this.nudMes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(188, 94);
            this.nudAnio.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(48, 20);
            this.nudAnio.TabIndex = 7;
            // 
            // BIngresar
            // 
            this.BIngresar.Location = new System.Drawing.Point(96, 132);
            this.BIngresar.Name = "BIngresar";
            this.BIngresar.Size = new System.Drawing.Size(140, 25);
            this.BIngresar.TabIndex = 8;
            this.BIngresar.Text = "&Ingresar";
            this.BIngresar.UseVisualStyleBackColor = true;
            this.BIngresar.Click += new System.EventHandler(this.BIngresar_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BCancelar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BCancelar.Location = new System.Drawing.Point(0, 177);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(447, 23);
            this.BCancelar.TabIndex = 9;
            this.BCancelar.Text = "&Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(280, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Categorías";
            // 
            // LCantQuerubin
            // 
            this.LCantQuerubin.AutoSize = true;
            this.LCantQuerubin.BackColor = System.Drawing.Color.White;
            this.LCantQuerubin.ForeColor = System.Drawing.Color.Black;
            this.LCantQuerubin.Location = new System.Drawing.Point(280, 57);
            this.LCantQuerubin.Name = "LCantQuerubin";
            this.LCantQuerubin.Size = new System.Drawing.Size(61, 13);
            this.LCantQuerubin.TabIndex = 11;
            this.LCantQuerubin.Text = "•Querubín:";
            // 
            // LCantBenjamin
            // 
            this.LCantBenjamin.AutoSize = true;
            this.LCantBenjamin.BackColor = System.Drawing.Color.White;
            this.LCantBenjamin.ForeColor = System.Drawing.Color.Black;
            this.LCantBenjamin.Location = new System.Drawing.Point(280, 94);
            this.LCantBenjamin.Name = "LCantBenjamin";
            this.LCantBenjamin.Size = new System.Drawing.Size(59, 13);
            this.LCantBenjamin.TabIndex = 12;
            this.LCantBenjamin.Text = "•Benjamin:";
            // 
            // LCantInfantil
            // 
            this.LCantInfantil.AutoSize = true;
            this.LCantInfantil.BackColor = System.Drawing.Color.White;
            this.LCantInfantil.ForeColor = System.Drawing.Color.Black;
            this.LCantInfantil.Location = new System.Drawing.Point(280, 131);
            this.LCantInfantil.Name = "LCantInfantil";
            this.LCantInfantil.Size = new System.Drawing.Size(47, 13);
            this.LCantInfantil.TabIndex = 13;
            this.LCantInfantil.Text = "•Infantil:";
            // 
            // LCantCadete
            // 
            this.LCantCadete.AutoSize = true;
            this.LCantCadete.BackColor = System.Drawing.Color.White;
            this.LCantCadete.ForeColor = System.Drawing.Color.Black;
            this.LCantCadete.Location = new System.Drawing.Point(369, 57);
            this.LCantCadete.Name = "LCantCadete";
            this.LCantCadete.Size = new System.Drawing.Size(50, 13);
            this.LCantCadete.TabIndex = 14;
            this.LCantCadete.Text = "•Cadete:";
            // 
            // LCantJuvenil
            // 
            this.LCantJuvenil.AutoSize = true;
            this.LCantJuvenil.BackColor = System.Drawing.Color.White;
            this.LCantJuvenil.ForeColor = System.Drawing.Color.Black;
            this.LCantJuvenil.Location = new System.Drawing.Point(369, 82);
            this.LCantJuvenil.Name = "LCantJuvenil";
            this.LCantJuvenil.Size = new System.Drawing.Size(49, 13);
            this.LCantJuvenil.TabIndex = 15;
            this.LCantJuvenil.Text = "•Juvenil:";
            // 
            // LCantAmateur
            // 
            this.LCantAmateur.AutoSize = true;
            this.LCantAmateur.BackColor = System.Drawing.Color.White;
            this.LCantAmateur.ForeColor = System.Drawing.Color.Black;
            this.LCantAmateur.Location = new System.Drawing.Point(369, 107);
            this.LCantAmateur.Name = "LCantAmateur";
            this.LCantAmateur.Size = new System.Drawing.Size(55, 13);
            this.LCantAmateur.TabIndex = 16;
            this.LCantAmateur.Text = "•Amateur:";
            // 
            // LCantVeterano
            // 
            this.LCantVeterano.AutoSize = true;
            this.LCantVeterano.BackColor = System.Drawing.Color.White;
            this.LCantVeterano.ForeColor = System.Drawing.Color.Black;
            this.LCantVeterano.Location = new System.Drawing.Point(369, 132);
            this.LCantVeterano.Name = "LCantVeterano";
            this.LCantVeterano.Size = new System.Drawing.Size(59, 13);
            this.LCantVeterano.TabIndex = 17;
            this.LCantVeterano.Text = "•Veterano:";
            // 
            // FCategoria
            // 
            this.AcceptButton = this.BIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BCancelar;
            this.ClientSize = new System.Drawing.Size(447, 200);
            this.Controls.Add(this.LCantVeterano);
            this.Controls.Add(this.LCantAmateur);
            this.Controls.Add(this.LCantJuvenil);
            this.Controls.Add(this.LCantCadete);
            this.Controls.Add(this.LCantInfantil);
            this.Controls.Add(this.LCantBenjamin);
            this.Controls.Add(this.LCantQuerubin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BIngresar);
            this.Controls.Add(this.nudAnio);
            this.Controls.Add(this.nudMes);
            this.Controls.Add(this.nudDia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TNombre);
            this.Controls.Add(this.label1);
            this.Name = "FCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categoria";
            ((System.ComponentModel.ISupportInitialize)(this.nudDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudDia;
        private System.Windows.Forms.NumericUpDown nudMes;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.Button BIngresar;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LCantQuerubin;
        private System.Windows.Forms.Label LCantBenjamin;
        private System.Windows.Forms.Label LCantInfantil;
        private System.Windows.Forms.Label LCantCadete;
        private System.Windows.Forms.Label LCantJuvenil;
        private System.Windows.Forms.Label LCantAmateur;
        private System.Windows.Forms.Label LCantVeterano;
    }
}

