using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace SqlC

{
    class Class1
    {
        public static SqlConnection con = new SqlConnection(@"server=" + "");



        public static void dosyadanOku()
        {
            string dosya_yolu = @"C:\yeniklasor\deneme.txt";
           
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
         
            StreamReader sw = new StreamReader(fs);
            
            string yazi = sw.ReadLine();
            while (yazi != null)
            {

                yazi = sw.ReadLine();
                MessageBox.Show(yazi);
            }
           


            sw.Close();
            fs.Close();
            
        }
    }
}
