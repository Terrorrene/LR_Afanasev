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

namespace Sum_Proizv
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textBox1.Focus();
        }
        public double sum, proiz;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str1, str2, str3;
            str1 = textBox1.Text;
            str2 = textBox2.Text;
            str3 = textBox3.Text;
            if (string.IsNullOrWhiteSpace(str1) == false && string.IsNullOrWhiteSpace(str2) == false && string.IsNullOrWhiteSpace(str3) == false)
            {
                double x = Convert.ToDouble(str1), y = Convert.ToDouble(str2), z = Convert.ToDouble(str3);
                sum = x + y + z;
                proiz = x * y * z;
                button.IsEnabled = true;
                label.Content = sum;
            }
            else MessageBox.Show("Вы не ввели все три числа!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox text = (TextBox)sender;
            if (((e.Key >= Key.D0) && (e.Key <= Key.D9) || (e.Key == Key.Back)
                 || (e.Key >= Key.NumPad0) && (e.Key <= Key.NumPad9))) return;
            if (e.Key == Key.OemMinus && text.Text.IndexOf("-") == -1 && text.SelectionStart == 0) return;
            if (e.Key == Key.OemComma && text.Text.IndexOf(",") == -1) return;
            e.Handled = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (label.Content.ToString() == sum.ToString())
            {
                button.Content = "Увидеть сумму";
                label.Content = proiz;
            }
            else if (label.Content.ToString() == proiz.ToString())
            {
                button.Content = "Увидеть произведение";
                label.Content = sum;
            }
            else MessageBox.Show("Ошибка! Проверьте значения!","Ошибка!");
        }
    }
}
