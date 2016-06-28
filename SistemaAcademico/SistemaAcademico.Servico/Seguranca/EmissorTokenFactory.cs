using SistemaAcademico.Servico.Seguranca.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Servico.Seguranca
{
    public class EmissorTokenFactory
    {
        private static readonly IEmissorToken _emissor = new EmissorTokenJwt();
        public static IEmissorToken BuscaEmissorToken()
        {
            return _emissor;
        }
    }
}
