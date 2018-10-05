namespace Chronometer
{
    partial class FormChronometer
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
            this.LUnitSecond = new System.Windows.Forms.Label();
            this.LTenSecond = new System.Windows.Forms.Label();
            this.LUnitMinute = new System.Windows.Forms.Label();
            this.LTenMinute = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LUnitSecond
            // 
            this.LUnitSecond.AutoSize = true;
            this.LUnitSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUnitSecond.Location = new System.Drawing.Point(460, 89);
            this.LUnitSecond.Name = "LUnitSecond";
            this.LUnitSecond.Size = new System.Drawing.Size(63, 69);
            this.LUnitSecond.TabIndex = 0;
            this.LUnitSecond.Text = "0";
            // 
            // LTenSecond
            // 
            this.LTenSecond.AutoSize = true;
            this.LTenSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTenSecond.Location = new System.Drawing.Point(404, 89);
            this.LTenSecond.Name = "LTenSecond";
            this.LTenSecond.Size = new System.Drawing.Size(63, 69);
            this.LTenSecond.TabIndex = 1;
            this.LTenSecond.Text = "0";
            // 
            // LUnitMinute
            // 
            this.LUnitMinute.AutoSize = true;
            this.LUnitMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUnitMinute.Location = new System.Drawing.Point(299, 89);
            this.LUnitMinute.Name = "LUnitMinute";
            this.LUnitMinute.Size = new System.Drawing.Size(63, 69);
            this.LUnitMinute.TabIndex = 0;
            this.LUnitMinute.Text = "0";
            // 
            // LTenMinute
            // 
            this.LTenMinute.AutoSize = true;
            this.LTenMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTenMinute.Location = new System.Drawing.Point(243, 89);
            this.LTenMinute.Name = "LTenMinute";
            this.LTenMinute.Size = new System.Drawing.Size(63, 69);
            this.LTenMinute.TabIndex = 1;
            this.LTenMinute.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(360, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 69);
            this.label2.TabIndex = 3;
            this.label2.Text = ":";
            // 
            // FormChronometer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 275);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LTenMinute);
            this.Controls.Add(this.LUnitMinute);
            this.Controls.Add(this.LTenSecond);
            this.Controls.Add(this.LUnitSecond);
            this.Name = "FormChronometer";
            this.Text = "Chronometer";
            this.Load += new System.EventHandler(this.FormChronometer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LUnitSecond;
        private System.Windows.Forms.Label LTenSecond;
        private System.Windows.Forms.Label LUnitMinute;
        private System.Windows.Forms.Label LTenMinute;
        private System.Windows.Forms.Label label2;
    }
}

