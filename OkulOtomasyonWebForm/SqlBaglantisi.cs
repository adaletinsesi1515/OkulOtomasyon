using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace OkulOtomasyonWebForm
{
    class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection bgl = new SqlConnection(@"Data Source=ab01500-5000;Initial Catalog=dbo.OkulOtomasyon;Integrated Security=True");
            bgl.Open();
            return bgl;             
        }
    }
}
