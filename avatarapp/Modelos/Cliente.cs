namespace avatarapp.Modelos;


public class Cliente : Registro
{
    string nome;
    int id;
    string endereco;
    string telefone;

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

    public string GetEndereco()
    {
        return endereco;
    }
    public void SetEndereco (string endereco)
    {
        this.endereco= endereco;    
    }
    public string GetTelefone ()
    {
        return telefone;
    }
    public void SetTelefone (string telefone)
    {
       this.telefone= telefone;    
    }
}