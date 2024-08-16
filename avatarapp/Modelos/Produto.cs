using LiteDB;
namespace avatarapp.Modelos;

public class Produto : Registro
{
   public string nome;

    [BsonId]
   public int Id {get;set;}
     public string descricaodoproduto {get;set;}

}
    
    
   
    

        