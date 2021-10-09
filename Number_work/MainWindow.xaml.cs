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

namespace Number_work
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = chis.Text;
            if (string.IsNullOrWhiteSpace(str) != true)
            {
                if (str.Length == 2)
                {
                    int x = Convert.ToInt32(str);
                    if (x % 3 == 0) kr3.Content = $"Число {x} кратно трём"; else kr3.Content = $"Число {x} не кратно трём";
                    if (x % 2 == 0) chet.Content = $"Число {x} чётное"; else chet.Content = $"Число {x} нечётное";
                    sum.Content = $"Сумма цифр числа {x} равна {x % 10 + x / 10}";
                    pr.Content = $"Произведение цифр числа {x} равно {(x % 10) * (x / 10)}";
                }
                else MessageBox.Show("Число не двузначное!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else MessageBox.Show("Вы не ввели число!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void Chis_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox text = (TextBox)sender;
            if (((e.Key >= Key.D0) && (e.Key <= Key.D9) || (e.Key == Key.Back)
                 || (e.Key >= Key.NumPad0) && (e.Key <= Key.NumPad9))) return;
            e.Handled = true;
        }
    }
}
