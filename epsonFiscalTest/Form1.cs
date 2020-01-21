using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace epsonFiscalTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Pantalon";
            textBox2.Text = "1000";
            textBox3.Text = "2350";
            textBox4.Text = "2100";
            textBox5.Text = "M";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox13.Text = "0";
            textBox8.Text = "P";
            textBox9.Text = "SUB";
            textBox10.Text = "Card";
            textBox11.Text = "2350";
            textBox12.Text = "T";
            comInput.Text = "1";
            baudRateInput.Text = "9600";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var product = textBox1.Text;
            var quantity = textBox2.Text;
            var price = textBox3.Text;
            var iva = textBox4.Text;
            var venta = textBox5.Text;
            var bundle = textBox6.Text;
            var internalTax = textBox7.Text;
            var taxIncrement = textBox13.Text;
            var printer = textBox8.Text;
            var text = textBox9.Text;
            var paymentType = textBox10.Text;
            var amount = textBox11.Text;
            var description = textBox12.Text;
            short port = Convert.ToInt16(comInput.Text);
            axPrinterFiscal1.PortNumber = port;
            axPrinterFiscal1.BaudRate = baudRateInput.Text;
            axPrinterFiscal1.OpenTicket();
            axPrinterFiscal1.SendTicketItem(ref product, ref quantity, ref price, ref iva, ref venta, ref bundle, ref internalTax, ref taxIncrement);
            axPrinterFiscal1.GetInvoiceSubtotal(ref printer, ref text);
            axPrinterFiscal1.SendTicketPayment(ref paymentType, ref amount, ref description);
            axPrinterFiscal1.CloseTicket();
        }
    }
}
