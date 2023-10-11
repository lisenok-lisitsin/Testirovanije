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
            int i, j, k;
            if (!int.TryParse(left.Text, out i))
            {
                MessageBox.Show("Нельзя использовать символы, отличные от арабских цифр!");
                reslab.Text = "Нет данных.";
                return;
            }
            else if (!int.TryParse(bottom.Text, out i))
                {
                    MessageBox.Show("Нельзя использовать символы, отличные от арабских цифр!");
                    reslab.Text = "Нет данных.";
                    return;
                }
            else if (!int.TryParse(right.Text, out i))
            {
                MessageBox.Show("Нельзя использовать символы, отличные от арабских цифр!");
                reslab.Text = "Нет данных.";
                return;
            }
            if (string.IsNullOrEmpty(left.Text) || string.IsNullOrEmpty(bottom.Text) || string.IsNullOrEmpty(right.Text))
            {
                MessageBox.Show("Нет значений!");
                reslab.Text = "Нет данных.";
                left.Text = "";
                bottom.Text = "";
                right.Text = "";
            }
            else if (Convert.ToInt32(left.Text) == 0 || Convert.ToInt32(bottom.Text) == 0 || Convert.ToInt32(right.Text) == 0)
            {
                MessageBox.Show("Нет значений!");
                reslab.Text = "Нет данных.";
                left.Text = "";
                bottom.Text = "";
                right.Text = "";
            }
            else
            {
                double a = Convert.ToInt32(left.Text), b = Convert.ToInt32(bottom.Text), c = Convert.ToInt32(right.Text);
                if (a <= 0 || b <= 0 || c <=0 )
                {
                    MessageBox.Show("Отрицательного значения не существует!");
                    reslab.Text = "Нет данных.";
                }
                else
                {
                    if (a == b && a == c && b == c)
                    {
                        if (a == 0 || b == 0 || c == 0)
                        {
                            MessageBox.Show("Нет значений!");
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
                            MessageBox.Show("Нет значений!");
                            reslab.Text = "Нет данных.";
                        }
                        else if ((a + b <= c) || (a + c <= b) || (b + c <= a))
                        {
                            MessageBox.Show("Такого треугольника не существует!");
                            reslab.Text = "Не существует.";
                        }
                        else
                        {
                            reslab.Text = "Треугольник равнобедренный.";
                        }
                    }
                    else if (a != c && b != c)
                    {
                        if (a == 0 || b == 0 || c == 0)
                        {
                            MessageBox.Show("Нет значений!");
                            reslab.Text = "Нет данных.";
                        }
                        else if ((a + b <= c) || (a + c <= b) || (b + c <= a))
                        {
                            MessageBox.Show("Такого треугольника не существует!");
                            reslab.Text = "Не существует.";
                        }
                        else
                        {
                            reslab.Text = "Треугольник разносторонний.";
                        }
                    }
                }
            }    
        }

        private void left_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
