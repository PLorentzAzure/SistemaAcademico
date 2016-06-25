using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dominio
{
    [DataContract]
    public class Curso : Base.Dominio
    {
        [DataMember]
        public string Nome { get; set; }

        public virtual ICollection<Grade> Grades { get; set; }
    }
}
