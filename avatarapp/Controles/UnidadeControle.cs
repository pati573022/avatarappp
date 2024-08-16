
using avatarapp.Modelos;
namespace Controles;

public class UnidadeControle : BaseControle
{
  //----------------------------------------------------------------------------

  public UnidadeControle() : base()
  {
    NomeDaTabela = "Unidade";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idUnidade)
  {
    var collection = liteDB.GetCollection<Unidade>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idUnidade);
  }

  //----------------------------------------------------------------------------

  public virtual List<Unidade>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Unidade>(NomeDaTabela);
    return new List<Unidade>(tabela.FindAll().OrderBy(d => d.nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idUnidade)
  {
    var collection = liteDB.GetCollection<Unidade>(NomeDaTabela);
    collection.Delete(idUnidade);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Unidade unidade)
  {
    var collection = liteDB.GetCollection<Unidade>(NomeDaTabela);
    collection.Upsert(unidade);
  }

  //----------------------------------------------------------------------------
}