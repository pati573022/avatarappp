using System;
using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class BuscarClientePage : ContentPage
    {
        public BuscarClientePage()
        {
            InitializeComponent();
        }

        private void OnBuscarClicked(object sender, EventArgs e)
        {
            string searchTerm = BuscarEntry.Text;

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                DisplayAlert("Erro", "Por favor, digite um termo de busca.", "OK");
                return;
            }

            // Simulating a search operation - replace with actual search logic
            string[] mockResults = GetMockResults(searchTerm);

            // Display results in entry fields
            Result1Entry.Text = mockResults.Length > 0 ? mockResults[0] : "Nenhum resultado encontrado";
            Result2Entry.Text = mockResults.Length > 1 ? mockResults[1] : string.Empty;
            Result3Entry.Text = mockResults.Length > 2 ? mockResults[2] : string.Empty;
            Result4Entry.Text = mockResults.Length > 3 ? mockResults[3] : string.Empty;
            Result5Entry.Text = mockResults.Length > 4 ? mockResults[4] : string.Empty;
        }

        private string[] GetMockResults(string searchTerm)
        {
            // Simulated data - replace this with a database or API call
            return new string[]
            {
                "Cliente A",
                "Cliente B",
                "Cliente C",
                "Cliente D",
                "Cliente E"
            };
        }
    }
}
