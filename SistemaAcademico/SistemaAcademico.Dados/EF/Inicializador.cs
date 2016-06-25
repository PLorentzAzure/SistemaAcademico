using SistemaAcademico.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAcademico.Dados;
using SistemaAcademico.Dados.Contrato;

namespace SistemaAcademico.Dados.EF
{
    internal class Inicializador : DropCreateDatabaseIfModelChanges<ContextoEntity>
    {
        protected override void Seed(ContextoEntity contexto)
        {
            CargaInicial.CarregaDados(contexto);
        }
    }
}

