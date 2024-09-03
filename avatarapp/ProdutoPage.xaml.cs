using System;
using avatarapp.Modelos;
using Microsoft.Maui.Controls;

namespace avatarapp
{

    public partial class CadastroProdutoPage : ContentPage
    {
    public Produto produto { get; set; }
    Controles.ProdutoControle produtoControle = new Controles.ProdutoControle();
        public CadastroProdutoPage()
        {
            InitializeComponent();
        }
          private void OnRegisterButtonClicked(object sender, EventArgs e)
        {
            // Logic for registering the customer
            DisplayAlert("Success", "Cliente cadastrado com sucesso!", "OK");
        }

        private void VoltarProdutoClicked(object sender, EventArgs e)
        {
            // Logic for canceling registration
            DisplayAlert("Cancelled", "Cadastro cancelado!", "OK");
        }
     protected override void OnAppearing()
  {
    base.OnAppearing();

    if (produto != null)
    {
      //IdLabel.Text        = cliente.Id.ToString();
      NomeEntry.Text      = produto.nome;
      
      descricaodoprodutoEntry.Text= produto.descricaodoproduto;
    }
    }

       private async void OnSalvarDadosClicked(object sender, EventArgs e)
  {
    
      var cliente = new Modelos.Produto();
      
      produto.Id      = 0;
      produto.nome      = NomeEntry.Text;
      produto.descricaodoproduto= descricaodoprodutoEntry.Text;
      produtoControle.CriarOuAtualizar(produto);
      
      await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
    }
  }
 }
