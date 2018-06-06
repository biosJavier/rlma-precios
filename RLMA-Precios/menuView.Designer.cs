namespace RLMA_Precios
{
    partial class menuView
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clasificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clasificacionesToolStripMenuItem,
            this.actualizarComprasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clasificacionesToolStripMenuItem
            // 
            this.clasificacionesToolStripMenuItem.Name = "clasificacionesToolStripMenuItem";
            this.clasificacionesToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.clasificacionesToolStripMenuItem.Text = "Valores de factores";
            this.clasificacionesToolStripMenuItem.Click += new System.EventHandler(this.clasificacionesToolStripMenuItem_Click);
            // 
            // actualizarComprasToolStripMenuItem
            // 
            this.actualizarComprasToolStripMenuItem.Name = "actualizarComprasToolStripMenuItem";
            this.actualizarComprasToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.actualizarComprasToolStripMenuItem.Text = "Actualizar compras";
            this.actualizarComprasToolStripMenuItem.Click += new System.EventHandler(this.actualizarComprasToolStripMenuItem_Click);
            // 
            // menuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menuView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizacion de precios -RLMA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clasificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarComprasToolStripMenuItem;
    }
}

