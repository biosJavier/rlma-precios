﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RLMA_Precios
{
    public partial class menuView : Form
    {
        public menuView()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clasificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("prueba");
          
        }

        private void actualizarComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clasificacionesForm f1 = new clasificacionesForm();
            f1.Show();
        }
    }
}
