using SistemaAcademico.Dados.Contrato;
using SistemaAcademico.Dados.Repositorio.Base;
using SistemaAcademico.Dominio;
using SistemaAcademico.Util.Enumeravel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dados.Repositorio
{
    public class RepositorioGrade : Repositorio<Grade>
    {
        public RepositorioGrade() : base()
        {

        }

        public RepositorioGrade(IContexto contexto) : base(contexto)
        {

        }

        public Grade BuscarGradeAtivaPorCurso(int idCurso)
        {
            return dbSet
                .Include(g => g.GradeDisciplinas.Select(gd => gd.Disciplina))
                .Where(g => g.IdCurso == idCurso && g.Ativa)
                .FirstOrDefault();
        }

        public Grade BuscarGradeAluno(int idAluno)
        {
            var gradeBuscada =
                from grade in dbSet
                join gradeDisciplina in db.Set<GradeDisciplina>() on grade.Id equals gradeDisciplina.IdGrade
                join oferta in db.Set<Oferta>() on gradeDisciplina.Id equals oferta.IdGradeDisciplina
                join matriculaOferta in db.Set<MatriculaOferta>() on oferta.Id equals matriculaOferta.IdOferta
                join matricula in db.Set<Matricula>() on matriculaOferta.IdMatricula equals matricula.Id
                where matricula.IdAluno == idAluno
                select grade;

            return gradeBuscada
                .Include(g => g.GradeDisciplinas.Select(gd => gd.Disciplina))
                .FirstOrDefault();
        }
    }
}
