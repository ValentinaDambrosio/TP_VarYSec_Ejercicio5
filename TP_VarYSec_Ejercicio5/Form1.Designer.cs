namespace TP_VarYSec_Ejercicio5
{
    partial class fCompra
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
            this.bCerrar = new System.Windows.Forms.Button();
            this.bVuelto = new System.Windows.Forms.Button();
            this.lNombre = new System.Windows.Forms.Label();
            this.lMonto = new System.Windows.Forms.Label();
            this.lPago = new System.Windows.Forms.Label();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tMonto = new System.Windows.Forms.TextBox();
            this.tPago = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(401, 248);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 23);
            this.bCerrar.TabIndex = 0;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // bVuelto
            // 
            this.bVuelto.Location = new System.Drawing.Point(320, 248);
            this.bVuelto.Name = "bVuelto";
            this.bVuelto.Size = new System.Drawing.Size(75, 23);
            this.bVuelto.TabIndex = 1;
            this.bVuelto.Text = "Vuelto";
            this.bVuelto.UseVisualStyleBackColor = true;
            this.bVuelto.Click += new System.EventHandler(this.bVuelto_Click);
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(79, 48);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(47, 13);
            this.lNombre.TabIndex = 2;
            this.lNombre.Text = "Nombre:";
            // 
            // lMonto
            // 
            this.lMonto.AutoSize = true;
            this.lMonto.Location = new System.Drawing.Point(22, 78);
            this.lMonto.Name = "lMonto";
            this.lMonto.Size = new System.Drawing.Size(104, 13);
            this.lMonto.TabIndex = 3;
            this.lMonto.Text = "Monto de la compra:";
            // 
            // lPago
            // 
            this.lPago.AutoSize = true;
            this.lPago.Location = new System.Drawing.Point(89, 105);
            this.lPago.Name = "lPago";
            this.lPago.Size = new System.Drawing.Size(35, 13);
            this.lPago.TabIndex = 4;
            this.lPago.Text = "Pagó:";
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(130, 48);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(100, 20);
            this.tNombre.TabIndex = 5;
            // 
            // tMonto
            // 
            this.tMonto.Location = new System.Drawing.Point(130, 75);
            this.tMonto.Name = "tMonto";
            this.tMonto.Size = new System.Drawing.Size(100, 20);
            this.tMonto.TabIndex = 6;
            // 
            // tPago
            // 
            this.tPago.Location = new System.Drawing.Point(130, 102);
            this.tPago.Name = "tPago";
            this.tPago.Size = new System.Drawing.Size(100, 20);
            this.tPago.TabIndex = 7;
            // 
            // fCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 300);
            this.Controls.Add(this.tPago);
            this.Controls.Add(this.tMonto);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.lPago);
            this.Controls.Add(this.lMonto);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.bVuelto);
            this.Controls.Add(this.bCerrar);
            this.Name = "fCompra";
            this.Text = "Compra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Button bVuelto;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lMonto;
        private System.Windows.Forms.Label lPago;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tMonto;
        private System.Windows.Forms.TextBox tPago;
    }
}

