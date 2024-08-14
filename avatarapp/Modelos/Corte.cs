using LiteDB;

namespace avatarapp.Modelos;

public class Corte : Registro
{

   public string produto {get;set;}

    [BsonId]
   public int id {get;set;}
   public int quantidade {get;set;}
   public string entrada {get;set;}
   public string prazo {get;set;}

    
}