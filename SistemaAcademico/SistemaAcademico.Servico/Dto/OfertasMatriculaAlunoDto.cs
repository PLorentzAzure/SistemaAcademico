using SistemaAcademico.Dominio;
using SistemaAcademico.Servico.Dto.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Servico.Dto
{
    [DataContract]
    public class OfertasMatriculaAlunoDto
    {
        public OfertasMatriculaAlunoDto()
        {

        }

        [DataMember]
        public Disciplina Disciplina { get; set; }

        [DataMember]
        public int IdOferta { get; set; }
    }
}
