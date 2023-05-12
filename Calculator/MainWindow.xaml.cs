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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Declaration des variables
        private const int NBR_MAX_DISPLAY = 18;
        private string[] signes = { "+", "-", "*", "/", "^" };

        public MainWindow()
        {
            InitializeComponent();
        }

        // Fonction Evenement click
        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            string val = "0";
            if(displayBottom.Text.Length <= NBR_MAX_DISPLAY)
            {
                displayBottom.Text = Fonction.Zero(displayBottom.Text, val);
                //displayBottom.Text += val; 
            }
        }

        private void btn0Double_Click(object sender, RoutedEventArgs e)
        {
            string val = "00";
            if (displayBottom.Text.Length <= NBR_MAX_DISPLAY)
            {
                //displayBottom.Text += val;
                displayBottom.Text = Fonction.Zero(displayBottom.Text, val);
            }
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            string val = "1";
            if (displayBottom.Text.Length <= NBR_MAX_DISPLAY)
            {

                displayBottom.Text = Fonction.Zero(displayBottom.Text, val);//displayBottom.Text += val;
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            string val = "2";
            if (displayBottom.Text.Length <= NBR_MAX_DISPLAY)
            {
                displayBottom.Text = Fonction.Zero(displayBottom.Text, val);//displayBottom.Text += val;
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            string val = "3";
            if (displayBottom.Text.Length <= NBR_MAX_DISPLAY)
            {
                displayBottom.Text = Fonction.Zero(displayBottom.Text, val); //displayBottom.Text += val;
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            string val = "4";
            if (displayBottom.Text.Length <= NBR_MAX_DISPLAY)
            {
                displayBottom.Text = Fonction.Zero(displayBottom.Text, val); //displayBottom.Text += val;
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            string val = "5";
            if (displayBottom.Text.Length <= NBR_MAX_DISPLAY)
            {
                displayBottom.Text = Fonction.Zero(displayBottom.Text, val); //displayBottom.Text += val;
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            string val = "6";
            if (displayBottom.Text.Length <= NBR_MAX_DISPLAY)
            {
                displayBottom.Text = Fonction.Zero(displayBottom.Text, val); //displayBottom.Text += val;
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            string val = "7";
            if (displayBottom.Text.Length <= NBR_MAX_DISPLAY)
            {
                displayBottom.Text = Fonction.Zero(displayBottom.Text, val); //displayBottom.Text += val;
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            string val = "8";
            if (displayBottom.Text.Length <= NBR_MAX_DISPLAY)
            {
                displayBottom.Text = Fonction.Zero(displayBottom.Text, val); //displayBottom.Text += val;
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            string val = "9";
            if (displayBottom.Text.Length <= NBR_MAX_DISPLAY)
            {
                displayBottom.Text = Fonction.Zero(displayBottom.Text, val); //displayBottom.Text += val;
            }
        }

        private void btnVirgule_Click(object sender, RoutedEventArgs e)
        {
            string val = ",";
            if (displayBottom.Text.Length <= NBR_MAX_DISPLAY)
            {
                if (!displayBottom.Text.Contains(","))
                {
                    displayBottom.Text += val;
                }

            }
        }

        /// <summary>
        /// Supprime de dernier element mais si il reste 1 element on remplace par 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBackspace_Click(object sender, RoutedEventArgs e)
        {
            int index = displayBottom.Text.Length;
            if(index > 1)
            {
                displayBottom.Text = displayBottom.Text.Remove(index - 1, 1);

            }
            else
            {
                displayBottom.Text = "0";
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            displayBottom.Text = "0";
        }

        private void btnClearAll_Click(object sender, RoutedEventArgs e)
        {
            displayBottom.Text = "0";
            displayTop.Text = "";
        }

        private void btnPourcentage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                displayTop.Text = displayBottom.Text + "/100";
                float percnet = float.Parse(displayBottom.Text);
                displayBottom.Text = (percnet / 100).ToString();
            }
            catch
            {
                displayBottom.Text = "SYNTAX ERROR";

            }
        }

        private void btnXCarre_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                displayTop.Text = "²(" + displayBottom.Text + ")";
                float percnet = float.Parse(displayBottom.Text);
                displayBottom.Text = (percnet * percnet).ToString();
            }
            catch
            {
                displayBottom.Text = "SYNTAX ERROR";

            }
        }

        private void btnRacinecarre_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                displayTop.Text = "(" + displayBottom.Text + ")Sqrt";
                double percnet = double.Parse(displayBottom.Text);
                displayBottom.Text = (Math.Sqrt(percnet)).ToString();
            }
            catch
            {
                displayBottom.Text = "SYNTAX ERROR";

            }
        }

        // OPERATION + - / * = *********************************************S
        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            if (Fonction.IsEmpty(displayBottom.Text))
            {
                if(Fonction.IsOperatorMissigns(signes, displayBottom.Text))
                {
                    displayBottom.Text += "+";
                }
            }
        }

        private void btnMoins_Click(object sender, RoutedEventArgs e)
        {
            if (Fonction.IsEmpty(displayBottom.Text))
            {
                if (Fonction.IsOperatorMissigns(signes, displayBottom.Text))
                {
                    displayBottom.Text += "-";
                }
            }
        }

        private void btnMultiple_Click(object sender, RoutedEventArgs e)
        {
            if (Fonction.IsEmpty(displayBottom.Text))
            {
                if (Fonction.IsOperatorMissigns(signes, displayBottom.Text))
                {
                    displayBottom.Text += "*";
                }
            }
        }

        private void btnDivision_Click(object sender, RoutedEventArgs e)
        {
            if (Fonction.IsEmpty(displayBottom.Text))
            {
                if (Fonction.IsOperatorMissigns(signes, displayBottom.Text))
                {
                    displayBottom.Text += "/";
                }
            }
        }

        private void btnCarre_Click(object sender, RoutedEventArgs e)
        {
            if (Fonction.IsEmpty(displayBottom.Text))
            {
                if (Fonction.IsOperatorMissigns(signes, displayBottom.Text))
                {
                    displayBottom.Text += "^";
                }
            }
        }
    }
}
