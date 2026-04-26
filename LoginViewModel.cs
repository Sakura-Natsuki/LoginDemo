using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LoginDemo
{
    internal class LoginViewModel:INotifyPropertyChanged
    {
        public IViewService _viewService;
        public LoginViewModel(IViewService viewService)
        {
            _viewService = viewService;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        LoginModel _loginModel = new LoginModel();
        
        public string PassWord
        {
            get { return _loginModel.PassWord; }
            set
            {
                _loginModel.PassWord = value;
                RaisePropertyChanged("Password");
            }
        }

        public string UserName
        {
            get { return _loginModel.UserName; }
            set
            {
                _loginModel.UserName = value;
                RaisePropertyChanged("UserName");
            }
        }

        void LogInFunc()
        {
            if (UserName == "lxz" && PassWord == "123")
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                _viewService.Close();
            }
            else
            {
                MessageBox.Show("Error");

                UserName = "";
                PassWord = "";
            }
        }

        public bool CanLogIn()
        {
            return true;
        }

        public ICommand LogInAction
        {
            get
            {
                return new RelayCommand(LogInFunc, CanLogIn);
            }
        }
    }
}
