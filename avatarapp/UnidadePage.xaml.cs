using Microsoft.Maui.Controls;
using System;

namespace avatarapp
{
    public partial class CadastroUnidade : ContentPage
    {
        public CadastroUnidade()
        {
            InitializeComponent();
        }

        private void OnAddClicked(object sender, EventArgs e)
        {
            // Lógica para adicionar uma nova unidade
            DisplayAlert("Adicionar", "Nova unidade adicionada.", "OK");
        }

        private void OnCadastrarClicked(object sender, EventArgs e)
        {
            // Lógica para cadastrar a unidade
            DisplayAlert("Cadastrar", "Unidade cadastrada com sucesso!", "OK");
        }

        private void OnCancelarClicked(object sender, EventArgs e)
        {
            // Lógica para cancelar o cadastro
            DisplayAlert("Cancelar", "Operação cancelada.", "OK");
        }
    }
}
