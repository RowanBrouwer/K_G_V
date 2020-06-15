using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
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

        long Nm1 = 0;
        long Nm2 = 0;
        int inputflag = 0;

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            inputflag = 0;
            Nm1 = 0;
            Nm2 = 0;
            Nummer_1.Text = "";
            Nummer_2.Text = "";
            Antwoord.Text = "";
        }

        // berekening voor het kleinste gemene veelvoud //
        public static int V_K_G_V(long a, long b)
        {
            long num1, num2;

            // kijken welk van de 2 getallen het hoogst is // 

            if (a > b)
            {
                num1 = a; num2 = b;
            }
            else
            {
                num1 = b; num2 = a;
            }

            // daadwerkelijke berekening // 

            for (long i = 1; i < num2; i++) {
                if ((num1 * i) % num2 == 0) {
                    return (int)(long)(i * num1);}}
            return (int)(long)(num1 * num2);
           
        }

        public void Bereken_Click(object sender, RoutedEventArgs e)
        {
            // parsing met catch //

            try
            {
                Nm1 = long.Parse(Nummer_1.Text);
                Nm2 = long.Parse(Nummer_2.Text);
            }
            catch (Exception)
            {
                Nm1 = 0;
                Nm2 = 0;
                inputflag = 1;
            }
            if (inputflag == 1)
            {
                Antwoord.Text = "Er is een fout opgetreden.";
            }
            else
            {
                long awnser = V_K_G_V(Nm1, Nm2);
                string A = string.Format("Het kleinste gemene veelvoud is {0}", awnser);
                Antwoord.Text = A;
            }

            //------------------------------------------------------------------//
        }

    }
}
