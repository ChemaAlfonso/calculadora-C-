namespace Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TbResultado = new System.Windows.Forms.TextBox();
            this.BtSuma = new System.Windows.Forms.Button();
            this.BtResta = new System.Windows.Forms.Button();
            this.BtSqrt = new System.Windows.Forms.Button();
            this.BtDivision = new System.Windows.Forms.Button();
            this.BtMultiplicacion = new System.Windows.Forms.Button();
            this.BtIgual = new System.Windows.Forms.Button();
            this.BtPow = new System.Windows.Forms.Button();
            this.BtModulo = new System.Windows.Forms.Button();
            this.BtDel = new System.Windows.Forms.Button();
            this.BtCe = new System.Windows.Forms.Button();
            this.BtCero = new System.Windows.Forms.Button();
            this.BtNueve = new System.Windows.Forms.Button();
            this.BtSiete = new System.Windows.Forms.Button();
            this.BtOcho = new System.Windows.Forms.Button();
            this.BtCuatro = new System.Windows.Forms.Button();
            this.BtCinco = new System.Windows.Forms.Button();
            this.BtSeis = new System.Windows.Forms.Button();
            this.BtUno = new System.Windows.Forms.Button();
            this.BtDos = new System.Windows.Forms.Button();
            this.BtTres = new System.Windows.Forms.Button();
            this.BtPrint = new System.Windows.Forms.Button();
            this.BtnDouble = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbResultado
            // 
            this.TbResultado.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbResultado.Location = new System.Drawing.Point(24, 12);
            this.TbResultado.Name = "TbResultado";
            this.TbResultado.Size = new System.Drawing.Size(570, 52);
            this.TbResultado.TabIndex = 0;
            this.TbResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtSuma
            // 
            this.BtSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSuma.Location = new System.Drawing.Point(312, 86);
            this.BtSuma.Name = "BtSuma";
            this.BtSuma.Size = new System.Drawing.Size(90, 72);
            this.BtSuma.TabIndex = 8;
            this.BtSuma.Text = "+";
            this.BtSuma.UseVisualStyleBackColor = true;
            this.BtSuma.Click += new System.EventHandler(this.BtSuma_Click);
            // 
            // BtResta
            // 
            this.BtResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtResta.Location = new System.Drawing.Point(408, 86);
            this.BtResta.Name = "BtResta";
            this.BtResta.Size = new System.Drawing.Size(90, 72);
            this.BtResta.TabIndex = 9;
            this.BtResta.Text = "-";
            this.BtResta.UseVisualStyleBackColor = true;
            this.BtResta.Click += new System.EventHandler(this.BtResta_Click);
            // 
            // BtSqrt
            // 
            this.BtSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSqrt.Location = new System.Drawing.Point(504, 86);
            this.BtSqrt.Name = "BtSqrt";
            this.BtSqrt.Size = new System.Drawing.Size(90, 72);
            this.BtSqrt.TabIndex = 11;
            this.BtSqrt.Text = "√ ";
            this.BtSqrt.UseVisualStyleBackColor = true;
            this.BtSqrt.Click += new System.EventHandler(this.BtSqrt_Click);
            // 
            // BtDivision
            // 
            this.BtDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDivision.Location = new System.Drawing.Point(408, 164);
            this.BtDivision.Name = "BtDivision";
            this.BtDivision.Size = new System.Drawing.Size(90, 72);
            this.BtDivision.TabIndex = 12;
            this.BtDivision.Text = "/";
            this.BtDivision.UseVisualStyleBackColor = true;
            this.BtDivision.Click += new System.EventHandler(this.BtDivision_Click);
            // 
            // BtMultiplicacion
            // 
            this.BtMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtMultiplicacion.Location = new System.Drawing.Point(312, 164);
            this.BtMultiplicacion.Name = "BtMultiplicacion";
            this.BtMultiplicacion.Size = new System.Drawing.Size(90, 72);
            this.BtMultiplicacion.TabIndex = 13;
            this.BtMultiplicacion.Text = "*";
            this.BtMultiplicacion.UseVisualStyleBackColor = true;
            this.BtMultiplicacion.Click += new System.EventHandler(this.BtMultiplicacion_Click);
            // 
            // BtIgual
            // 
            this.BtIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtIgual.Location = new System.Drawing.Point(408, 320);
            this.BtIgual.Name = "BtIgual";
            this.BtIgual.Size = new System.Drawing.Size(186, 72);
            this.BtIgual.TabIndex = 14;
            this.BtIgual.Text = "=";
            this.BtIgual.UseVisualStyleBackColor = true;
            this.BtIgual.Click += new System.EventHandler(this.BtIgual_Click);
            // 
            // BtPow
            // 
            this.BtPow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtPow.Location = new System.Drawing.Point(504, 242);
            this.BtPow.Name = "BtPow";
            this.BtPow.Size = new System.Drawing.Size(90, 72);
            this.BtPow.TabIndex = 15;
            this.BtPow.Text = "ⁿ";
            this.BtPow.UseVisualStyleBackColor = true;
            this.BtPow.Click += new System.EventHandler(this.BtPow_Click);
            // 
            // BtModulo
            // 
            this.BtModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtModulo.Location = new System.Drawing.Point(504, 164);
            this.BtModulo.Name = "BtModulo";
            this.BtModulo.Size = new System.Drawing.Size(90, 72);
            this.BtModulo.TabIndex = 16;
            this.BtModulo.Text = "%";
            this.BtModulo.UseVisualStyleBackColor = true;
            this.BtModulo.Click += new System.EventHandler(this.BtModulo_Click);
            // 
            // BtDel
            // 
            this.BtDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDel.Location = new System.Drawing.Point(312, 320);
            this.BtDel.Name = "BtDel";
            this.BtDel.Size = new System.Drawing.Size(90, 72);
            this.BtDel.TabIndex = 17;
            this.BtDel.Text = "Del";
            this.BtDel.UseVisualStyleBackColor = true;
            this.BtDel.Click += new System.EventHandler(this.BtDel_Click);
            // 
            // BtCe
            // 
            this.BtCe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCe.Location = new System.Drawing.Point(312, 242);
            this.BtCe.Name = "BtCe";
            this.BtCe.Size = new System.Drawing.Size(90, 72);
            this.BtCe.TabIndex = 18;
            this.BtCe.Text = "CE";
            this.BtCe.UseVisualStyleBackColor = true;
            this.BtCe.Click += new System.EventHandler(this.BtCe_Click);
            // 
            // BtCero
            // 
            this.BtCero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCero.Location = new System.Drawing.Point(24, 320);
            this.BtCero.Name = "BtCero";
            this.BtCero.Size = new System.Drawing.Size(186, 72);
            this.BtCero.TabIndex = 19;
            this.BtCero.Text = "0";
            this.BtCero.UseVisualStyleBackColor = true;
            this.BtCero.Click += new System.EventHandler(this.BtCero_Click);
            // 
            // BtNueve
            // 
            this.BtNueve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtNueve.Location = new System.Drawing.Point(216, 242);
            this.BtNueve.Name = "BtNueve";
            this.BtNueve.Size = new System.Drawing.Size(90, 72);
            this.BtNueve.TabIndex = 20;
            this.BtNueve.Text = "9";
            this.BtNueve.UseVisualStyleBackColor = true;
            this.BtNueve.Click += new System.EventHandler(this.BtNueve_Click);
            // 
            // BtSiete
            // 
            this.BtSiete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSiete.Location = new System.Drawing.Point(24, 242);
            this.BtSiete.Name = "BtSiete";
            this.BtSiete.Size = new System.Drawing.Size(90, 72);
            this.BtSiete.TabIndex = 21;
            this.BtSiete.Text = "7";
            this.BtSiete.UseVisualStyleBackColor = true;
            this.BtSiete.Click += new System.EventHandler(this.BtSiete_Click);
            // 
            // BtOcho
            // 
            this.BtOcho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtOcho.Location = new System.Drawing.Point(120, 242);
            this.BtOcho.Name = "BtOcho";
            this.BtOcho.Size = new System.Drawing.Size(90, 72);
            this.BtOcho.TabIndex = 22;
            this.BtOcho.Text = "8";
            this.BtOcho.UseVisualStyleBackColor = true;
            this.BtOcho.Click += new System.EventHandler(this.BtOcho_Click);
            // 
            // BtCuatro
            // 
            this.BtCuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCuatro.Location = new System.Drawing.Point(24, 164);
            this.BtCuatro.Name = "BtCuatro";
            this.BtCuatro.Size = new System.Drawing.Size(90, 72);
            this.BtCuatro.TabIndex = 23;
            this.BtCuatro.Text = "4";
            this.BtCuatro.UseVisualStyleBackColor = true;
            this.BtCuatro.Click += new System.EventHandler(this.BtCuatro_Click);
            // 
            // BtCinco
            // 
            this.BtCinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCinco.Location = new System.Drawing.Point(120, 164);
            this.BtCinco.Name = "BtCinco";
            this.BtCinco.Size = new System.Drawing.Size(90, 72);
            this.BtCinco.TabIndex = 24;
            this.BtCinco.Text = "5";
            this.BtCinco.UseVisualStyleBackColor = true;
            this.BtCinco.Click += new System.EventHandler(this.BtCinco_Click);
            // 
            // BtSeis
            // 
            this.BtSeis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSeis.Location = new System.Drawing.Point(216, 164);
            this.BtSeis.Name = "BtSeis";
            this.BtSeis.Size = new System.Drawing.Size(90, 72);
            this.BtSeis.TabIndex = 25;
            this.BtSeis.Text = "6";
            this.BtSeis.UseVisualStyleBackColor = true;
            this.BtSeis.Click += new System.EventHandler(this.BtSeis_Click);
            // 
            // BtUno
            // 
            this.BtUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtUno.Location = new System.Drawing.Point(24, 86);
            this.BtUno.Name = "BtUno";
            this.BtUno.Size = new System.Drawing.Size(90, 72);
            this.BtUno.TabIndex = 26;
            this.BtUno.Text = "1";
            this.BtUno.UseVisualStyleBackColor = true;
            this.BtUno.Click += new System.EventHandler(this.BtUno_Click);
            // 
            // BtDos
            // 
            this.BtDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDos.Location = new System.Drawing.Point(120, 86);
            this.BtDos.Name = "BtDos";
            this.BtDos.Size = new System.Drawing.Size(90, 72);
            this.BtDos.TabIndex = 27;
            this.BtDos.Text = "2";
            this.BtDos.UseVisualStyleBackColor = true;
            this.BtDos.Click += new System.EventHandler(this.BtDos_Click);
            // 
            // BtTres
            // 
            this.BtTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtTres.Location = new System.Drawing.Point(216, 86);
            this.BtTres.Name = "BtTres";
            this.BtTres.Size = new System.Drawing.Size(90, 72);
            this.BtTres.TabIndex = 28;
            this.BtTres.Text = "3";
            this.BtTres.UseVisualStyleBackColor = true;
            this.BtTres.Click += new System.EventHandler(this.BtTres_Click);
            // 
            // BtPrint
            // 
            this.BtPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtPrint.Location = new System.Drawing.Point(408, 242);
            this.BtPrint.Name = "BtPrint";
            this.BtPrint.Size = new System.Drawing.Size(90, 72);
            this.BtPrint.TabIndex = 29;
            this.BtPrint.Text = "Print";
            this.BtPrint.UseVisualStyleBackColor = true;
            this.BtPrint.Click += new System.EventHandler(this.BtPrint_Click);
            // 
            // BtnDouble
            // 
            this.BtnDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDouble.Location = new System.Drawing.Point(216, 320);
            this.BtnDouble.Name = "BtnDouble";
            this.BtnDouble.Size = new System.Drawing.Size(90, 72);
            this.BtnDouble.TabIndex = 30;
            this.BtnDouble.Text = ".";
            this.BtnDouble.UseVisualStyleBackColor = true;
            this.BtnDouble.Click += new System.EventHandler(this.BtnDouble_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 411);
            this.Controls.Add(this.BtnDouble);
            this.Controls.Add(this.BtPrint);
            this.Controls.Add(this.BtTres);
            this.Controls.Add(this.BtDos);
            this.Controls.Add(this.BtUno);
            this.Controls.Add(this.BtSeis);
            this.Controls.Add(this.BtCinco);
            this.Controls.Add(this.BtCuatro);
            this.Controls.Add(this.BtOcho);
            this.Controls.Add(this.BtSiete);
            this.Controls.Add(this.BtNueve);
            this.Controls.Add(this.BtCero);
            this.Controls.Add(this.BtCe);
            this.Controls.Add(this.BtDel);
            this.Controls.Add(this.BtModulo);
            this.Controls.Add(this.BtPow);
            this.Controls.Add(this.BtIgual);
            this.Controls.Add(this.BtMultiplicacion);
            this.Controls.Add(this.BtDivision);
            this.Controls.Add(this.BtSqrt);
            this.Controls.Add(this.BtResta);
            this.Controls.Add(this.BtSuma);
            this.Controls.Add(this.TbResultado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbResultado;
        private System.Windows.Forms.Button BtSuma;
        private System.Windows.Forms.Button BtResta;
        private System.Windows.Forms.Button BtSqrt;
        private System.Windows.Forms.Button BtDivision;
        private System.Windows.Forms.Button BtMultiplicacion;
        private System.Windows.Forms.Button BtIgual;
        private System.Windows.Forms.Button BtPow;
        private System.Windows.Forms.Button BtModulo;
        private System.Windows.Forms.Button BtDel;
        private System.Windows.Forms.Button BtCe;
        private System.Windows.Forms.Button BtCero;
        private System.Windows.Forms.Button BtNueve;
        private System.Windows.Forms.Button BtSiete;
        private System.Windows.Forms.Button BtOcho;
        private System.Windows.Forms.Button BtCuatro;
        private System.Windows.Forms.Button BtCinco;
        private System.Windows.Forms.Button BtSeis;
        private System.Windows.Forms.Button BtUno;
        private System.Windows.Forms.Button BtDos;
        private System.Windows.Forms.Button BtTres;
        private System.Windows.Forms.Button BtPrint;
        private System.Windows.Forms.Button BtnDouble;
    }
}

