using System;
using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class EstoquePage : ContentPage
    {
         public Estoque estoque { get; set; }
        Controles.EstoqueControle estoqueControle = new Controles.EstoqueControle();

        public EstoquePage()
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
         private async void OnSalvarDadosClicked(object sender, EventArgs e)
        {

            var cliente = new Modelos.Estoque();

            estoque.Id = 0;
            estoque.nome = NomeEntry.Text;
            estoque.materiaPrima = materiaPrimaEntry.Text;
            estoqueControle.CriarOuAtualizar(estoque);

            await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");

    }
}
