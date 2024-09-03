using avatarapp.Modelos;
using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class MateriaPrimaPage : ContentPage
    {
         public MateriaPrima materiaprima { get; set; }
        Controles.MateriaPrimaControle materiaprimaControle = new Controles.MateriaPrimaControle();

        public MateriaPrimaPage()
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

          private void VoltarMateriaPrimaClicked(object sender, EventArgs e)
        {
          Application.Current.MainPage= new TelaEntrarPage ();
            // Logic for canceling registration
            DisplayAlert("Cancelled", "Cadastro cancelado!", "OK");
        }
         protected override void OnAppearing()
        {
            base.OnAppearing();

            if (materiaprima != null)
            {
                //IdLabel.Text        = cliente.Id.ToString();
                NomeEntry.Text = materiaprima.nome;
                UnidadedemedidaEntry.Text = materiaprima.unidadedemedida;
               
            }
        }
          private async void OnSalvarDadosClicked(object sender, EventArgs e)
        {

            var cliente = new Modelos.MateriaPrima();

            materiaprima.Id = 0;
            materiaprima.nome = NomeEntry.Text;
            materiaprima.unidadedemedida = UnidadedemedidaEntry.Text;
            materiaprimaControle.CriarOuAtualizar(materiaprima);

            await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
            
     }       
    }
}
