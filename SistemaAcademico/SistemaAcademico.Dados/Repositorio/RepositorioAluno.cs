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
    public class RepositorioAluno : Repositorio<Aluno>
    {
        public RepositorioAluno() : base()
        {

        }

        public RepositorioAluno(IContexto contexto) : base(contexto)
        {

        }

        public int? BuscarMatriculaAtual(int idAluno)
        {
            return dbSet.Include(a => a.Matriculas)
                .Where(a => a.Id == idAluno).FirstOrDefault()?.Matriculas?.MaxByOrDefault(m => m.Periodo)?.Id;
        }
    }
}
