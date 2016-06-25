using SistemaAcademico.Dados.Contrato;
using SistemaAcademico.Dados.Repositorio.Base;
using SistemaAcademico.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Dados.EF
{
    public class RepositorioBackDoor 
    {

        public RepositorioBackDoor()
        {
        
        }

        public void ResetarBancoDeDados()
        {
            using (var contexto = new ContextoEntity("name=Contexto"))
                contexto.Database.Delete();
        }
    }
}
