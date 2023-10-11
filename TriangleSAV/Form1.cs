using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangleSAV
{
    public partial class TriangleForms : Form
    {
        public TriangleForms()
        {
            InitializeComponent();
            reslab.Text = "Здесь будет результат!";
        }

        private void resbut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(left.Text) || string.IsNullOrEmpty(bottom.Text) || string.IsNullOrEmpty(right.Text))
            {
                MessageBox.Show("Нету значений!");
                reslab.Text = "Нет данных.";
            }
            else if (Convert.ToInt32(left.Text) == 0 || Convert.ToInt32(bottom.Text) == 0 || Convert.ToInt32(right.Text) == 0)
            {
                MessageBox.Show("Нету значений!");
                reslab.Text = "Нет данных.";
            }
            else
            {
                double a = Convert.ToInt32(left.Text), b = Convert.ToInt32(bottom.Text), c = Convert.ToInt32(right.Text);
                if (a == b && a == c && b == c)
                {
                    if (a == 0 || b == 0 || c == 0)
                    {
                        MessageBox.Show("Нету значений!");
                        reslab.Text = "Нет данных.";
                    }
                    else
                    {
                        reslab.Text = "Треугольник равносторонний.";
                    }
                }
                else if (a == c && a != b && b != c)
                {
                    if (a == 0 || b == 0 || c == 0)
                    {
                        MessageBox.Show("Нету значений!");
                        reslab.Text = "Нет данных.";
                    }
                    else
                    {
                        reslab.Text = "Треугольник равнобедренный.";
                    }
                }
                else if (a != c && a != b && b != c)
                {
                    if (a == 0 || b == 0 || c == 0)
                    {
                        MessageBox.Show("Нету значений!");
                        reslab.Text = "Нет данных.";
                    }
                    else
                    {
                        reslab.Text = "Треугольник разносторонний.";
                    }
                }
            }    
        }

        private void left_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
