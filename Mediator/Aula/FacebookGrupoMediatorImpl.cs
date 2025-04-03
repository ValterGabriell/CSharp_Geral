namespace CSharpGeral.Mediator.Aula
{
    public class FacebookGrupoMediatorImpl : IFacebookGrupoMediator
    {
        List<Usuario> usuarios = new List<Usuario>();
        public void RegisterUser(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        public void SendMessage(string mensagem, Usuario usuario)
        {
            foreach (var user in usuarios)
            {
                if (user != usuario)
                {
                    user.Received(mensagem);
                }
            }
        }
    }
}
