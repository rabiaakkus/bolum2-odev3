using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama2_odev3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKulanıcı_Click(object sender, EventArgs e)
        {
            string kullanıcı_adı;
            kullanıcı_adı = txtBox1.Text;
            if (kullanıcı_adı == "milliegitim@meb.k12.tr") ;
            {
                MessageBox.Show("kulanıcı sısteme kayıtlıdır");

            }
            else
            {
                MessageBox.Show("kulanıcı adınız yanlıştır");
            }
        }
    }
}
