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


        public void updateProdutsRun(string code,string p1, string p2, string p3, string p4, string p5,
            string p6, string p7, string p8, string p9, string p10)
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
            while (updateTable.Rows.Count>0) { 
            if (cont == 0){
                MessageBox.Show("Ya no hay registros en la tabla", "Encontrado",
MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                message.Text = "Datos cargados";
                break;
            }
            else
            {
                string code= updateTable.Rows[0].Cells[0].Value.ToString();
                string p1 = updateTable.Rows[0].Cells[2].Value.ToString();
                string p2 = updateTable.Rows[0].Cells[3].Value.ToString();
                string p3 = updateTable.Rows[0].Cells[4].Value.ToString();
                string p4 = updateTable.Rows[0].Cells[5].Value.ToString();
                string p5 = updateTable.Rows[0].Cells[6].Value.ToString();
                string p6 = updateTable.Rows[0].Cells[7].Value.ToString();
                string p7 = updateTable.Rows[0].Cells[8].Value.ToString();
                string p8 = updateTable.Rows[0].Cells[9].Value.ToString();
                string p9 = updateTable.Rows[0].Cells[10].Value.ToString();
                string p10 = updateTable.Rows[0].Cells[11].Value.ToString();
                updateProdutsRun(code,p1,p2,p3,p4,p5,p6,p7,p8,p9,p10);
                Console.WriteLine(code);
                Console.WriteLine("***********************************************************************************++");
                updateTable.Rows.RemoveAt(0);
            }

            }

            MessageBox.Show("Exito Carlitos", "Productos actualizados",
MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            message.Text = "Datos cargados";
            this.Close();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //UPDATE MGW10005 SET cprecio1=cTemp2.NUEVOPRECIO1,cprecio2=cTemp2.NUEVOPRECIO2,cprecio3=cTemp2.NUEVOPRECIO3,cprecio4=cTemp2.NUEVOPRECIO4,cprecio5=cTemp2.NUEVOPRECIO5,cprecio6=cTemp2.NUEVOPRECIO6,cprecio7=cTemp2.NUEVOPRECIO7,cprecio8=cTemp2.NUEVOPRECIO8,cprecio9=cTemp2.NUEVOPRECIO9,cprecio10=cTemp2.NUEVOPRECIO10 WHERE PRODUCTOS.ccodigop01=cTemp2.CODIGO
            runTable();
        }
    }
}
