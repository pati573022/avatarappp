namespace avatarapp.Modelos;

public class Produto : Registro
{
   public string nome;

    [BsonId]
   public int id {get;set;}
     public string descricaodoproduto {get;set;}

}
    
    
   
    

        