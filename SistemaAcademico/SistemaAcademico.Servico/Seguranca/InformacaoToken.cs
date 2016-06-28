using SistemaAcademico.Dominio;
using SistemaAcademico.Dominio.Base;
using System.Runtime.Serialization;

namespace SistemaAcademico.Servico.Seguranca
{
    [DataContract]
    public class InformacaoToken
    {
        public InformacaoToken()
        {
        }

        public InformacaoToken(Usuario usuario)
            : this(usuario, usuario?.Pessoa)
        {
        }

        internal InformacaoToken(Usuario usuario, Pessoa pessoa)
        {
            this.IdUsuario = usuario.Id;
            this.TipoPerfil = pessoa?.Perfil ?? 0;
            this.IdPessoa = pessoa.Id;
        }

        [DataMember]
        public int IdUsuario { get; internal set; }

        [DataMember]
        public int? IdPessoa { get; internal set; }

        [DataMember]
        public PerfilPessoa TipoPerfil { get; internal set; }
    }
}