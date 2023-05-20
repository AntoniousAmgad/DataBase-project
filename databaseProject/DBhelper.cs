using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databaseProject
{
    internal class DBhelper
    {
        static SqlConnection conn;
        public static void createCon()
        {
            string constring = ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString;
            conn = new SqlConnection(constring);
            conn.Open();
        }

        public static void insertData(string query) 
        {
            SqlCommand cmd = new SqlCommand(query, conn);

            int a = cmd.ExecuteNonQuery();
            if(a>0)
            {
                MessageBox.Show("Record successfully inserted");
            }
        }
        public static DataTable readData(string query)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);

            return dt;
        }

        public static void updateData(string query) 
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Record successfully inserted");
            }
        }
        public static void closeCon()
        {
            conn.Close();
        }
    }
}
