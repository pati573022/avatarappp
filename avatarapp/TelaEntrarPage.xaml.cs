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
            Application.Current.MainPage = new ClientePage();
        }

        private void FornecedorClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new FornecedorPage();
        }  

        
        private void MateriaPrimaClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MateriaPrimaPage();
        }
    }

}
        
    


