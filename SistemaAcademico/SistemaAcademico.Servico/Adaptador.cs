﻿using SistemaAcademico.Negocio;
using SistemaAcademico.Negocio.Gerenciador;
using SistemaAcademico.Util.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Servico
{
    public class Adaptador
    {
        private RegistraErro registrarErro;

        public Adaptador()
        {
        }

        public Adaptador(RegistraErro registrarErro)
        {
            this.registrarErro = registrarErro;
        }

        private GerenciadorDisciplina _gerenciadorDisciplina;
        public GerenciadorDisciplina GerenciadorDisciplina
        {
            get
            {
                if (this._gerenciadorDisciplina == null)
                    this._gerenciadorDisciplina = new GerenciadorDisciplina(registrarErro);

                return this._gerenciadorDisciplina;
            }
        }

        private GerenciadorRetificacaoFalta _gerenciadorRetificacaoFalta;
        public GerenciadorRetificacaoFalta GerenciadorRetificacaoFalta
        {
            get
            {
                if (this._gerenciadorRetificacaoFalta == null)
                    this._gerenciadorRetificacaoFalta = new GerenciadorRetificacaoFalta(registrarErro);

                return this._gerenciadorRetificacaoFalta;
            }
        }

    }
}
