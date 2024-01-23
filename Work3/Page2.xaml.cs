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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void CompliteButton_Click(object sender, RoutedEventArgs e)
        {
            int positiveNumber = 0;
            if (!int.TryParse(NumberATextBox.Text, out int a) || !int.TryParse(NumberBTextBox.Text, out int b) || !int.TryParse(NumberCTextBox.Text, out int c))
            {
                MessageBox.Show("Введите целое число");
                return;
            }

            if(a > 0)
            {
                ++positiveNumber;
            }
            if (b > 0)
            {
                ++positiveNumber;
            }
            if (c > 0)
            {
                ++positiveNumber;
            }

            AnswerTextBox.Text = $"{positiveNumber}";
        }
    }
}
