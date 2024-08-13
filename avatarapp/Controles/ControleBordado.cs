 using LiteDB;

namespace Controles;

public class ControleBordado : BaseControle
{
  //----------------------------------------------------------------------------

  public ControleBordado() : base()
  {
    NomeDaTabela = "Bordado";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idBordado)
  {
    var collection = liteDB.GetCollection<Bordado>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idBordado);
  }

  //----------------------------------------------------------------------------

  public virtual List<Bordado>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Bordado>(NomeDaTabela);
    return new List<Bordado>(tabela.FindAll().OrderBy(d => d.Sobrenome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idBordado)
  {
    var collection = liteDB.GetCollection<Bordado>(NomeDaTabela);
    collection.Delete(idBordado);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Bordado bordado )
  {
    var collection = liteDB.GetCollection<Bordado>(NomeDaTabela);
    collection.Upsert(bordado);
  }

  //----------------------------------------------------------------------------
}