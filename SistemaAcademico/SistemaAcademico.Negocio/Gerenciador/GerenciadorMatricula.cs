﻿using SistemaAcademico.Dominio;
using SistemaAcademico.Negocio.Gerenciador.Base;
using SistemaAcademico.Util.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Negocio.Gerenciador
{
    public class GerenciadorMatricula : Gerenciador.Base.Gerenciador
    {
        public GerenciadorMatricula(RegistraErro registraErro) : base(registraErro)
        {
        }

        public IEnumerable<MatriculaAtividade> BuscarAtividades(int idMatricula)
        {
            return adaptador.RepositorioMatriculaAtividade.BuscarPorMatricula(idMatricula);
        }

        // TODO: Definir em qual controller isso deve ser chamado:
        // Listas as disciplinas do aluno no momento para os serviços de retificação.
        public IEnumerable<MatriculaOfertaGradeDisciplina> BuscarDisciplinas(int idMatricula)
        {
            return adaptador.RepositorioMatriculaOfertaGradeDisciplina.BuscarPorMatricula(idMatricula);
        }
    }
}