using SistemaAcademico.Dominio;
using SistemaAcademico.Dominio.Base;
using SistemaAcademico.Negocio.Gerenciador.Base;
using SistemaAcademico.Util.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Negocio.Gerenciador
{
    public class GerenciadorRetificacaoFalta : GerenciadorServico<RetificacaoFalta>
    {
        public GerenciadorRetificacaoFalta(RegistraErro registraErro) : base(registraErro)
        {
        }

        public override bool Inserir(RetificacaoFalta solicitacao, bool apenasValidar = false)
        {
            var erroEncontrado = false;

            if (solicitacao.DataFalta > DateTime.Now)
                RegistrarErro(nameof(solicitacao.DataFalta), "Data inválida.", ref erroEncontrado);

            return base.Inserir(solicitacao, apenasValidar || erroEncontrado);
        }

        public IEnumerable<RetificacaoFalta> BuscarPorPessoa(int idPessoa, PerfilPessoa perfil)
        {
            if (perfil == PerfilPessoa.Aluno)
                return adaptador.RepositorioRetificacaoFalta.BuscarPorAluno(idPessoa);
            else if (perfil == PerfilPessoa.Professor)
                return adaptador.RepositorioRetificacaoFalta.BuscarPorProfessor(idPessoa);
            return Enumerable.Empty<RetificacaoFalta>();
        }

        public bool AlterarStatus(int id, Servico.StatusServico novoStatus)
        {
            var solicitacao = Buscar(id);
            if (solicitacao != null && solicitacao.Status == Servico.StatusServico.Pendente && novoStatus != Servico.StatusServico.Pendente)
            {
                solicitacao.Status = novoStatus;
                if (Editar(solicitacao))
                    return true;
            }
            RegistrarErro(nameof(solicitacao.Status), "Alteração de status inválida.");
            return false;
        }
    }
}
