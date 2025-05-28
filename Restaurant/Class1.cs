using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class Class1
    {
        public static readonly string con_string = @"Data Source=Win-5FER8EQHEV2; Initial Catalog=Restorant;Persist Security Info=True;";
        public static SqlConnection con = new SqlConnection(con_string);

        public static bool PerdoruesAktiv(string Perdoruesi, string pass)
        {
            bool Aktiv = false;

            string query= "Select * from Perdoruesi where emri = " + "'" + Perdoruesi + "'" + " and password = " + "'" + pass + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                Aktiv = true;
            }
            else
            {
                Aktiv = false;
            }
            return Aktiv;
        }   
    }
}
