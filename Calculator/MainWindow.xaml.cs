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
        const int NBR_MAX_DISPLAY = 18;
        string[] signes = { "+", "-", "*", "/", "^"};
        string operateur;

        public MainWindow()
        {
            InitializeComponent();
            btnVirgule.IsEnabled = true;
            btnMoins.IsEnabled = true;
            btnPlus.IsEnabled = true;
            btnMultiple.IsEnabled = true;
            btnDivision.IsEnabled = true;
            btnCarre.IsEnabled = true;

        }

        // Fonction Evenement click

        //********************** boutton 0 *******************
        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            string val = "0";
            if(displayBottom.Text.Length <= NBR_MAX_DISPLAY)
            {
                
                displayBottom.Text = Fonction.Zero(displayBottom.Text, val);
                 
            }
        }
        //********************** boutton 00 *******************
        private void btn0Double_Click(object sender, RoutedEventArgs e)
        {
            string val = "00";
            if (displayBottom.Text.Length <= NBR_MAX_DISPLAY)
            {
                //displayBottom.Text += val;
                displayBottom.Text = Fonction.Zero(displayBottom.Text, val);
            }
        }
        //********************** boutton 1 *******************
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            string val = "1";
            if (displayBottom.Text.Length <= NBR_MAX_DISPLAY)
            {
                displayBottom.Text = Fonction.Zero(displayBottom.Text, val);
                
            }
        }
        //********************** boutton 2 *******************
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            string val = "2";
            if (displayBottom.Text.Length <= NBR_MAX_DISPLAY)
            {
                displayBottom.Text = Fonction.Zero(displayBottom.Text, val);//displayBottom.Text += val;
            }
        }
        //********************** boutton 3 *******************
        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            string val = "3";
            if (displayBottom.Text.Length <= NBR_MAX_DISPLAY)
            {
                displayBottom.Text = Fonction.Zero(displayBottom.Text, val); //displayBottom.Text += val;
            }
        }
        //********************** boutton 4 *******************
        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            string val = "4";
            if (displayBottom.Text.Length <= NBR_MAX_DISPLAY)
            {
                displayBottom.Text = Fonction.Zero(displayBottom.Text, val); //displayBottom.Text += val;
            }
        }
        //********************** boutton 5 *******************
        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            string val = "5";
            if (displayBottom.Text.Length <= NBR_MAX_DISPLAY)
            {
                displayBottom.Text = Fonction.Zero(displayBottom.Text, val); //displayBottom.Text += val;
            }
        }
        //********************** boutton 6 *******************
        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            string val = "6";
            if (displayBottom.Text.Length <= NBR_MAX_DISPLAY)
            {
                displayBottom.Text = Fonction.Zero(displayBottom.Text, val); //displayBottom.Text += val;
            }
        }
        //********************** boutton 7 *******************
        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            string val = "7";
            if (displayBottom.Text.Length <= NBR_MAX_DISPLAY)
            {
                displayBottom.Text = Fonction.Zero(displayBottom.Text, val); //displayBottom.Text += val;
            }
        }
        //********************** boutton 8 *******************
        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            string val = "8";
            if (displayBottom.Text.Length <= NBR_MAX_DISPLAY)
            {
                displayBottom.Text = Fonction.Zero(displayBottom.Text, val); //displayBottom.Text += val;
            }
        }
        //********************** boutton 9 *******************
        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            string val = "9";
            if (displayBottom.Text.Length <= NBR_MAX_DISPLAY)
            {
                displayBottom.Text = Fonction.Zero(displayBottom.Text, val); //displayBottom.Text += val;
            }
        }
        //********************** boutton , *******************
        private void btnVirgule_Click(object sender, RoutedEventArgs e)
        {
            string val = ",";
            if (displayBottom.Text.Length <= NBR_MAX_DISPLAY)
            {
                if (!displayBottom.Text.Contains(","))
                {
                    displayBottom.Text += val;
                    btnVirgule.IsEnabled = false;
                }
                else
                {
                    btnVirgule.IsEnabled = true;
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

            if (displayBottom.Text.Contains(","))
            {
                btnVirgule.IsEnabled = false;
            }
            else
            {
                btnVirgule.IsEnabled = true;
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            btnVirgule.IsEnabled = true;
            displayBottom.Text = "0";
        }

        private void btnClearAll_Click(object sender, RoutedEventArgs e)
        {
            btnVirgule.IsEnabled = true;
            displayBottom.Text = "0";
            displayTop.Text = "";
            btnMoins.IsEnabled = true;
            btnPlus.IsEnabled = true;
            btnMultiple.IsEnabled = true;
            btnDivision.IsEnabled = true;
            btnCarre.IsEnabled = true;
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
                displayTop.Text = "(" + displayBottom.Text + ")²";
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
                displayTop.Text = "Sqrt(" + displayBottom.Text + ")";
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
            operateur = "+";

            if (Fonction.IsEmpty(displayBottom.Text))
            {
                if (Fonction.IsOperatorMissigns(signes, displayBottom.Text))
                {
                    btnVirgule.IsEnabled = true;
                    if (Fonction.IsOperatorMissigns(signes, displayBottom.Text))
                    {
                        btnVirgule.IsEnabled = true;
                        if (Fonction.LastStringValue(displayBottom.Text) == ',')
                        {
                            displayBottom.Text = displayBottom.Text.Remove(displayBottom.Text.Length - 1, 1);
                            displayTop.Text = displayBottom.Text + " + ";
                            displayBottom.Text = "0";
                        }
                        else
                        {
                            displayTop.Text = displayBottom.Text + " + ";
                            displayBottom.Text = "0";
                        }
                    }
                }
            }
        }

        private void btnMoins_Click(object sender, RoutedEventArgs e)
        {
            operateur = "-";

            if (Fonction.IsEmpty(displayBottom.Text))
            {
                if (Fonction.IsOperatorMissigns(signes, displayBottom.Text))
                {
                    btnVirgule.IsEnabled = true;
                    if (Fonction.LastStringValue(displayBottom.Text) == ',')
                    {
                        displayBottom.Text = displayBottom.Text.Remove(displayBottom.Text.Length - 1, 1);
                        displayTop.Text = displayBottom.Text + " - ";
                        displayBottom.Text = "0";
                    }
                    else
                    {
                        displayTop.Text = displayBottom.Text + " - ";
                        displayBottom.Text = "0";
                    }
                }
            }
        }

        private void btnMultiple_Click(object sender, RoutedEventArgs e)
        {
            operateur = "*"; 

            if (Fonction.IsEmpty(displayBottom.Text))
            {
                if (Fonction.IsOperatorMissigns(signes, displayBottom.Text))
                {
                    btnVirgule.IsEnabled = true;
                    if (Fonction.IsOperatorMissigns(signes, displayBottom.Text))
                    {
                        btnVirgule.IsEnabled = true;
                        if (Fonction.LastStringValue(displayBottom.Text) == ',')
                        {
                            displayBottom.Text = displayBottom.Text.Remove(displayBottom.Text.Length - 1, 1);
                            displayTop.Text = displayBottom.Text + " * ";
                            displayBottom.Text = "0";
                        }
                        else
                        {
                            displayTop.Text = displayBottom.Text + " * ";
                            displayBottom.Text = "0";
                        }
                    }
                }
            }
        }

        private void btnDivision_Click(object sender, RoutedEventArgs e)
        {
            operateur = "/";

            if (Fonction.IsEmpty(displayBottom.Text))
            {
                if (Fonction.IsOperatorMissigns(signes, displayBottom.Text))
                {
                    btnVirgule.IsEnabled = true;
                    if (Fonction.IsOperatorMissigns(signes, displayBottom.Text))
                    {
                        btnVirgule.IsEnabled = true;
                        if (Fonction.LastStringValue(displayBottom.Text) == ',')
                        {
                            displayBottom.Text = displayBottom.Text.Remove(displayBottom.Text.Length - 1, 1);
                            displayTop.Text = displayBottom.Text + " / ";
                            displayBottom.Text = "0";
                        }
                        else
                        {
                            displayTop.Text = displayBottom.Text + " / ";
                            displayBottom.Text = "0";
                        }
                    }
                }
            }
        }

        private void btnCarre_Click(object sender, RoutedEventArgs e)
        {
            operateur = "^";

            if (Fonction.IsEmpty(displayBottom.Text))
            {
                if (Fonction.IsOperatorMissigns(signes, displayBottom.Text))
                {
                    btnVirgule.IsEnabled = true;
                    if (Fonction.IsOperatorMissigns(signes, displayBottom.Text))
                    {
                        btnVirgule.IsEnabled = true;
                        if (Fonction.LastStringValue(displayBottom.Text) == ',')
                        {
                            displayBottom.Text = displayBottom.Text.Remove(displayBottom.Text.Length - 1, 1);
                            displayTop.Text = displayBottom.Text + " ^ ";
                            displayBottom.Text = "0";
                        }
                        else
                        {
                            displayTop.Text = displayBottom.Text + " ^ ";
                            displayBottom.Text = "0";
                        }
                    }
                }
            }
        }

        private void btnEgal_Click(object sender, RoutedEventArgs e)
        {

            if (!Fonction.IsOperatorMissigns(signes, displayTop.Text) && !Fonction.IsContains("=", displayTop.Text))
            {
                displayTop.Text += displayBottom.Text;
                displayTop.Text += " = ";
                var calcul = new Calcul(operateur, displayTop.Text);
                displayBottom.Text = ""+ calcul.Egale();
            }
        }

        private void displayTop_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(!Fonction.IsOperatorMissigns(signes, displayTop.Text))
            {
                btnMoins.IsEnabled = false;
                btnPlus.IsEnabled = false;
                btnMultiple.IsEnabled = false;
                btnDivision.IsEnabled = false;
            }
            else
            {
                btnMoins.IsEnabled = true;
                btnPlus.IsEnabled = true;
                btnMultiple.IsEnabled = true;
                btnDivision.IsEnabled = true;
                btnCarre.IsEnabled = true;
            }

        }

        private void history_Click(object sender, RoutedEventArgs e)
        {
            historyPanel.Visibility = Visibility;
        }

        private void closeHistory_Click(object sender, RoutedEventArgs e)
        {
            historyPanel.Visibility = Visibility.Collapsed;
        }

    }
}
