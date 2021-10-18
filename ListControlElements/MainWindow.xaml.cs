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

namespace ListControlElements
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
        private void View_add_Click(object sender, RoutedEventArgs e)
        {
            view.Items.Add(text_view.Text);
        }

        private void View_del_Click(object sender, RoutedEventArgs e)
        {
            int ind = view.SelectedIndex;
            if (ind != -1)
                view.Items.RemoveAt(ind);
            else MessageBox.Show("Выберите элемент для удаления!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            if (ind != 0)
                view.SelectedIndex = ind - 1;
            else return;

        }

        private void View_red_Click(object sender, RoutedEventArgs e)
        {
            int ind = view.SelectedIndex;
            if (ind != -1)
                view.Items[ind] = text_view.Text;
            else MessageBox.Show("Выберите элемент для изменения!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            view.SelectedIndex = ind;
        }

        private void View_del_all_Click(object sender, RoutedEventArgs e)
        {
            view.Items.Clear();
        }

        private void List_add_Click(object sender, RoutedEventArgs e)
        {
            list.Items.Add(text_list.Text);
        }

        private void List_del_Click(object sender, RoutedEventArgs e)
        {
            int ind = list.SelectedIndex;
            if (ind != -1)
                list.Items.RemoveAt(ind);
            else MessageBox.Show("Выберите элемент для удаления!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            if (ind != 0)
                list.SelectedIndex = ind - 1;
            else return;
        }

        private void List_del_all_Click(object sender, RoutedEventArgs e)
        {
            list.Items.Clear();
        }

        private void List_red_Click(object sender, RoutedEventArgs e)
        {
            int ind = list.SelectedIndex;
            if (ind != -1)
                list.Items[ind] = text_list.Text;
            else MessageBox.Show("Выберите элемент для изменения!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            list.SelectedIndex = ind;
        }

        private void Combo_add_Click(object sender, RoutedEventArgs e)
        {
            combo.Items.Add(text_combo.Text);
            if (combo.Items.Count == 1)
                combo.SelectedIndex = 0;
        }

        private void Combo_del_Click(object sender, RoutedEventArgs e)
        {
            int ind = combo.SelectedIndex;
            if (ind != -1)
                combo.Items.RemoveAt(ind);
            else MessageBox.Show("Выберите элемент для удаления!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            if (ind != 0)
                combo.SelectedIndex = ind - 1;
            else return;
        }

        private void Combo_del_all_Click(object sender, RoutedEventArgs e)
        {
            combo.Items.Clear();
        }

        private void Combo_red_Click(object sender, RoutedEventArgs e)
        {
            int ind = combo.SelectedIndex;
            if (ind != -1)
                combo.Items[ind] = text_combo.Text;
            else MessageBox.Show("Выберите элемент для изменения!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            combo.SelectedIndex = ind;
        }
        ListBox list1 = new ListBox();
        private void Tab_add_Click(object sender, RoutedEventArgs e)
        {
            tab.Items.Add(new TabItem
            {
                Header = new TextBlock { Text = text_tab.Text },
                Content = list1,
            });
            if (tab.Items.Count == 1)
                tab.SelectedIndex = 0;
        }

        private void Tab_del_Click(object sender, RoutedEventArgs e)
        {
            int ind = tab.SelectedIndex;
            if (ind != -1)
                tab.Items.RemoveAt(ind);
            else MessageBox.Show("Выберите элемент для удаления!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            if (ind != 0)
                tab.SelectedIndex = ind - 1;
            else return;
        }

        private void Tab_del_all_Click(object sender, RoutedEventArgs e)
        {
            tab.Items.Clear();
        }

        private void Tab_red_Click(object sender, RoutedEventArgs e)
        {
            int ind = tab.SelectedIndex;
            if (ind != -1)
                ((TabItem)tab.Items[ind]).Header = text_tab.Text;
            else MessageBox.Show("Выберите элемент для изменения!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            tab.SelectedIndex = ind;
        }

        private void List1_add_Click(object sender, RoutedEventArgs e)
        {
            list1.Items.Add(text_tab.Text);
        }

        private void List1_del_Click(object sender, RoutedEventArgs e)
        {
            int ind = list1.SelectedIndex;
            if (ind != -1)
                list1.Items.RemoveAt(ind);
            else MessageBox.Show("Выберите элемент для удаления!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            if (ind != 0)
                list1.SelectedIndex = ind - 1;
            else return;
        }

        private void List1_del_all_Click(object sender, RoutedEventArgs e)
        {
            list1.Items.Clear();
        }

        private void List1_red_Click(object sender, RoutedEventArgs e)
        {
            int ind = list1.SelectedIndex;
            if (ind != -1)
                list1.Items[ind] = text_tab.Text;
            else MessageBox.Show("Выберите элемент для изменения!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            list1.SelectedIndex = ind;
        }
    }
}
