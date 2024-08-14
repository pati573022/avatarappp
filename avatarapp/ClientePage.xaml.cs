using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class ClientePage : ContentPage
    {
        public ClientePage()
        {
            InitializeComponent();
        }

        private void OnRegisterButtonClicked(object sender, EventArgs e)
        {
            // Logic for registering the customer
            DisplayAlert("Success", "Cliente cadastrado com sucesso!", "OK");
        }

        private void OnCancelButtonClicked(object sender, EventArgs e)
        {
            // Logic for canceling registration
            DisplayAlert("Cancelled", "Cadastro cancelado!", "OK");
        }
    }
}
