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
using practica1.DuDataSetTableAdapters;

namespace practica1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        losersTableAdapter colour = new losersTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            ColoreDataGrid.ItemsSource = colour.GetData();

        }
    }
}
