using LiteDB;

namespace avatarapp.Modelos;
public class Unidade : Registro
{
   public string nome {get;set;}

   [BsonId]
   public int Id {get;set;}
    
}
    
