using Payment_Selection.DataAccess;
using Payment_Selection.Payments;
using Payment_Selection.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Payment_Selection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)

        {
            using (var db = new AppDbContext())
            {
                var paymentTypes = db.PaymentTypes.ToList();
                foreach (var item in paymentTypes)
                {
                    comboBox1.Items.Add(item.ClassName);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedType = comboBox1.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(selectedType))
            {
                MessageBox.Show("Lütfen bir ödeme türü seçin.");
                return;
            }

            if (!decimal.TryParse(textBox1.Text, out decimal amount))
            {
                MessageBox.Show("Lütfen geçerli bir fiyat girin.");
                return;
            }

            PaymentFactory factory = new PaymentFactory();
            IPayment payment = factory.CreateInstance(selectedType);

            if (payment != null)
            {
                MessageBox.Show(payment.Pay(amount), "Ödeme Sonucu");
            }
            else
            {
                MessageBox.Show("Sýnýf bulunamadý.");
            }
        }
    }
}
