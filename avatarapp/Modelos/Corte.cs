namespace avatarapp.Modelos;

public class Corte : Registro
{

    string produto;
    int id;
    int quantidade;
    string entrada;
    string prazo;

    public string GetProduto()
    {
        return produto;
    }

    public void SetProduto(string produto)
    {
        this.produto = produto;

    }


    public void SetId(int id)
    {
        this.id = id;

    }
    public int GetId()
    {
        return id;
    }


    public int GetQuantidade()
    {
        return quantidade;
    }

    public void SetQuantidade(int quantidade)
    {
        this.quantidade = quantidade;
    }

    public string GetEntrada()
    {
        return produto;
    }

    public void SetEntrada(string entrada)
    {
        this.entrada = entrada;

    }

    public string GetPrazo()
    {
        return prazo;
    }

    public void SetPrazo(string prazo)
    {
        this.prazo= prazo;
    }

}