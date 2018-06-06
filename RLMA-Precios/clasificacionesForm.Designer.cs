namespace RLMA_Precios
{
    partial class clasificacionesForm
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
            this.find = new System.Windows.Forms.Button();
            this.valCalendar = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(269, 4);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(105, 23);
            this.find.TabIndex = 1;
            this.find.Text = "Buscar compras";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            this.find.MouseClick += new System.Windows.Forms.MouseEventHandler(this.find_MouseClick);
            // 
            // valCalendar
            // 
            this.valCalendar.Location = new System.Drawing.Point(9, 4);
            this.valCalendar.Name = "valCalendar";
            this.valCalendar.TabIndex = 2;
            // 
            // clasificacionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.valCalendar);
            this.Controls.Add(this.find);
            this.Name = "clasificacionesForm";
            this.Text = "clasificacionesForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.MonthCalendar valCalendar;
    }
}