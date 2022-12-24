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

namespace login
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string username = "rubhy";
        string password ="1234";
        int retry = 0;
      
        public MainWindow()
        {
            InitializeComponent();

            txtusername.TabIndex = 1;
            pwdvalue.TabIndex = 2;
        }
         
            private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(username ==txtusername.Text && password ==pwdvalue.Password)
            {
                MessageBox.Show("Hi Welcome, Successfully loged in", "login");
            }
            else
            {
                if (retry == 0)
                {
                    MessageBoxResult msgresult = MessageBox.Show("your user name and password is incorrect!!do you want to retry","login",MessageBoxButton.YesNo, MessageBoxImage.Error);
                   if(msgresult == MessageBoxResult.Yes)
                    {
                        retry++;
                        txtusername.Clear();
                        pwdvalue.Clear();
                    }
                }
                else if(retry== 1)
                    {
                    MessageBoxResult msgresult = MessageBox.Show("warning! incorrect username and password.do you want to retry","login", MessageBoxButton.YesNo ,MessageBoxImage.Warning);
                    if (msgresult == MessageBoxResult.Yes)
                    {
                        retry++;
                        txtusername.Clear();
                        pwdvalue.Clear();
                    }
                }
                else if(retry ==2)
                {
                    MessageBoxResult msgresult = MessageBox.Show("your id is locked.try after sometime","login",MessageBoxButton.OK ,MessageBoxImage.Stop);
                    if (msgresult == MessageBoxResult.OK)
                    {
                      txtusername.IsEnabled = false;
                        pwdvalue.IsEnabled = false;
                        btlogin.IsEnabled = false;
                        btsignup.IsEnabled = false;
                    }
                }

            }
            

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
