
namespace avatarapp.Modelos;

public class Pedido : Registro
{

    string nome;
    int id;
    int quantidade;
    decimal valor;
    decimal desconto;
    string prazo;
    string modelodemarca;
    public void SetNome(string nome)
    {
        this.nome = nome;

    }
    public string GetNome()
    {
        return nome;
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

    public decimal GetValor()
    {
        return valor;
    }

    public void SetValor(decimal valor)
    {
        this.valor = valor;
    }

    public decimal GetDesconto()
    {
        return desconto;
    }

    public void SetDesconto(decimal desconto)
    {
        this.desconto = desconto;
    }


    public string GetPrazo()
    {
        return prazo;
    }

    public void SetPrazo(string prazo)
    {
        this.prazo = prazo;
    }

    public string GetModelodeMarca()
    {
        return modelodemarca;
    }

    public void SetModelodeMarca(string modelodemarca)
    {
        this.modelodemarca = modelodemarca;
    }
}