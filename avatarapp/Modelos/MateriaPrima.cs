using LiteDB;

namespace avatarapp.Modelos;

public class MateriaPrima : Registro
{
    public string nome {get;set;}

    [BsonId]
   public int Id {get;set;}
    string unidadedemedida {get;set;}
    
    
   
}