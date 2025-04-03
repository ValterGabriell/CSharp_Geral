namespace CSharpGeral.Records
{
    public class Roda
    {
        public void Rodando()
        {
            var post = new PostDto(1, "aaa");
            var pos2 = post with
            {
                Id = 3,
                Name = "novo nome"
            };
        }
    }
    public class Post
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }

    public record PostDto(int Id, string Name);

}
