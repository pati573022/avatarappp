namespace avatarapp.Modelos;

public class Bordado : Registro
{

    public string produto {get;set;}

    [BsonId]
   public int id;
   [BsonId]
   public int quantidade {get;set;}
   public string entrada {get;set;}
     public string prazo {get;set;}


}