﻿using SistemaAcademico.Dados;
using SistemaAcademico.Dados.Contrato;
using SistemaAcademico.Dados.Repositorio.Base;
using SistemaAcademico.Util.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Negocio.Gerenciador.Base
{
    public class Gerenciador : IDisposable
    {
        protected readonly Adaptador adaptador;

        protected RegistraErro registrarErroCliente;

        public Gerenciador()
            : this (null)
        {
        }

        public Gerenciador(RegistraErro registroErros)
            : this(registroErros, new Adaptador())
        {
        }

        public Gerenciador(RegistraErro registroErros, Adaptador adaptador)
        {
            this.adaptador = adaptador;
            this.registrarErroCliente = registroErros;
        }

        public Gerenciador(RegistraErro registroErros, IContexto contextoExistente)
            : this(registroErros, new Adaptador(contextoExistente))
        {
        }

        protected virtual void RegistrarErro(string chave, string mensagem)
        {
            registrarErroCliente?.Invoke(chave, mensagem);
        }

        protected virtual void RegistrarErro(string chave, string mensagem, ref bool errosRegistrados)
        {
            RegistrarErro(chave, mensagem);
            errosRegistrados = true;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
                adaptador.Dispose();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
