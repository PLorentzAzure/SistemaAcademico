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
    // TODO: Revisar nome da classe Adaptador.
    public class Adaptador: IDisposable
    {
        private readonly RegistraErro registrarErro;

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

        private GerenciadorMatricula _gerenciadorMatricula;
        public GerenciadorMatricula GerenciadorMatricula
        {
            get
            {
                if (this._gerenciadorMatricula == null)
                    this._gerenciadorMatricula = new GerenciadorMatricula(registrarErro);

                return this._gerenciadorMatricula;
            }
        }

        private GerenciadorMatriculaAtividade _gerenciadorMatriculaAtividade;
        public GerenciadorMatriculaAtividade GerenciadorMatriculaAtividade
        {
            get
            {
                if (this._gerenciadorMatriculaAtividade == null)
                    this._gerenciadorMatriculaAtividade = new GerenciadorMatriculaAtividade(registrarErro);

                return this._gerenciadorMatriculaAtividade;
            }
        }

        private GerenciadorUsuario _gerenciadorUsuario;
        public GerenciadorUsuario GerenciadorUsuario
        {
            get
            {
                if (this._gerenciadorUsuario == null)
                    this._gerenciadorUsuario = new GerenciadorUsuario(registrarErro);

                return this._gerenciadorUsuario;
            }
        }

        private GerenciadorAluno _gerenciadorAluno;
        public GerenciadorAluno GerenciadorAluno
        {
            get
            {
                if (this._gerenciadorAluno == null)
                    this._gerenciadorAluno = new GerenciadorAluno(registrarErro);

                return this._gerenciadorAluno;
            }
        }

        private GerenciadorGradeDisciplina _gerenciadorGradeDisciplina;
        public GerenciadorGradeDisciplina GerenciadorGradeDisciplina
        {
            get
            {
                if (this._gerenciadorGradeDisciplina == null)
                    this._gerenciadorGradeDisciplina = new GerenciadorGradeDisciplina(registrarErro);

                return this._gerenciadorGradeDisciplina;
            }
        }

        private GerenciadorCurso _gerenciadorCurso;
        public GerenciadorCurso GerenciadorCurso
        {
            get
            {
                if (this._gerenciadorCurso == null)
                    this._gerenciadorCurso = new GerenciadorCurso(registrarErro);

                return this._gerenciadorCurso;
            }
        }

        private GerenciadorGrade _gerenciadorGrade;
        public GerenciadorGrade GerenciadorGrade
        {
            get
            {
                if (this._gerenciadorGrade == null)
                    this._gerenciadorGrade = new GerenciadorGrade(registrarErro);

                return this._gerenciadorGrade;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _gerenciadorDisciplina?.Dispose();
                _gerenciadorRetificacaoFalta?.Dispose();
                _gerenciadorMatricula?.Dispose();
                _gerenciadorMatriculaAtividade?.Dispose();
                _gerenciadorUsuario?.Dispose();
                _gerenciadorAluno?.Dispose();
                _gerenciadorGradeDisciplina?.Dispose();
            }
        }
    }
}
