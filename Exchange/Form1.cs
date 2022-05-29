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

namespace Exchange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldocument = new XmlDocument();
            xmldocument.Load(today);

            string dollarbuying = xmldocument.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            LblDollarBuy.Text = dollarbuying;

            string dollarselling = xmldocument.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            LblDollarSell.Text = dollarselling;

            string eurobuying = xmldocument.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            LblEuroBuy.Text = eurobuying;

            string euroselling = xmldocument.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            LblEuroSell.Text = euroselling;

        }

        private void BtnDollarBuy_Click(object sender, EventArgs e)
        {
            TxtExchange.Text = LblDollarBuy.Text;
        }

        private void BtnDollarSell_Click(object sender, EventArgs e)
        {
            TxtExchange.Text = LblDollarSell.Text;
        }

        private void BtnEuroBuy_Click(object sender, EventArgs e)
        {
            TxtExchange.Text = LblEuroBuy.Text;
        }

        private void BtnEuroSell_Click(object sender, EventArgs e)
        {
            TxtExchange.Text = LblEuroSell.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double exchangeRate, quantity, total;
            exchangeRate = Convert.ToDouble(TxtExchange.Text);
            quantity = Convert.ToDouble(TxtQuantity.Text);
            total = exchangeRate * quantity;
            TxtPrice.Text = total.ToString();
        }

        private void TxtExchange_TextChanged(object sender, EventArgs e)
        {
            TxtExchange.Text = TxtExchange.Text.Replace(".", ",");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double exchangeRate;
            exchangeRate = Convert.ToDouble(TxtExchange.Text);
           int quantity = Convert.ToInt32(TxtQuantity.Text);
            int total =Convert.ToInt32( quantity / exchangeRate);
            TxtPrice.Text = total.ToString();
            int change = quantity  % total;
            TxtChange.Text = change.ToString();

        }
    }
}
