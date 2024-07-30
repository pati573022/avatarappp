namespace avatarapp.Modelos;
public class Unidade : Registro
{
    string nome;
    int id;
      public void SetNome (string nome)
    {
        this.nome= nome;
    }
    public string GetNome ()
    {
        return nome;
    }

    public int GetId ( )
    {
      return id;
    }

    public void Setid  (int id) 
    {
        id= id;
    }
}
    
