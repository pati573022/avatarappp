using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class PedidoPage : ContentPage
    {
        public PedidoPage()
        {
            InitializeComponent();
        }

        private void OnRegisterButtonClicked(object sender, EventArgs e)
        {
            // Logic for registering the order
            DisplayAlert("Success", "Pedido cadastrado com sucesso!", "OK");
        }

        private void OnRecycleClicked(object sender, EventArgs e)
        {
            // Logic for recycle action
            DisplayAlert("Info", "Ação de reciclagem!", "OK");
        }

        private void OnRefreshClicked(object sender, EventArgs e)
        {
            // Logic for refresh action
            DisplayAlert("Info", "Página atualizada!", "OK");
        }
    }
}
