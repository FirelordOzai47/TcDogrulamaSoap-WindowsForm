using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcDogrulamaSoap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long kimlikno = long.Parse(txtTc.Text);
            int yil = int.Parse(txtYil.Text);
            bool durum;

            try
            {
                using (TcDogrula.KPSPublicSoapClient service = new TcDogrula.KPSPublicSoapClient { })
                {
                    durum = service.TCKimlikNoDogrula(kimlikno, txtAd.Text, txtSoyad.Text, yil);
                }
            }
            catch (Exception)
            {

                throw;
            }
            if (durum==true)
            {
                MessageBox.Show("Kayıt başarılı");

            }
            else
            {
                MessageBox.Show("Girilen veriler yanlış");

            }
        }
    }
}
