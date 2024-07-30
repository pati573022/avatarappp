using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class SupplierRegistrationPage : ContentPage
    {
        public SupplierRegistrationPage()
        {
            InitializeComponent();
        }

        private void OnRegisterButtonClicked(object sender, EventArgs e)
        {
            // Logic for registering the supplier
            DisplayAlert("Success", "Fornecedor cadastrado com sucesso!", "OK");
        }

        private void OnAddMaterialClicked(object sender, EventArgs e)
        {
            // Logic to add material
            DisplayAlert("Info", "Material adicionado!", "OK");
        }

        private void OnRemoveMaterialClicked(object sender, EventArgs e)
        {
            // Logic to remove material
            DisplayAlert("Info", "Material removido!", "OK");
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
