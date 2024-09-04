using avatarapp.Modelos;

namespace avatarapp;
public partial class ListaPedidoPage : ContentPage
{
  Controles.PedidoControle pedidoControle = new Controles.PedidoControle();

  public ListaPedidoPage()
	{
		InitializeComponent();
    // Buscamos no banco de dados, via Controle, a lista de todos os Pedidos cadastrados
    ListaPedidos.ItemsSource = pedidoControle.LerTodos();
	}

  // Esse método será chamado toda vez que o usuário selecionar um pedido na lista
  void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
  {
    // Criaremos a página para onde queremos ir. Nesse caso iremos para o CadastroPedidoPage,
    // que é a página onde os dados do pedido podem ser criados/editados
    var page = new PedidoPage();
    // O passo seguinte é dizer para nova página qual pedido foi selecionado. Olhe o código da CadastroPedidoPage,
    // e verifique que lá terá um atributo público do tipo Pedido, chamado pedido.
    // Toda vez que se clica em um pedido na lista nessa página, setaremos na CadastroPedidoPage o atributo pedido
    // com o pedido que foi clicado aqui.
    page.pedido = e.SelectedItem as Pedido;
    // Troca-se a página principal para a página que acabamos de criar
    Application.Current.MainPage = page;
  }

  void NovoPedidoClicked(object sender, EventArgs e)
  {
    // Quando a idéia é CRIAR um novo pedido, não é necessário setar o atributo "pedido" no CadastroPedidoPage,
    // sendo assim, apenas criamos a nova página
    Application.Current.MainPage = new PedidoPage();
  }
}