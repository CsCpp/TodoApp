using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using TodoApp.Models;

namespace TodoApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BindingList<TodoModel> _todoDate;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _todoDate = new BindingList<TodoModel>() { 
            new TodoModel(){Text="test"},
            new TodoModel(){Text="2 not test end"}
            };
            dtTodoList.ItemsSource = _todoDate;

            _todoDate.ListChanged += _todoDate_ListChanged;

        }//Window_Loade

        private void _todoDate_ListChanged(object sender, ListChangedEventArgs e)
        {
            if(e.ListChangedType==ListChangedType.ItemDeleted || e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType== ListChangedType.ItemChanged)
            {
                return;
            }
          
        }
    }
}
