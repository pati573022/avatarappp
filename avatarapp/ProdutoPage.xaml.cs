using System;
using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class CadastroProdutoPage : ContentPage
    {
        public CadastroProdutoPage()
        {
            InitializeComponent();
        }

        private async void CadastrarButton_Clicked(object sender, EventArgs e)
        {
            string nome = NomeEntry.Text;
            string descricao = DescricaoEditor.Text;
            string materiaPrima = MateriaPrimaEntry.Text;
            string produto = ProdutoEntry.Text;
            string quantidade = QuantidadeEntry.Text;
            string tecido = TecidoEntry.Text;
            string valor = ValorEntry.Text;

            // Exemplo de validação simples
            if (string.IsNullOrWhiteSpace(nome) || 
                string.IsNullOrWhiteSpace(produto) || 
                string.IsNullOrWhiteSpace(valor))
            {
                await DisplayAlert("Erro", "Por favor, preencha todos os campos obrigatórios.", "OK");
                return;
            }

            // Aqui você pode adicionar a lógica para salvar os dados do produto
            // Por exemplo, salvando em um banco de dados ou chamando uma API.

            await DisplayAlert("Sucesso", "Produto cadastrado com sucesso!", "OK");

            // Limpar os campos após o cadastro
            NomeEntry.Text = string.Empty;
            DescricaoEditor.Text = string.Empty;
            MateriaPrimaEntry.Text = string.Empty;
            ProdutoEntry.Text = string.Empty;
            QuantidadeEntry.Text = string.Empty;
            TecidoEntry.Text = string.Empty;
            ValorEntry.Text = string.Empty;
        }
    }
}
