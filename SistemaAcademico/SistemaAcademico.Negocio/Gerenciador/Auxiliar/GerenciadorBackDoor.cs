using SistemaAcademico.Dados.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Negocio.Gerenciador.Auxiliar
{
    public class GerenciadorBackDoor
    {
        public void ResetarBancoDeDados()
        {
            new RepositorioBackDoor().ResetarBancoDeDados();
        }
    }
}
