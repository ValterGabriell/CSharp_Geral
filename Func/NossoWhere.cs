namespace CSharpGeral.Func
{
    public static class NossoWhere
    {
        public static TEntrada[] NossWhereMethod<TEntrada>(this TEntrada[] colecao, Func<TEntrada, bool> filtroWhere)
        {
            var listaRetorno = new List<TEntrada>();
            foreach (var item in colecao)
            {
                if (filtroWhere(item))
                    listaRetorno.Add(item);
            }
            return listaRetorno.ToArray();
        }
    }
}
