using LiteDB;

namespace avatarapp;

public class Estoque : Registro
{
     [BsonId]
    public int id {get;set;}
    public string descricaodoproduto {get;set;}

    int quantidade {get;set;}
   public string  fornecedor {get;set;}
    public string precodevenda {get;set;}


    }




    
