using LiteDB;

namespace avatarapp;
public class Unidade : Registro
{
   public string nome {get;set;}

   [BsonId]
   public int id {get;set;}
    
}
    
