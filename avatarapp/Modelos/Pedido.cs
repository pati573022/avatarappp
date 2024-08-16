
using LiteDB;

namespace avatarapp.Modelos;
public class Pedido : Registro
{

    public string nome {get;set;}

     [BsonId]
   public int Id {get;set;}
   public int quantidade {get;set;}
   public decimal valor {get;set;}
   public decimal desconto {get;set;}
   public string prazo  {get;set;}
   public string modelodemarca  {get;set;}
    
}