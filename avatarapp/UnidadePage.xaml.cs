using Microsoft.Maui.Controls;
using System;
using avatarapp.Modelos;

namespace avatarapp
{
    public partial class UnidadePage : ContentPage
    {
    public Unidade unidade { get; set; }
  Controles.UnidadeControle unidadeControle = new Controles.UnidadeControle();
        public UnidadePage()
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
              protected override void OnAppearing()
  {
    base.OnAppearing();

    if (unidade != null)
    {
      //IdLabel.Text        = cliente.Id.ToString();
      NomeEntry.Text      = unidade.nome;
    }
}
 private async void OnSalvarDadosClicked(object sender, EventArgs e)
  {
    
      var cliente = new Modelos.Unidade();
      
      unidade.Id      = 0;
      unidade.nome      = NomeEntry.Text;
      unidadeControle.CriarOuAtualizar(unidade);
      
      await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");     
 
       }
         }
          }


