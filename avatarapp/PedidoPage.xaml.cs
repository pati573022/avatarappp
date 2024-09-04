using avatarapp.Modelos;
using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class PedidoPage : ContentPage
    {

        Controles.ClienteControle clienteControle = new Controles.ClienteControle();
        public Pedido pedido { get; set; }
        Controles.PedidoControle pedidoControle = new Controles.PedidoControle();

        public PedidoPage()
        {
            InitializeComponent();
            pickerCliente.ItemsSource = clienteControle.LerTodos();
        }

        private void OnRegisterButtonClicked(object sender, EventArgs e)
        {
            // Logic for registering the order
            DisplayAlert("Success", "Pedido cadastrado com sucesso!", "OK");
        }

         private void VoltarPedidoClicked(object sender, EventArgs e)
        {
          Application.Current.MainPage= new TelaEntrarPage ();
            // Logic for canceling registration
            DisplayAlert("Cancelled", "Cadastro cancelado!", "OK");
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

            if (pedido != null)
            {

                QuantidadeEntry.Text = pedido.quantidade.ToString();

                ValorEntry.Text = pedido.valor.ToString();
                DescontoEntry.Text = pedido.desconto.ToString();
                PrazoEntry.Text = pedido.prazo;
                ModelodeMarcaEntry.Text = pedido.modelodemarca;

            }

        }



        private async void OnSalvarDadosClicked(object sender, EventArgs e)
        {

            var cliente = new Modelos.Pedido();

            pedido.Id = 0;
            pedido.quantidade = int.Parse(QuantidadeEntry.Text);
            pedido.valor = decimal.Parse(ValorEntry.Text);
            pedido.desconto = decimal.Parse(DescontoEntry.Text);
            pedido.prazo = PrazoEntry.Text;
            pedido.modelodemarca = ModelodeMarcaEntry.Text;

            pedidoControle.CriarOuAtualizar(pedido);

            await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");



        }
    }
  }

