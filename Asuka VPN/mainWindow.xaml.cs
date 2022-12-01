using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Asuka_VPN
{
    /// <summary>
    /// Interaction logic for mainWindow.xaml
    /// </summary>
    public partial class mainWindow : Window
    {
        public mainWindow()
        {
            InitializeComponent(); 
            var _mainWindow = Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is mainWindow) as mainWindow;
            this.Border_Fg.Visibility = Visibility.Hidden;
            this.Border_SU.Visibility = Visibility.Hidden;
            this.Border_SI.Visibility = Visibility.Visible;
        }

        private void ExitApplication(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ControlBorderVisible(string controlName)
        {
            string[] borderNames = { "Border_SI", "Border_SU", "Border_Fg" };
            foreach (var borderName in borderNames)
            {
                Border border = this.FindName(borderName) as Border;
                border.Visibility = controlName == borderName ? Visibility.Visible : Visibility.Hidden;
            }
        }
        private void ReturntoSignIn()
        {
            this.Border_SI.Visibility = Visibility.Visible;
            this.Border_Fg.Visibility = Visibility.Hidden;
            this.Border_SU.Visibility = Visibility.Hidden;
        }

        private void Btn_SU_Si_Click(object sender, RoutedEventArgs e)
        {
            ReturntoSignIn();
        }

        private void Btn_Fg_Si_Click(object sender, RoutedEventArgs e)
        {
            ReturntoSignIn();
        }

        private void Btn_SU_Click(object sender, RoutedEventArgs e)
        {
            ControlBorderVisible("Border_SU");
        }

        private void Btn_SI_Forget_Click(object sender, RoutedEventArgs e)
        {
            ControlBorderVisible("Border_Fg");
        }
        private void Btn_SI_Exit_Click(object sender, RoutedEventArgs e)
        { 
            Close();
        }
        private void Btn_Fg_Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Btn_SU_Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Btn_SI_Si_Click(object sender, RoutedEventArgs e)
        {
            programWindow pgWin = new programWindow();
            pgWin.Show();
            this.Close();
        }
    }
}
