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
    public class RepositorioCurso : Repositorio<Curso>
    {
        public RepositorioCurso() : base()
        {

        }

        public RepositorioCurso(IContexto contexto) : base(contexto)
        {

        }
    }
}
