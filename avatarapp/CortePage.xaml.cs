using Microsoft.Maui.Controls;
using System;
using avatarapp.Modelos;

namespace avatarapp
{
    public partial class CortePage : ContentPage
    {
          public Corte corte { get; set; }
        Controles.CorteControle corteControle = new Controles.CorteControle();

        public CortePage()
        {
            InitializeComponent();
        }

        private void OnCadastrarClicked(object sender, EventArgs e)
        {
            // Lógica para cadastrar os dados
            string cliente = ClientePicker.SelectedItem?.ToString();
            string produto = ProdutoPicker.SelectedItem?.ToString();
            string quantidade = QuantidadeEntry.Text;
            string entrada = EntradaEntry.Text;
            string prazo = PrazoEntry.Text;

            // Você pode adicionar lógica para salvar esses dados ou enviá-los para um servidor

            DisplayAlert("Cadastro", "Dados cadastrados com sucesso!", "OK");
        }
      
                }
                  }

