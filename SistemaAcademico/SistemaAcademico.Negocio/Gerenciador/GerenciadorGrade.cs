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
    public class GerenciadorGrade : GerenciadorDominio<Grade>
    {
        public GerenciadorGrade(RegistraErro registraErro) : base(registraErro)
        {
        }

        public Grade BuscarPorCurso(int idCurso)
        {
            return adaptador.RepositorioGrade.BuscarGradeAtivaPorCurso(idCurso);
        }
    }
}
