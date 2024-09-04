using avatarapp.Modelos;
using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class TelaEntrarPage : ContentPage
    {
        public TelaEntrarPage()
        {
            InitializeComponent();
        }
        private void Volta(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ListaClientesPage();
        }

        private void FornecedorClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ListaFornecedorPage();
        }  

        
        private void PedidoClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ListaPedidoPage();
        }

        private void MateriaPrimaClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MateriaPrimaPage();
        }
          private void EstoqueClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new EstoquePage();
        }

            private void UnidadeClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new UnidadePage();
        }

             private void ProdutoClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new CadastroProdutoPage();
        }
    }

}
    


 
        
    


