using System;
using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class CadastroEstoquePage : ContentPage
    {
        public CadastroEstoquePage()
        {
            InitializeComponent();
        }

        private void OnCadastrarClicked(object sender, EventArgs e)
        {
            string descricao = DescricaoEntry.Text;
            string fornecedor = FornecedorEntry.Text;
            string quantidade = QuantidadeEntry.Text;
            string precoVenda = PrecoVendaEntry.Text;

            // Aqui você pode adicionar a lógica para salvar os dados no banco de dados ou em um serviço
            DisplayAlert("Produto Cadastrado", $"Produto: {descricao}\nFornecedor: {fornecedor}\nQuantidade: {quantidade}\nPreço de Venda: {precoVenda}", "OK");
        }
    }
}
