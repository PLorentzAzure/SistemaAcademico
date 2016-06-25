﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dominio
{
    [DataContract]
    public class Grade : Base.Dominio
    {
        [DataMember]
        public string Nome { get; set; }

        [ForeignKey(nameof(Curso))]
        public int IdCurso { get; set; }

        public bool Ativa { get; set; }

        public virtual Curso Curso { get; set; }

        [DataMember]
        public virtual ICollection<GradeDisciplina> GradeDisciplinas { get; set; }
    }
}
