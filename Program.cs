using CSharpGeral.Func;

namespace CSharpGeral
{
    public class Program
    {
        static void Main(string[] args)
        {
            AprenderFunc func = new AprenderFunc();
            var colecao = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var colecaoString = new string[] { "1", "2" };

            var filtroPar = new Func<int, bool>(x => x % 2 == 0);
            var filtroImPar = new Func<int, bool>(x => x % 2 != 0);

            var aprenderFunc = new AprenderFunc();

            var nossoWhere = colecao.NossWhereMethod(filtroPar);
            //var nossoWhere2 = colecaoString.NossWhereMethod();


            func.Processar(colecao, filtroPar);
            func.Processar(colecao, filtroImPar);
            func.Processar(colecao, filtro: (num) => num % 3 == 1);
        }
    }
}