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

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedType = comboBox1.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(selectedType))
            {
                lblResult.Text = "Please select a payment type.";
                return;
            }

            if (!decimal.TryParse(textBox1.Text, out decimal amount))
            {
                lblResult.Text = "Please enter a valid price.";
                return;
            }

            PaymentFactory factory = new PaymentFactory();
            IPayment payment = factory.CreateInstance(selectedType);

            if (payment != null)
            {
                lblResult.Text = payment.Pay(amount);
            }
            else
            {
                lblResult.Text = "Payment type could not be created.";
            }
        }

    }
}
