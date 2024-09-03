using avatarapp.Modelos;
using Controles;

namespace avatarapp;
public partial class ListaFornecedorPage : ContentPage
{
  Controles.ControleFornecedor fornecedorControle = new Controles.ControleFornecedor();

  public ListaFornecedorPage()
	{
		InitializeComponent();
    // Buscamos no banco de dados, via Controle, a lista de todos os Fornecedor cadastrados
    ListaFornecedor.ItemsSource = fornecedorControle.LerTodos();
	}

  // Esse método será chamado toda vez que o usuário selecionar um fornecedor na lista
  void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
  {
    // Criaremos a página para onde queremos ir. Nesse caso iremos para o CadastroFornecedorPage,
    // que é a página onde os dados do fornecedor podem ser criados/editados
    var page = new FornecedorPage();
    // O passo seguinte é dizer para nova página qual fornecedor foi selecionado. Olhe o código da CadastroFornecedorPage,
    // e verifique que lá terá um atributo público do tipo Fornecedor, chamado fornecedor.
    // Toda vez que se clica em um fornecedor na lista nessa página, setaremos na CadastroFornecedorPage o atributo fornecedor
    // com o fornecedor que foi clicado aqui.
    page.fornecedor = e.SelectedItem as Fornecedor;
    // Troca-se a página principal para a página que acabamos de criar
    Application.Current.MainPage = page;
  }

  void NovoFornecedorClicked(object sender, EventArgs e)
  {
    // Quando a idéia é CRIAR um novo fornecedor, não é necessário setar o atributo "fornecedor" no CadastroFornecedorPage,
    // sendo assim, apenas criamos a nova página
    Application.Current.MainPage = new FornecedorPage();
  }
}