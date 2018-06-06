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
            this.calendarT = new System.Windows.Forms.DateTimePicker();
            this.updateTable = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.message = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.updateTable)).BeginInit();
            this.SuspendLayout();
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(218, 29);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(105, 23);
            this.find.TabIndex = 1;
            this.find.Text = "Buscar compras";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            this.find.MouseClick += new System.Windows.Forms.MouseEventHandler(this.find_MouseClick);
            // 
            // calendarT
            // 
            this.calendarT.Location = new System.Drawing.Point(12, 29);
            this.calendarT.Name = "calendarT";
            this.calendarT.Size = new System.Drawing.Size(200, 20);
            this.calendarT.TabIndex = 3;
            // 
            // updateTable
            // 
            this.updateTable.AllowUserToAddRows = false;
            this.updateTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updateTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.updateTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.name1,
            this.price1,
            this.price2,
            this.price3,
            this.price4,
            this.price5,
            this.price6,
            this.price7,
            this.price8,
            this.price9,
            this.price10});
            this.updateTable.Location = new System.Drawing.Point(12, 93);
            this.updateTable.Name = "updateTable";
            this.updateTable.ReadOnly = true;
            this.updateTable.RowHeadersVisible = false;
            this.updateTable.Size = new System.Drawing.Size(776, 345);
            this.updateTable.TabIndex = 4;
            // 
            // code
            // 
            this.code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.code.HeaderText = "Codigo del producto";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // name1
            // 
            this.name1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name1.HeaderText = "Nombre";
            this.name1.Name = "name1";
            this.name1.ReadOnly = true;
            // 
            // price1
            // 
            this.price1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.price1.HeaderText = "Precio 1";
            this.price1.Name = "price1";
            this.price1.ReadOnly = true;
            // 
            // price2
            // 
            this.price2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.price2.HeaderText = "Precio 2";
            this.price2.Name = "price2";
            this.price2.ReadOnly = true;
            // 
            // price3
            // 
            this.price3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.price3.HeaderText = "Precio 3";
            this.price3.Name = "price3";
            this.price3.ReadOnly = true;
            // 
            // price4
            // 
            this.price4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.price4.HeaderText = "Precio 4";
            this.price4.Name = "price4";
            this.price4.ReadOnly = true;
            // 
            // price5
            // 
            this.price5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.price5.HeaderText = "Precio 5";
            this.price5.Name = "price5";
            this.price5.ReadOnly = true;
            // 
            // price6
            // 
            this.price6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.price6.HeaderText = "Precio 6";
            this.price6.Name = "price6";
            this.price6.ReadOnly = true;
            // 
            // price7
            // 
            this.price7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.price7.HeaderText = "Precio 7";
            this.price7.Name = "price7";
            this.price7.ReadOnly = true;
            // 
            // price8
            // 
            this.price8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.price8.HeaderText = "Precio 8";
            this.price8.Name = "price8";
            this.price8.ReadOnly = true;
            // 
            // price9
            // 
            this.price9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.price9.HeaderText = "Precio 9";
            this.price9.Name = "price9";
            this.price9.ReadOnly = true;
            // 
            // price10
            // 
            this.price10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.price10.HeaderText = "Precio 10";
            this.price10.Name = "price10";
            this.price10.ReadOnly = true;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(606, 49);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 13);
            this.message.TabIndex = 5;
            this.message.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Guardar en la base de datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clasificacionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.message);
            this.Controls.Add(this.updateTable);
            this.Controls.Add(this.calendarT);
            this.Controls.Add(this.find);
            this.Name = "clasificacionesForm";
            this.Text = "clasificacionesForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.updateTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.DateTimePicker calendarT;
        private System.Windows.Forms.DataGridView updateTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn price1;
        private System.Windows.Forms.DataGridViewTextBoxColumn price2;
        private System.Windows.Forms.DataGridViewTextBoxColumn price3;
        private System.Windows.Forms.DataGridViewTextBoxColumn price4;
        private System.Windows.Forms.DataGridViewTextBoxColumn price5;
        private System.Windows.Forms.DataGridViewTextBoxColumn price6;
        private System.Windows.Forms.DataGridViewTextBoxColumn price7;
        private System.Windows.Forms.DataGridViewTextBoxColumn price8;
        private System.Windows.Forms.DataGridViewTextBoxColumn price9;
        private System.Windows.Forms.DataGridViewTextBoxColumn price10;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Button button1;
    }
}