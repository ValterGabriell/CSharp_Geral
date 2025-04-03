namespace CSharpGeral.Mediator.Aula
{
    public abstract class Usuario
    {
        protected FacebookGrupoMediatorImpl mediator;
        public string UsuarioNome { get; private set; }

        public Usuario(FacebookGrupoMediatorImpl mediator, string usuarioNome)
        {
            this.mediator = mediator;
            UsuarioNome = usuarioNome;
        }

        public abstract void Send(string message);
        public abstract void Received(string message);
    }
}
