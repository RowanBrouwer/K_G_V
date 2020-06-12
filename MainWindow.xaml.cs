using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

namespace K_G_V
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int inputflag = 0;
        long Nm1 = 0;
        long Nm2 = 0;

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            inputflag = 0;
            Nm1 = 0;
            Nm2 = 0;
            Nummer_1.Text = "";
            Nummer_2.Text = "";

        }

        private void Bereken_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                long Nm1 = long.Parse(Nummer_1.Text);
                long Nm2 = long.Parse(Nummer_2.Text);
            }
            catch (Exception)
            {
                Nm1 = 0;
                Nm2 = 0;
                inputflag = 1;
            }
           

        }
    }
}
