using System.Runtime.Serialization;

namespace Exercicio_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ze = 0;
            int numerof = Convert.ToInt32(textBox1.Text);
            for (int i = 1; i <= numerof; i++)
            {
                ze += i;
            }
            MessageBox.Show(" soma = " + ze);

        }
    }
} 