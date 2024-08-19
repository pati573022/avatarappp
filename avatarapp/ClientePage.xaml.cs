using Microsoft.Maui.Controls;
using Controles;
using avatarapp.Modelos;

namespace avatarapp
{
    public partial class ClientePage : ContentPage

    { 
        public Cliente cliente { get; set; }
  Controles.ClienteControle clienteControle = new Controles.ClienteControle();
        public ClientePage()

        {
            InitializeComponent();
        }

        private void OnRegisterButtonClicked(object sender, EventArgs e)
        {
            // Logic for registering the customer
            DisplayAlert("Success", "Cliente cadastrado com sucesso!", "OK");
        }

        private void OnCancelButtonClicked(object sender, EventArgs e)
        {
            // Logic for canceling registration
            DisplayAlert("Cancelled", "Cadastro cancelado!", "OK");
        }
         protected override void OnAppearing()
  {
    base.OnAppearing();

    if (cliente != null)
    {
      //IdLabel.Text        = cliente.Id.ToString();
      NomeEntry.Text      = cliente.Nome;
      TelefoneEntry.Text  = cliente.Telefone;
      EnderecoEntry.Text= cliente.endereco;

    

      
    }
  }
   private async void OnSalvarDadosClicked(object sender, EventArgs e)
  {
    
      var cliente = new Modelos.Cliente();
      
      cliente.Id      = 0;
      cliente.Nome      = NomeEntry.Text;
      cliente.Telefone  = TelefoneEntry.Text;
      clienteControle.CriarOuAtualizar(cliente);
      
      await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
    }
  }
 }

