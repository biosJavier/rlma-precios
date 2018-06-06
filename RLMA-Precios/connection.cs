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

        public void ConnectionMethod()
        {
            cn = new OdbcConnection("Dsn=pape");
            query = "select * from mgw10005";

            cmd = new OdbcCommand(query, cn);
            cn.Open();

            OdbcDataReader dr = cmd.ExecuteReader();

            while (dr.Read()){
                Console.WriteLine(Convert.ToString(dr[1]));
            }
        }


    }
}
