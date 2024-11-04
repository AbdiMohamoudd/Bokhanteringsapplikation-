using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace YourNamespace
{
    public partial class MainWindow : Window
    {
        private Bokningshantering bokningshantering = new Bokningshantering();

        public MainWindow()
        {
            InitializeComponent();
            UppdateraPassLista();
        }

        private void UppdateraPassLista()
        {
            PassListView.ItemsSource = null;
            PassListView.ItemsSource = bokningshantering.PassLista;
        }

        private void BokaPass_Click(object sender, RoutedEventArgs e)
        {
            if (PassListView.SelectedItem is Pass selectedPass && selectedPass.BookedParticipants < selectedPass.MaxParticipants)
            {
                selectedPass.BookedParticipants++;
                UppdateraPassLista();
                MessageBox.Show("Pass bokat!");
            }
            else
            {
                MessageBox.Show("Det finns inga lediga platser kvar för detta pass.");
            }
        }

        private void TaBortPass_Click(object sender, RoutedEventArgs e)
        {
            if (PassListView.SelectedItem is Pass selectedPass && selectedPass.BookedParticipants > 0)
            {
                selectedPass.BookedParticipants--;
                UppdateraPassLista();
                MessageBox.Show("Bokning avbokad!");
            }
            else
            {
                MessageBox.Show("Det finns inga bokningar att ta bort för detta pass.");
            }
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = SearchBox.Text.ToLower();
            var filteredPassList = bokningshantering.PassLista
                .Where(p => p.Workout.ToLower().Contains(searchText) ||
                            p.Time.ToString("yyyy-MM-dd").Contains(searchText))
                .ToList();
            PassListView.ItemsSource = null;
            PassListView.ItemsSource = filteredPassList;
        }
    }
}
