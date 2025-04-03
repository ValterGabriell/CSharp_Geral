namespace CSharpGeral.Mediator.Aula
{
    public interface IFacebookGrupoMediator
    {
        void SendMessage(string mensagem, Usuario usuario);
        void RegisterUser(Usuario usuario);
    }
}
