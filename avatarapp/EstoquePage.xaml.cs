using System;
using avatarapp.Modelos;
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

          private void OnRegisterButtonClicked(object sender, EventArgs e)
        {
            // Logic for registering the order
            DisplayAlert("Success", "Estoque cadastrado com sucesso!", "OK");
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
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (estoque != null)
            {
        //IdLabel.Text        = cliente.Id.ToString();
                DescricaoEntry.Text = estoque.descricaodoproduto;
                QuantidadeEntry.Text = estoque.quantidade;
                FornecedorEntry.Text = estoque.fornecedor;
                PrecoVendaEntry.Text=estoque.precodevenda;
     

            }

        }



        private async void OnCadastrarClicked(object sender, EventArgs e)
        {

            var cliente = new Modelos.Estoque();

            estoque.Id = 0;
            estoque.descricaodoproduto = DescricaoEntry.Text;
            estoque.quantidade = QuantidadeEntry.Text;
            estoque.fornecedor= FornecedorEntry.Text;
            estoque.precodevenda = PrecoVendaEntry.Text;                                                        
            estoqueControle.CriarOuAtualizar(estoque);

            estoqueControle.CriarOuAtualizar(estoque);

            await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");



        }
    }
}

