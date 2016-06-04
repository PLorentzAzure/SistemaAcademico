﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Servico.Models.Dto.Base
{
    [DataContract]
    public abstract class Dto <TDominio> where TDominio: Dominio.Base.Dominio
    {
        [DataMember]
        public int Id { get; set; }

        public abstract TDominio ConstruirDominio();

        public abstract void ConstruirDto(TDominio entidade);
    }
}
