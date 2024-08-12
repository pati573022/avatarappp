namespace avatarapp.Modelos;

public class Fornecedor : Registro
{
   public string nome {get;set;}

   [BsonId]
   public int id {get;set;}
   public string materiaPrima {get;set;}
   public string cnpj {get;set;}

   
}