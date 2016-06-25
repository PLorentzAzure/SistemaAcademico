using SistemaAcademico.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Servico.Tests.Comparador
{
    internal class RetificacaoFaltaEqualityComparer : IEqualityComparer<RetificacaoFalta>
    {
        public bool Equals(RetificacaoFalta x, RetificacaoFalta y)
        {
            return MontaString(x) == MontaString(y);
        }

        public int GetHashCode(RetificacaoFalta obj)
        {
            return MontaString(obj).GetHashCode();
        }

        private static string MontaString(RetificacaoFalta x)
        {
            return $"{x.Id}|{x.DataFalta}|{x.DataRequisicao}|{x.IdMatricula}|{x.IdOferta}";
        }
    }
}
