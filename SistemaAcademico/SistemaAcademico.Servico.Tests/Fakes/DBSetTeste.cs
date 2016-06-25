using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Servico.Tests.Fakes
{
    public class DBSetTeste<T> : DbSet<T>, IQueryable, IEnumerable, IEnumerable<T>
        where T : class
    {
        private readonly ObservableCollection<T> dados;
        private readonly IQueryable consulta;

        public DBSetTeste()
        {
            dados = new ObservableCollection<T>();
            consulta = dados.AsQueryable();
        }

        public override T Add(T item)
        {
            dados.Add(item);
            return item;
        }

        public override T Remove(T item)
        {
            dados.Remove(item);
            return item;
        }

        public override T Attach(T item)
        {
            dados.Add(item);
            return item;
        }

        public override T Create()
        {
            return Activator.CreateInstance<T>();
        }

        public override TDerivedEntity Create<TDerivedEntity>()
        {
            return Activator.CreateInstance<TDerivedEntity>();
        }

        public override ObservableCollection<T> Local
        {
            get { return new ObservableCollection<T>(dados); }
        }

        Type IQueryable.ElementType
        {
            get { return consulta.ElementType; }
        }

        Expression IQueryable.Expression
        {
            get { return consulta.Expression; }
        }

        IQueryProvider IQueryable.Provider
        {
            get { return consulta.Provider; }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return dados.GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return dados.GetEnumerator();
        }
    }
}