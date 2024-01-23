using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Work3
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void CompliteButton_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(NumberATextBox.Text, out int a) || !int.TryParse(NumberBTextBox.Text, out int b) || !int.TryParse(NumberCTextBox.Text, out int c))
            {
                MessageBox.Show("Введите целое число");
                return;
            }

            if(a < b && b < c)
            {
                a *= 2; 
                b *= 2;
                c *= 2;
            }
            else
            {
                a = -a; 
                b = -b;
                c = -c;
            }
            AnswerTextBox.Text = $"A = {a}, B = {b}, C = {c}";
        }
    }
}
