namespace CSharpGeral.Mediator.Aula
{
    public class ConcreteUsuario : Usuario
    {
        public ConcreteUsuario(FacebookGrupoMediatorImpl mediator, string usuarioNome) : base(mediator, usuarioNome)
        {
        }

        public override void Received(string message)
        {
            Console.WriteLine(UsuarioNome + " recebeu > " + message);
        }

        public override void Send(string message)
        {
            Console.WriteLine(UsuarioNome + " enviou > " + message);
            mediator.SendMessage(message, this);
        }
    }
}
