using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
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
            message.Text = "Espere mientras cargan los datos";
            updateTable.Rows.Clear();
            date = calendarT.Value.ToString("yyyy-MM-dd");
            Console.WriteLine("________________________________________________");
            dataProducts();
            //Connection p = new Connection(date);
            //p.prueba();

        }

        private void find_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("prueba22");
        }


        OdbcConnection cn;
        OdbcCommand cmd;
        string query;
        string date;
        public void dataProducts() {
            cn = new OdbcConnection("Dsn=pape");
            query = "SELECT MGW10005.CCODIGOP01, MGW10005.CNOMBREP01," +
                "(MGW10008.CTIPOCAM01*((MGW10010.CPRECIO*((100-MGW10010.CPORCENT06)/100))*((CLASIFICACIONES.FACTOR1/100)+1)))," +
                "(MGW10008.CTIPOCAM01*((MGW10010.CPRECIO*((100-MGW10010.CPORCENT06)/100))*((CLASIFICACIONES.FACTOR2/100)+1)))," +
                "(MGW10008.CTIPOCAM01*((MGW10010.CPRECIO*((100-MGW10010.CPORCENT06)/100))*((CLASIFICACIONES.FACTOR3/100)+1)))," +
                "(MGW10008.CTIPOCAM01*((MGW10010.CPRECIO*((100-MGW10010.CPORCENT06)/100))*((CLASIFICACIONES.FACTOR4/100)+1)))," +
                "(MGW10008.CTIPOCAM01*((MGW10010.CPRECIO*((100-MGW10010.CPORCENT06)/100))*((CLASIFICACIONES.FACTOR5/100)+1)))," +
                "(MGW10008.CTIPOCAM01*((MGW10010.CPRECIO*((100-MGW10010.CPORCENT06)/100))*((CLASIFICACIONES.FACTOR1/100)+1.05)))," +
                "(MGW10008.CTIPOCAM01*((MGW10010.CPRECIO*((100-MGW10010.CPORCENT06)/100))*((CLASIFICACIONES.FACTOR2/100)+1.05)))," +
                "(MGW10008.CTIPOCAM01*((MGW10010.CPRECIO*((100-MGW10010.CPORCENT06)/100))*((CLASIFICACIONES.FACTOR3/100)+1.05)))," +
                "(MGW10008.CTIPOCAM01*((MGW10010.CPRECIO*((100-MGW10010.CPORCENT06)/100))*((CLASIFICACIONES.FACTOR4/100)+1.05)))," +
                "(MGW10008.CTIPOCAM01*((MGW10010.CPRECIO*((100-MGW10010.CPORCENT06)/100))*((CLASIFICACIONES.FACTOR5/100)+1.05))) " +
                "FROM MGW10005 INNER JOIN MGW10010 ON MGW10005.CIDPRODU01=MGW10010.CIDPRODU01 INNER JOIN clasificaciones ON MGW10005.CIDVALOR02=clasificaciones.ID INNER JOIN MGW10008 ON MGW10010.CIDDOCUM01=MGW10008.CIDDOCUM01 WHERE MGW10010.CIDDOCUM02=19 AND MGW10010.CFECHA={^" + date + "}";
            //MGW10008.CTIPOCAM01*((MGW10010.CPRECIO*((100-MGW10010.CPORCENT06)/100))*((FACTOR.FACTOR1/100)+1))

            //28/02/2018 12:00:00 a. m.
            cmd = new OdbcCommand(query, cn);
            cn.Open();
            
            OdbcDataReader dr = cmd.ExecuteReader();
            int cont = 0;
            while (dr.Read())
            {
                Console.WriteLine(Convert.ToString(dr[0]));
                Console.WriteLine(cont);

                updateTable.Rows.Add(Convert.ToString(dr[0]).Trim(), 
                    Convert.ToString(dr[1]), Convert.ToString(Decimal.Round(Convert.ToDecimal(dr[2]), 2)),
                    Convert.ToString(Decimal.Round(Convert.ToDecimal(dr[3]), 2)),
                    Convert.ToString(Decimal.Round(Convert.ToDecimal(dr[4]), 2)),
                    Convert.ToString(Decimal.Round(Convert.ToDecimal(dr[5]), 2)),
                    Convert.ToString(Decimal.Round(Convert.ToDecimal(dr[6]), 2)), 
                    Convert.ToString(Decimal.Round(Convert.ToDecimal(dr[7]), 2)), 
                    Convert.ToString(Decimal.Round(Convert.ToDecimal(dr[8]),2)), 
                    Convert.ToString(Decimal.Round(Convert.ToDecimal(dr[9]), 2)), 
                    Convert.ToString(Decimal.Round(Convert.ToDecimal(dr[10]), 2)), 
                    Convert.ToString(Decimal.Round(Convert.ToDecimal(dr[11]), 2)));
                cont++;
            }
            cn.Close();

            if (cont==0)
            {
                MessageBox.Show("No se encontro ningun produto", "No encontrado",
 MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                message.Text = "Error para carlos";
            }
            else{
                MessageBox.Show("Se encontraron "+cont+" productos", "Encontrado",
 MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                message.Text = "Datos cargados";
            }

        }


        public void updateProdutsRun(string code,int p1,int p2, int p3, int p4, int p5, int p6, int p7, int p8, int p9, int p10)
        {

            cn = new OdbcConnection("Dsn=pape");
            query = "update mgw10005 set " +
                "cprecio1="+ p1 + "," +
                "cprecio2=" + p2 + "," +
                "cprecio3=" + p3 + "," +
                "cprecio4=" + p4 + "," +
                "cprecio5=" + p5 + "," +
                "cprecio6=" + p6 + "," +
                "cprecio7=" + p8 + "," +
                "cprecio8=" + p8 + "," +
                "cprecio9=" + p9 + "," +
                "cprecio10=" + p10 + "" +
                "where CCODIGOP01='" + code+"'";
            //28/02/2018 12:00:00 a. m.
            cmd = new OdbcCommand(query, cn);
            cn.Open();

            int cont = cmd.ExecuteNonQuery();
  

            cn.Close();

        }

        public void runTable()
        {
            int cont =updateTable.Rows.Count;
            if (cont == 0){
                MessageBox.Show("Ya no hay registros en la tabla", "Encontrado",
MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                message.Text = "Datos cargados";
            }
            else
            {
                updateTable.Rows.RemoveAt(0);
            }
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            runTable();
        }
    }
}
