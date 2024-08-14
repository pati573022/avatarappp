using LiteDB;

namespace avatarapp.Modelos;
public class Costura : Registro
{

    public string nome {get;set;}

     [BsonId]
   public int id {get;set;}
   public string produto {get;set;}
  public int quantidade {get;set;}
   public string  entrada {get;set;}
   public string prazo {get;set;}

}



    