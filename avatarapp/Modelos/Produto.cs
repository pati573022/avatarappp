namespace avatarapp.Modelos;

public class Produto : Registro
{
    string nome;
    int id;
    string descricaodoproduto;
    
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

     public string GetDescricaodoProduto ()
    {
        return descricaodoproduto;
    }
    public void SetDescricaodoProduto(string descr)
    {
        this.descricaodoproduto= descr;
    }
    
}
    

        