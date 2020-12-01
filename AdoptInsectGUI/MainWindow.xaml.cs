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

namespace AdoptInsectGUI
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

        private void Start()
        {
            SetUpInsect();
            Intro();
        }

        private void SetUpInsect()
        {
            Insect Insect1 = new Insect();
            Insect1.Name = "Gabe";
            Insect1.NumberofLegs = 8;
            Insect1.BreedingSeason = "Summer";
            Insect1.Diet = "Insects";
            InsectName.Text = $"Insect Name: {Insect1.Name}";
            InsectNumberOfLegs.Text = $"Number of Legs: {Insect1.NumberofLegs}";
            InsectBreedingSeason.Text = $"Breeding Season: {Insect1.BreedingSeason}";
            InsectDiet.Text = $"{Insect1.Name}'s Diet: {Insect1.Diet}";
        }

        private void Intro()
        {
            WelcomeMessage.Text = "Welcome to the insect adoption event! What's your name?";
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Start();
        }

        private void NameConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            if (PlayerNameInput.Text != "")
            {
                PlayerNameFeedback.Text = $"Hello {PlayerNameInput.Text}! Would you like to adopt Gabe?";
            }
        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            GabeAdoptionStatus.Text = "Gabe is happy indeed!";
            EndMessage.Text = "Thank you for playing!";
        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            GabeAdoptionStatus.Text = "Too bad :(";
            EndMessage.Text = "Gabe says goodbye...";
        }
    }
}
