
using System.Windows.Forms;

namespace LABEXAM
{
    public partial class Form2 : Form
    {
        public Form2(double danielle, double edward, double fatima)
        {
            InitializeComponent();
            label2.Text = "Danielle Total Sales: " + danielle.ToString("N2");
            label3.Text = "Edward Total Sales: " + edward.ToString("N2");
            label4.Text = "Fatima Total Sales: " + fatima.ToString("N2");
            label5.Text = "Total Sales: " + (danielle + edward + fatima).ToString("N2");
        }
    }
}
