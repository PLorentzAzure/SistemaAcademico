﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dominio.DTO
{
    [DataContract]
    public class RetificacaoFaltaDTO
    {
        public RetificacaoFaltaDTO()
        {

        }

        public RetificacaoFaltaDTO(RetificacaoFalta retificacao)
        {
            this.Id = retificacao.Id;
            this.NomeAluno = retificacao.Matricula.Aluno.Nome;
            this.IdDisciplina = retificacao.OfertaGradeDisciplina.GradeDisciplina.IdDisciplina;
            this.NomeDisciplina = retificacao.OfertaGradeDisciplina.GradeDisciplina.Disciplina.Nome;
            this.DataFalta = retificacao.Data;
            this.Justificativa = retificacao.Justificativa;
            this.IdStatus = (int)retificacao.Status;
            this.NomeStatus = retificacao.Status.ToString();
            this.DataRequisicao = retificacao.Data; // TODO: Mapear no banco.
        }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string NomeAluno { get; set; }

        [DataMember]
        public int IdDisciplina { get; set; }

        [DataMember]
        public string NomeDisciplina { get; set; }

        [DataMember]
        public DateTime DataFalta { get; set; }

        [DataMember]
        public string Justificativa { get; set; }

        [DataMember]
        public int IdStatus { get; set; }

        [DataMember]
        public string NomeStatus { get; set; }

        [DataMember]
        public DateTime DataRequisicao { get; set; }
    }
}