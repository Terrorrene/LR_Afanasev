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
using System.Threading;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _8ball
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
        private void Answer_Click(object sender, RoutedEventArgs e)
        {
            // Ставим курсор ожидания.
            this.Cursor = Cursors.Wait;
            // Делаем задержку, для создания эффекта того, что программа задумалась.
            Thread.Sleep(TimeSpan.FromSeconds(1));
            // Берем случайный ответ.
            AnswerGenerator answer = new AnswerGenerator();
            txtAnswer.Text = answer.GetRandomAnswer();
            // Восстанавливаем прежнее состояние курсора.
            this.Cursor = null;
        }
        private void txtQuestion_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
        private class AnswerGenerator
        {
            public string GetRandomAnswer()
            {
                string[] answ = { "Я думаю, хорошо.", "Вперёд!", "Ты шутишь?", "Не сейчас.", "Да.", "Нет.", "Лучше Вам пока этого не знать.", "Не делай этого.",
                "Кто знает?", "Конечно, да.","Ни в коем случае.", };
                Random r = new Random();
                int i = r.Next(0, 11);
                return answ[i];
            }
        }
    }
}