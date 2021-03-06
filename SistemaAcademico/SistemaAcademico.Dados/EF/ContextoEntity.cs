﻿using SistemaAcademico.Dados.Contrato;
using SistemaAcademico.Dominio;
using SistemaAcademico.Util.Excecao.Dado;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dados.EF
{
    internal partial class ContextoEntity : DbContext, IContexto
    {
        internal ContextoEntity(string conexao)
            : base(conexao)
        {
            // Apenas para carregar a instância do SqlProviderServices:
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
            Configuration.ProxyCreationEnabled = false;
        }

        internal static IContexto CriaContexto(string conexao)
        {
            return new ContextoEntity(conexao);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new Inicializador());
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Properties<string>().Configure(c => c.HasColumnType("varchar"));

            modelBuilder.Entity<Aluno>()
                .HasRequired(a => a.Usuario)
                .WithMany(u => u.Alunos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Professor>()
                .HasRequired(p => p.Usuario)
                .WithMany(u => u.Professores)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Atividade>()
                .HasRequired(a => a.Oferta)
                .WithMany(ogd => ogd.Atividades)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .Property(u => u.Login)
                .IsUnique();
        }

        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<MatriculaAtividade> AlunoAtividade { get; set; }
        public DbSet<Atividade> Atividade { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Disciplina> Disciplina { get; set; }
        public DbSet<Grade> Grade { get; set; }
        public DbSet<GradeDisciplina> GradeDisciplina { get; set; }
        public DbSet<Matricula> Matricula { get; set; }
        public DbSet<MatriculaOferta> MatriculaOferta { get; set; }
        public DbSet<Oferta> Oferta { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<RetificacaoFalta> RetificacaoFalta { get; set; }
        public DbSet<RevisaoAtividade> RevisaoAtividade { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        public int SalvarAlteracoes()
        {
            try
            {
                return SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new SalvarException("O registro foi modificado por outro usuário.", ex);
            }
            catch (DbEntityValidationException ex)
            {
                throw new SalvarException("Ocorreu um erro ao validar os dados informados.", ex);
            }
            catch (DbUpdateException ex)
            {
                throw new SalvarException("Ocorreu um erro ao gravar as suas alterações.", ex);
            }
        }

        public void MarcaModificado<TEntity>(TEntity entidade) where TEntity : class
        {
            Entry(entidade).State = EntityState.Modified;
        }
    }
}
