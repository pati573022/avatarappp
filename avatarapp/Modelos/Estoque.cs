using LiteDB;

namespace avatarapp.Modelos;

public class Estoque : Registro
{
     [BsonId]
    public int Id {get;set;}
    public string descricaodoproduto {get;set;}

   public string quantidade {get;set;}
   public string  fornecedor {get;set;}
    public string precodevenda {get;set;}


    }




    
