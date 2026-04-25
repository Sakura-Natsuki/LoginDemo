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

namespace LoginDemo
{
    /// <summary>
    /// LoginWindow.xaml 的交互逻辑
    /// </summary>
    public partial class LoginWindow : Window,IViewService
    {
        public LoginWindow()
        {
            InitializeComponent();

            this.DataContext = new LoginViewModel(this);
        }

        void IViewService.Close() => this.Close();
        void IViewService.Hide() => this.Hide();
        void IViewService.Show() => this.Show();
    }
}
