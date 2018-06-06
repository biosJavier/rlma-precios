using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLMA_Precios
{
    class Connection
    {
        OdbcConnection cn;
        OdbcCommand cmd;
        string query;
        string date;

        public Connection(string date){
            this.date = date;
        }

        public void ConnectionMethod()
        {
            cn = new OdbcConnection("Dsn=pape");
            query = "select * from mgw10005 where cfecha={^02/28/2018}";

            cmd = new OdbcCommand(query, cn);
            cn.Open();

            OdbcDataReader dr = cmd.ExecuteReader();

            while (dr.Read()){
                Console.WriteLine(Convert.ToString(dr[4]));
            }
        }

        public void prueba()
        {
           
                 cn = new OdbcConnection("Dsn=pape");
            query = "update mgw10005 set cprecio1=22 where CCODIGOP01='AECAI502'";
            //28/02/2018 12:00:00 a. m.
            cmd = new OdbcCommand(query, cn);
            cn.Open();

            int cont = cmd.ExecuteNonQuery();
            if (cont == 1)
            {

            }
            
        }


    }
}
