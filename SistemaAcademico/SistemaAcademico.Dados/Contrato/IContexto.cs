using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dados.Contrato
{
    public interface IContexto : IDisposable
    {
        int SalvarAlteracoes();

        void MarcaModificado<TEntity>(TEntity entidade) where TEntity : class;

        // TODO: Deixar IContexto livre do Entity:
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}
