using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace RPG_characterGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly ObservableCollection<Player> players = new ObservableCollection<Player>();

        public MainWindow()
        {
            InitializeComponent();
            PlayerListView.ItemsSource = players;

        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string strength = txtStrength.Text;
            string iq = txtIQ.Text;

            bool strengthConversion = ConvertStringtoInt(strength);
            bool iqConversion = ConvertStringtoInt(iq);
            bool nameLength = LengthOfInputs(name);
            bool strengthLength = LengthOfInputs(strength);
            bool iqLength = LengthOfInputs(iq);

            if (nameLength && strengthLength && iqLength && iqConversion && !strengthConversion)
            {
                txtStrength.Text = "";
                lblinputfeedback.Content = "Strength must be a number";
                return;
            }

            else if (nameLength && strengthLength && iqLength && !iqConversion && strengthConversion)
            {
                txtIQ.Text = "";
                lblinputfeedback.Content = "IQ must be a number";
                return;
            }

            else if (nameLength && strengthLength && iqLength && !iqConversion && !strengthConversion)
            {
                txtIQ.Text = "";
                txtStrength.Text = "";
                lblinputfeedback.Content = "IQ and strength must be a number";
                return;
            }

            else if (nameLength && strengthLength && iqLength && strengthConversion && iqConversion)
            {
                lblinputfeedback.Content = "Ok! Now choose a type.";

                comboType.IsEnabled = true;
                textOther.IsEnabled = true;
                btndone.IsEnabled = true;

                txtIQ.IsEnabled = false;
                txtStrength.IsEnabled = false;
                txtName.IsEnabled = false;

            }

        }

        private bool LengthOfInputs(string input)
        {
            if (input.Length > 1)
            {
                return true;
            }
            else if (input.Length < 1)
            {
                return false;
            }
            return false;
        }


        private bool ConvertStringtoInt(string str)
        {
            bool res;
            int a;
            res = int.TryParse(str, out a);
            return res;

        }

        private void comboType_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            int index = comboType.SelectedIndex;
            if (index == 0)
            {
                lblArmorOrMana.Content = "Mana";
            }
            if (index == 1)
            {
                lblArmorOrMana.Content = "Armor";
            }

        }

        private void Done_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string strength = txtStrength.Text;
            string iq = txtIQ.Text;
            int IQ = Convert.ToInt32(iq);
            int str = Convert.ToInt32(strength);
            string other = textOther.Text;

            int index = comboType.SelectedIndex;
            if (index == 0)
            {
                Wizard wizard = new(name, str, IQ, other);
                players.Add(wizard);
            }

            else if (index == 1)
            {
                Fighter fighter = new(name, str, IQ, other);
                players.Add(fighter);
            }
        }
    }
}
