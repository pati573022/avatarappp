namespace avatarapp.Modelos;

public class Fornecedor : Registro
{
    string nome;
    int id;
    string materiaPrima;
    string cnpj;

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
    
    public string GetMateriaPrima()
    {
        return materiaPrima;
    }
    public void SetMateriaPrima (string materiaprima)
    {
        this.materiaPrima= materiaPrima;        
    }

    public void SetCnpj (string cnpj)
    {
        this.cnpj= cnpj;
        
    }
    public string GetCnpj ()
    {
        return cnpj;
    }
}