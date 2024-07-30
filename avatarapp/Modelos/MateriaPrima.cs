namespace avatarapp.Modelos;

public class MateriaPrima : Registro
{
    string nome;
    int id;
    string unidadedemedida;
    
    
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
        this.id=id;
    }
    public int GetId ()
    {
        return id;
    }
    public string GetUnidadedeMedida ()
    {
        return unidadedemedida;
    }
    public void SetUnidadedeMedida(string unidadedemedida)
    {
        this.unidadedemedida= unidadedemedida;   
    }
}