using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class TelaEntrarPage : ContentPage
    {
        public TelaEntrarPage()
        {
            InitializeComponent();
        }
        private void Volta (object sender, EventArgs e)
        {
        Application.Current.MainPage = new ClientePage ();
        }
    }   
    
}   
