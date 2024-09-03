using avatarapp.Modelos;
using Microsoft.Maui.Controls;


namespace avatarapp
{
    public partial class FornecedorPage : ContentPage
    {
        public Fornecedor fornecedor { get; set; }
        Controles.ControleFornecedor fornecedorControle = new Controles.ControleFornecedor();


        public FornecedorPage()

        {
            InitializeComponent();
        }

        private void OnRegisterButtonClicked(object sender, EventArgs e)
        {
            // Logic for registering the supplier
            DisplayAlert("Success", "Fornecedor cadastrado com sucesso!", "OK");
        }

        private void OnAddMaterialClicked(object sender, EventArgs e)
        {
            // Logic to add material
            DisplayAlert("Info", "Material adicionado!", "OK");
        }

        private void OnRemoveMaterialClicked(object sender, EventArgs e)
        {
            // Logic to remove material
            DisplayAlert("Info", "Material removido!", "OK");
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

           private void VoltarFornecedorClicked(object sender, EventArgs e)
        {
          Application.Current.MainPage= new TelaEntrarPage ();
            // Logic for canceling registration
            DisplayAlert("Cancelled", "Cadastro cancelado!", "OK");
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (fornecedor != null)
            {
                //IdLabel.Text        = cliente.Id.ToString();
                NomeEntry.Text = fornecedor.nome;
                materiaPrimaEntry.Text = fornecedor.materiaPrima;
                CnpjEntry.Text = fornecedor.cnpj;

            }
        }

        private async void OnSalvarDadosClicked(object sender, EventArgs e)
        {

            var cliente = new Modelos.Fornecedor();

            fornecedor.Id = 0;
            fornecedor.nome = NomeEntry.Text;
            fornecedor.materiaPrima = materiaPrimaEntry.Text;
            fornecedorControle.CriarOuAtualizar(fornecedor);

            await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
        }
    }
}
