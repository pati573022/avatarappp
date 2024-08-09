using System;
using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class CadastroBordadoPage : ContentPage
    {
        public CadastroBordadoPage()
        {
            InitializeComponent();
        }

        private void OnCadastrarClicked(object sender, EventArgs e)
        {
            // Collect data from the form
            string nomeCliente = NomeClientePicker.SelectedItem?.ToString();
            string produto = ProdutoPicker.SelectedItem?.ToString();
            string quantidade = QuantidadeEntry.Text;
            string entrada = EntradaEntry.Text;
            string prazo = PrazoEntry.Text;

            if (string.IsNullOrWhiteSpace(nomeCliente) ||
                string.IsNullOrWhiteSpace(produto) ||
                string.IsNullOrWhiteSpace(quantidade) ||
                string.IsNullOrWhiteSpace(entrada) ||
                string.IsNullOrWhiteSpace(prazo))
            {
                DisplayAlert("Erro", "Todos os campos devem ser preenchidos!", "OK");
                return;
            }

            // Display an alert with the input data
            DisplayAlert("Bordado Cadastrado",
                         $"Cliente: {nomeCliente}\nProduto: {produto}\nQuantidade: {quantidade}\nEntrada: {entrada}\nPrazo: {prazo}",
                         "OK");

            // Clear inputs
            NomeClientePicker.SelectedIndex = -1;
            ProdutoPicker.SelectedIndex = -1;
            QuantidadeEntry.Text = string.Empty;
            EntradaEntry.Text = string.Empty;
            PrazoEntry.Text = string.Empty;

            // Here you can add logic to save data to the database or a service
        }
    }
}
