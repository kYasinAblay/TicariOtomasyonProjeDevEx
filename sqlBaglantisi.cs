using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TicariOtomasyonProje
{
    public class sqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-J724SGE\SQLEXPRESS02;Initial Catalog=DboTicariOtomasyon;Integrated Security=True");
            baglan.Open();

            return baglan;
        }
    }
}
