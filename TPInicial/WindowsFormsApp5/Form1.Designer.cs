namespace WindowsFormsApp5
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
            this.btnejecutar = new System.Windows.Forms.Button();
            this.bttnsalir = new System.Windows.Forms.Button();
            this.Chk1 = new System.Windows.Forms.CheckBox();
            this.Chk2 = new System.Windows.Forms.CheckBox();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnejecutar
            // 
            this.btnejecutar.Location = new System.Drawing.Point(28, 200);
            this.btnejecutar.Name = "btnejecutar";
            this.btnejecutar.Size = new System.Drawing.Size(75, 23);
            this.btnejecutar.TabIndex = 0;
            this.btnejecutar.Text = "Ejecutar";
            this.btnejecutar.UseVisualStyleBackColor = true;
            this.btnejecutar.Click += new System.EventHandler(this.btnejecutar_Click);
            // 
            // bttnsalir
            // 
            this.bttnsalir.Location = new System.Drawing.Point(240, 200);
            this.bttnsalir.Name = "bttnsalir";
            this.bttnsalir.Size = new System.Drawing.Size(75, 23);
            this.bttnsalir.TabIndex = 1;
            this.bttnsalir.Text = "Salir";
            this.bttnsalir.UseVisualStyleBackColor = true;
            this.bttnsalir.Click += new System.EventHandler(this.bttnsalir_Click);
            // 
            // Chk1
            // 
            this.Chk1.AutoSize = true;
            this.Chk1.Location = new System.Drawing.Point(23, 165);
            this.Chk1.Name = "Chk1";
            this.Chk1.Size = new System.Drawing.Size(84, 17);
            this.Chk1.TabIndex = 2;
            this.Chk1.Text = "1ra elección";
            this.Chk1.UseVisualStyleBackColor = true;
            this.Chk1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Chk2
            // 
            this.Chk2.AutoSize = true;
            this.Chk2.Location = new System.Drawing.Point(235, 165);
            this.Chk2.Name = "Chk2";
            this.Chk2.Size = new System.Drawing.Size(87, 17);
            this.Chk2.TabIndex = 3;
            this.Chk2.Text = "2da elección";
            this.Chk2.UseVisualStyleBackColor = true;
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.BackColor = System.Drawing.Color.Red;
            this.Lbl1.Location = new System.Drawing.Point(161, 44);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(43, 13);
            this.Lbl1.TabIndex = 4;
            this.Lbl1.Text = "------------";
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.BackColor = System.Drawing.Color.Red;
            this.Lbl2.Location = new System.Drawing.Point(161, 88);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(43, 13);
            this.Lbl2.TabIndex = 5;
            this.Lbl2.Text = "------------";
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.BackColor = System.Drawing.Color.Red;
            this.Lbl3.Location = new System.Drawing.Point(161, 130);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(43, 13);
            this.Lbl3.TabIndex = 6;
            this.Lbl3.Text = "------------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 248);
            this.Controls.Add(this.Lbl3);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.Chk2);
            this.Controls.Add(this.Chk1);
            this.Controls.Add(this.bttnsalir);
            this.Controls.Add(this.btnejecutar);
            this.Name = "Form1";
            this.Text = "Manejo de Checkbox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnejecutar;
        private System.Windows.Forms.Button bttnsalir;
        private System.Windows.Forms.CheckBox Chk1;
        private System.Windows.Forms.CheckBox Chk2;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label Lbl3;
    }
}

