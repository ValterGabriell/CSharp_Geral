namespace CSharpGeral.Mediator.Aula2
{
    public interface IMediator
    {
        Task<string> NotifyAsync(object sender, string eventType, object data);
    }
}
