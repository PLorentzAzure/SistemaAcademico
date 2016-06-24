using SistemaAcademico.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Servico.Dto
{
    [DataContract]
    public class NotaDisciplinaDto
    {
        public NotaDisciplinaDto()
        {
        }

        public NotaDisciplinaDto(Disciplina disciplina, IEnumerable<MatriculaAtividade> atividadesMatricula)
        {
            ConstruirDto(disciplina,atividadesMatricula);
        }

        [DataMember]
        public Disciplina Disciplina { get; set; }

        [DataMember]
        public float Total { get; set; }

        [DataMember]
        public double Nota { get; set; }

        public void ConstruirDto(Disciplina disciplina, IEnumerable<MatriculaAtividade> atividadesMatricula)
        {
            this.Disciplina = disciplina;
            this.Nota = 0;
            this.Total = 0;
            // Soma as notas e valores totais:
            atividadesMatricula.Aggregate(this, (x, y) => { x.Nota += y.Nota; x.Total += y.Atividade.Valor; return x; });
        }
    }
}
