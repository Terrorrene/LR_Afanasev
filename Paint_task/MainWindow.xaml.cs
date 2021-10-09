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
using System.Windows.Ink;

namespace Paint_task
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

        private void lstEditingMode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            /* foreach (InkCanvasEditingMode mode in
            Enum.GetValues(typeof(InkCanvasEditingMode)))
                 lstEditingMode.Items.Add(mode);
             lstEditingMode.SelectedItem = inkCanvas.EditingMode;*/
            lstEditingMode.Items.Add(InkCanvasEditingMode.Ink);
            lstEditingMode.Items.Add(InkCanvasEditingMode.EraseByPoint);
            lstEditingMode.Items.Add(InkCanvasEditingMode.EraseByStroke);
            lstEditingMode.SelectedItem = inkCanvas.EditingMode;
        }
    }
}
