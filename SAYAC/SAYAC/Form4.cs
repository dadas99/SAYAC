using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlTypes;

namespace SAYAC
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FileStream fs = new FileStream(@"C:\yeniklasor\deneme.txt", FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write);
            //StreamWriter sw = new StreamWriter(fs);

            //sw.WriteLine(textBox1.Text);
            //sw.WriteLine(textBox2.Text);

            //sw.Close();
            //fs.Close();
            SqlC.Class1.dosyadanOku();


        }
    }
}
