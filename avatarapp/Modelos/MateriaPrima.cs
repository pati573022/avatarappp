using LiteDB;

namespace avatarapp;

public class MateriaPrima : Registro
{
    public string nome {get;set;}

    [BsonId]
   public int id {get;set;}
    string unidadedemedida {get;set;}
    
    
   
}