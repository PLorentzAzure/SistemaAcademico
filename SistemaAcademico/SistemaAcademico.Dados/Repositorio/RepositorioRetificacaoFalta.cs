﻿using SistemaAcademico.Dados.Contrato;
using SistemaAcademico.Dados.Repositorio.Base;
using SistemaAcademico.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dados.Repositorio
{
    public class RepositorioRetificacaoFalta : Repositorio<RetificacaoFalta>
    {
        public RepositorioRetificacaoFalta() : base()
        {

        }

        public RepositorioRetificacaoFalta(IContexto contexto) : base(contexto)
        {

        }

        public override IEnumerable<RetificacaoFalta> Buscar()
        {
            return dbSet.Include(rf => rf.Matricula.Aluno)
                        .Include(rf => rf.Oferta.GradeDisciplina.Disciplina);
        }

        public IEnumerable<RetificacaoFalta> BuscarPorAluno(int idAluno)
        {
            return Buscar().Where(rf => rf.Matricula.IdAluno == idAluno);
        }

        public IEnumerable<RetificacaoFalta> BuscarPorProfessor(int idProfessor)
        {
            return Buscar().Where(rf => rf.Oferta.IdProfessor == idProfessor);
        }

        public override RetificacaoFalta Buscar(int id)
        {
            return Buscar().FirstOrDefault(rf => rf.Id == id);
        }
    }
}
