using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Hastane
{
    public class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
           
           SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-SP67UG4\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
