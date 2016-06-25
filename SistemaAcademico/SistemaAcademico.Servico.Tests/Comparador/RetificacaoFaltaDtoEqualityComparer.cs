using SistemaAcademico.Dominio;
using SistemaAcademico.Servico.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Servico.Tests.Comparador
{
    internal class RetificacaoFaltaDtoEqualityComparer : IEqualityComparer<RetificacaoFaltaDto>
    {
        public bool Equals(RetificacaoFaltaDto x, RetificacaoFaltaDto y)
        {
            return MontaString(x) == MontaString(y);
        }

        public int GetHashCode(RetificacaoFaltaDto obj)
        {
            return MontaString(obj).GetHashCode();
        }

        private static string MontaString(RetificacaoFaltaDto x)
        {
            return $"{x.Id}|{x.DataFalta}|{x.IdMatricula}|{x.IdOferta}";
        }
    }
}
