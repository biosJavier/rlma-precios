using System;
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
    public partial class clasificacionesForm : Form
    {
        public clasificacionesForm()
        {
            InitializeComponent();
        }

        private void find_Click(object sender, EventArgs e)
        {
            string date=valCalendar.SelectionStart.Date.ToString("yyyy-MM-dd");
            Console.WriteLine("________________________________________________");
            Connection p = new Connection(date);
            p.prueba();

        }

        private void find_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("prueba22");
        }
    }
}
