
using System;
using System.Windows.Forms;

namespace LABEXAM
{
    public partial class Form1 : Form
    {
        double danielle = 0;
        double edward = 0;
        double fatima = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string initial = textBox1.Text.Trim().ToUpper();
            double amount;

            if (double.TryParse(textBox2.Text, out amount)
                && amount > 0)
            {
                if (initial == "D")
                {
                    danielle += amount;
                    MessageBox.Show("Danielle Sales Added!");
                }
                else if (initial == "E")
                {
                    edward += amount;
                    MessageBox.Show("Edward Sales Added!");
                }
                else if (initial == "F")
                {
                    fatima += amount;
                    MessageBox.Show("Fatima Sales Added!");
                }
                else
                {
                    MessageBox.Show("Invalid Initial! Use D, E, or F.");
                    return;
                }

                label6.Text =
                    "Results\n\n" +
                    "Danielle: " + danielle.ToString("N2") + "\n" +
                    "Edward: " + edward.ToString("N2") + "\n" +
                    "Fatima: " + fatima.ToString("N2");

                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Please enter a valid amount!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

            danielle = 0;
            edward = 0;
            fatima = 0;

            label6.Text = "Results";
            textBox1.Focus();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Form2 report = new Form2(danielle, edward, fatima);
            report.ShowDialog();
        }
    }
}
