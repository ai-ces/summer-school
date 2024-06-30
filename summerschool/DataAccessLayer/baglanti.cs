using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient




namespace DataAccessLayer
{
    public class baglanti
    {
        public static SqlConnection bgl = new SqlConnection(@"Data Source=CES\SQLEXPRESS;Initial Catalog=DbSummerSchool;Integreted Security=True");
    }
}
