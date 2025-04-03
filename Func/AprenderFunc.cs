namespace CSharpGeral.Func
{
    public class AprenderFunc
    {

        public void Processar(int[] colecao, Func<int, bool>? filtro = null)
        {
            foreach (var curr in colecao)
            {
                if (filtro == null || filtro(curr))
                    Console.WriteLine(curr);
            }
        }

    }
}
