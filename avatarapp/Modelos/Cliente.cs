using LiteDB;

namespace avatarapp.Modelos;


public class Cliente : Registro
{
   public string Nome {get; set;}

    [BsonId]
   public int Id {get; set;}
   public string endereco {get;set;}
   public string Telefone {get;set;}

}