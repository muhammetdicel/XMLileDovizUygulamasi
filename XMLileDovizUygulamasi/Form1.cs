using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XMLileDovizUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya= new XmlDocument();
            xmldosya.Load(bugun);

            string dolaralis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            LblDolarAlıs.Text = dolaralis;


            string dolarsatıs = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            LblDolarSatıs.Text = dolarsatıs;

            string euroalıs = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            LblEuroAlıs.Text = euroalıs;

            string eurosatıs = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            LblEuroSatıs.Text = eurosatıs;
        }

        private void BtnDolarAlıs_Click(object sender, EventArgs e)
        {
            TxtKur.Text = LblDolarAlıs.Text ;           
        }

        private void BtnDolarSat_Click(object sender, EventArgs e)
        {
            TxtKur.Text = LblDolarSatıs.Text;
        }

        private void BtnEuroAlıs_Click(object sender, EventArgs e)
        {
            TxtKur.Text = LblEuroAlıs.Text;
        }

        private void BtnEuroSatıs_Click(object sender, EventArgs e)
        {
            TxtKur.Text = LblEuroSatıs.Text;
        }

        private void BtnIslemYap_Click(object sender, EventArgs e)
        {
            double kur, miktar, toplam;
            kur = Convert.ToDouble(TxtKur.Text);
            miktar=Convert.ToDouble(TxtMiktar.Text);
            toplam = kur * miktar;
            TxtTutar.Text = toplam.ToString();
        }

        private void TxtKur_TextChanged(object sender, EventArgs e)
        {
            TxtKur.Text = TxtKur.Text.Replace(".", ",");
        }

        private void BtnSatısYap_Click(object sender, EventArgs e)
        {
            double kur = Convert.ToDouble(TxtKur.Text);
            int miktar = Convert.ToInt32(TxtMiktar.Text);
            int tutar = Convert.ToInt32(miktar / kur);
            TxtTutar.Text = tutar.ToString();
            double kalan;
            kalan = miktar % kur;
            TxtKalan.Text= kalan.ToString();
        }
    }
}
