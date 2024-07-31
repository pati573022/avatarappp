using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class CadastroMateriaPrima : ContentPage
    {
        public CadastroMateriaPrima()
        {
            InitializeComponent();
        }

        private void OnSalvarClicked(object sender, EventArgs e)
        {
            // Lógica para salvar as informações
            DisplayAlert("Salvo", "Informações salvas com sucesso!", "OK");
        }

        private void OnCancelarClicked(object sender, EventArgs e)
        {
            // Lógica para cancelar e limpar os campos ou fechar a página
            DisplayAlert("Cancelado", "Operação cancelada.", "OK");
        }
    }
}
