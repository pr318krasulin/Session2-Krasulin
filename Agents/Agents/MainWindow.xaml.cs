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

namespace Agents
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
            DeleteAgent da = new DeleteAgent();
            this.Close();
            da.Show();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddAgent aa = new AddAgent();
            this.Close();
            aa.Show();
        }

        private void EA_Click(object sender, RoutedEventArgs e)
        {
            Edit ea = new Edit();
            this.Close();
            ea.Show();
        }

    }
    
}
