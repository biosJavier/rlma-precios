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
            query = "SELECT MGW10005.CCODIGOP01 FECHA FROM MGW10005 INNER JOIN MGW10010 ON MGW10005.CIDPRODU01=MGW10010.CIDPRODU01 INNER JOIN clasificaciones ON MGW10005.CIDVALOR02=clasificaciones.ID INNER JOIN MGW10008 ON MGW10010.CIDDOCUM01=MGW10008.CIDDOCUM01 WHERE MGW10010.CIDDOCUM02=19 AND MGW10010.CFECHA={^"+date+"}";
            //28/02/2018 12:00:00 a. m.
            cmd = new OdbcCommand(query, cn);
            cn.Open();

            OdbcDataReader dr = cmd.ExecuteReader();
            int cont = 1;
            while (dr.Read())
            {
                Console.WriteLine(Convert.ToString(dr[0]));
                Console.WriteLine(cont);
                cont++;
            }
        }


    }
}
