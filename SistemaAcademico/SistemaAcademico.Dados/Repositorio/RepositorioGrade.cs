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
    }
}
