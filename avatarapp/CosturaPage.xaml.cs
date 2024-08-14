using System;
using Microsoft.Maui.Controls;

namespace avatarapp
{
    public partial class CosturaPage : ContentPage
    {
        public CosturaPage()
        {
            InitializeComponent();
        }

        private void OnCadastrarClicked(object sender, EventArgs e)
        {
            // Aqui você pode adicionar a lógica de cadastro
            string cliente = ClientePicker.SelectedItem?.ToString();
            string produto = ProdutoPicker.SelectedItem?.ToString() ?? ProdutoEntry.Text;
            int quantidade;
            int.TryParse(QuantidadeEntry.Text, out quantidade);
            DateTime entrada = EntradaDatePicker.Date;
            DateTime prazo = PrazoDatePicker.Date;

            // Exemplo de lógica de cadastro (apenas mostrando um alerta por enquanto)
            DisplayAlert("Cadastro", $"Cliente: {cliente}\nProduto: {produto}\nQuantidade: {quantidade}\nEntrada: {entrada.ToShortDateString()}\nPrazo: {prazo.ToShortDateString()}", "OK");
        }
    }
}
