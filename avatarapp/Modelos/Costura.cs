namespace avatarapp.Modelos;

public class Costura : Registro
{

    string nome;
    int id;
    string produto;
    int quantidade;
    string  entrada;
    string prazo;

     public void SetNome (string nome)
    {
        this.nome= nome;
        
    }
    public string GetNome ()
    {
        return nome;
    }

    public void SetId (int id)
    {
        this.id= id;
        
    }
    public int GetId ()
    {
        return id;
    }
  

    public string GetProduto ()
    {
        return produto;
    }

    public void SetProduto (string produto)
    {
        this.produto= produto;
        
    }

    public int GetQuantidade ()
    {
        return quantidade;
    }

    public void SetQuantidade(int qnt)
    {
        this.quantidade= qnt;
    }
    public string GetEntrada ()
    {
        return entrada;
    }

    public void SetEntrada (string entrada)
    {
        this.entrada= entrada; 
    }

     public string GetPrazo ()
    {
        return prazo;
    }

    public void SetPrazo(string prazo)
    {
        this.prazo= prazo;
    }
}



    