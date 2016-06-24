using SistemaAcademico.Dominio;
using SistemaAcademico.Negocio.Gerenciador.Base;
using SistemaAcademico.Util.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Negocio.Gerenciador
{
    public class GerenciadorMatricula : Gerenciador.Base.GerenciadorDominio<Matricula>
    {
        public GerenciadorMatricula(RegistraErro registraErro) : base(registraErro)
        {
        }

        public IEnumerable<MatriculaOferta> BuscarOfertas(int idMatricula)
        {
            return adaptador.RepositorioMatriculaOferta.BuscarPorMatricula(idMatricula);
        }

        public IEnumerable<Matricula> BuscarMatriculas(int idAluno)
        {
            return adaptador.RepositorioMatricula.BuscaPorAluno(idAluno);
        }
    }
}
