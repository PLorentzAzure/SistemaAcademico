using SistemaAcademico.Dados;
using SistemaAcademico.Dados.Contrato;
using SistemaAcademico.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Servico.Tests.Fakes
{
    class ContextoTeste : IContexto
    {
        public ContextoTeste(bool inicializaDados = false)
        {
            this.Disciplinas = new DBSetTeste<Disciplina>();
            dbSets = new Dictionary<Type, object>();
            dbSets.Add(typeof(Disciplina), Disciplinas);

            if (inicializaDados)
                CargaInicial.CarregaDados(this);
        }

        private readonly Dictionary<Type, object> dbSets;

        public DbSet<Disciplina> Disciplinas { get; private set; }

        public DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            object dbSet;
            if (!dbSets.TryGetValue(typeof(TEntity), out dbSet))
            {
                dbSet = new DBSetTeste<TEntity>();
                dbSets.Add(typeof(TEntity), dbSet);
            }
            return (DbSet<TEntity>)dbSet;
        }
        public void MarcaModificado<TEntity>(TEntity entidade) where TEntity : class
        {
            // Faz nada.
        }

        public void Dispose() { }

        public int SalvarAlteracoes()
        {
            return 1;
        }
    }
}
