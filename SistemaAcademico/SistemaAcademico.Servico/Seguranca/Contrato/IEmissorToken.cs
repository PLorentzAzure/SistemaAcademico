namespace SistemaAcademico.Servico.Seguranca.Contrato
{
    public interface IEmissorToken
    {
        string CriaToken(InformacaoToken info);

        bool ValidaToken(string token, out InformacaoToken info);
    }
}