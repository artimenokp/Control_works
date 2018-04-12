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
            int a = Convert.ToInt32(textBoxStartx.Text);
            int b = Convert.ToInt32(textBoxEndx.Text);
            if (b <= 0)
            {
                MessageBox.Show("Введите конечное значение x больше 0");
                textBoxEndx.Focus();

            }            
                           
            int s = Convert.ToInt32(textBoxStepx.Text);
            if (s <= 0)
            {
                MessageBox.Show("Введите значение шага больше 0");
                textBoxStepx.Focus();
            }
                
            int n = Convert.ToInt32(textBoxInputn.Text);
            if (n <= 0)
            {
                MessageBox.Show("Введите значение n больше 0");
                textBoxInputn.Focus();

            }
                
               
                




        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBoxStartx.Clear(); //Очищает текстбокс
            textBoxEndx.Clear();
            textBoxStepx.Clear();
            textBoxInputn.Clear();
            textBoxAnswer.Clear();

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
