using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_work_1._1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

         double Kvad (double x)
        {
            return (x*x);
        }
         double Expon (double Kvad)
        {
            return (Math.Exp(Kvad));
        }
        double Factorial (double m)
        {
            if (m == 0 || m == 1)
                return 1;
            else
            {
                double l = 1;
                for (double i=1; i <= m; i++)
                {
                    l *= i;
                }
                return l;
            }
        }
        

        private void textBoxStartx_TextChanged(object sender, EventArgs e)
        {
            textBoxStartx.MaxLength = 5; //Макс.размер текстбокса
           
        }

        private void textBoxEndx_TextChanged(object sender, EventArgs e)
        {
            textBoxEndx.MaxLength = 5;
            
        }

        private void textBoxStartx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBoxEndx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBoxStepx_TextChanged(object sender, EventArgs e)
        {
            textBoxStepx.MaxLength = 5;
            

        }

        private void textBoxStepx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)                                    
                e.Handled = true;            
                       
        }

        private void textBoxInputn_TextChanged(object sender, EventArgs e)
        {
            textBoxInputn.MaxLength = 5;
            
        }

        private void textBoxInputn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            textBoxAnswer.Clear();
            double a = Convert.ToDouble(textBoxStartx.Text);
            double b = Convert.ToDouble(textBoxEndx.Text);
            if (b <= 0)
            {
                MessageBox.Show("Введите конечное значение x больше 0");
                textBoxEndx.Focus();

            }

            double s = Convert.ToDouble(textBoxStepx.Text);
            if (s <= 0)
            {
                MessageBox.Show("Введите значение шага больше 0");
                textBoxStepx.Focus();
            }

            double n = Convert.ToDouble(textBoxInputn.Text);
            if (n <= 0)
            {
                MessageBox.Show("Введите значение n больше 0");
                textBoxInputn.Focus();

            }
            double k = 0;
            double F = 0;
            for (double i = a; i <= b;)
            {
                double Y = ((1 + 2 *(a*a)) * Math.Exp(a*a));
                textBoxAnswer.Text += ("\r\n")+("При x=") + Convert.ToString(a) + ("   Y(x)=") + Convert.ToString(Y);
                for (double z = 0; z <= n; z++)
                {
                    double u = 2 * k;
                    double S = (((2 * k) + 1) / Factorial(k)) * Math.Pow(a, u);
                    F=F+S;                    
                    k++;
                }
                textBoxAnswer.Text += ("\r\n") + ("При x=") + Convert.ToString(a) + ("  и n=") + Convert.ToString(n) + ("\r\n")+("S(x)=") + Convert.ToString(F);
                double E = Y - F;
                double G = Math.Abs(E);
                textBoxAnswer.Text += ("\r\n") + ("При x=") + Convert.ToString(a) + ("  G(x)=")+Convert.ToString(G);
                textBoxAnswer.Text += ("\r\n") + ("------------------------------------");
                i =i + s;
                a = a + s;

            }

                                     

        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBoxStartx.Clear(); //Очищает текстбокс
            textBoxEndx.Clear();
            textBoxStepx.Clear();
            textBoxInputn.Clear();
            textBoxAnswer.Clear();
            textBoxStartx.Focus();

        }

        private void textBoxStartx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxStartx.Text == String.Empty)
                    MessageBox.Show("Введите целое число");

                else
                    textBoxEndx.Focus();
            }
        }

        private void textBoxEndx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxEndx.Text == String.Empty) 
                    MessageBox.Show("Введите целое число больше 0");
                else
                    textBoxStepx.Focus();
            }

        }

        private void textBoxStepx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxStepx.Text == String.Empty) 
                    MessageBox.Show("Введите целое число больше 0");
                else
                    textBoxInputn.Focus();
            }

        }

        private void textBoxInputn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxInputn.Text == String.Empty) 
                    MessageBox.Show("Введите целое число больше 0");
                else
                    buttonD.Focus();
            }

        }
    }
}
