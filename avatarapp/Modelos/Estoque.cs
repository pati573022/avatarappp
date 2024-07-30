namespace avatarapp.Modelos;

public class Estoque : Registro
{
    int id;
    string descricaodoproduto;
    int quantidade;
    string  fornecedor;
    string precodevenda;

      public void Setid (int id)
    {
        this.id= id;
        
    }
    public int GetId ()
    {
        return id;
    }

     public string GetDescricaodoProduto ()
    {
        return descricaodoproduto;
    }
    public void SetDescricaodoProduto(string descr)
    {
        this.descricaodoproduto= descr;
    }

    public string Getfornecedor ()
    {
        return fornecedor;
    }
    public void Setfornecedor(string forn)
    {
        this.fornecedor= forn;
    }

    public string Getprecodevenda ()
    {
        return precodevenda;
    }
    public void Setprecodevenda(string precodevenda)
    {
        this.fornecedor= precodevenda;
    }
    }




    
