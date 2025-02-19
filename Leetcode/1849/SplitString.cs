using System.Text;

namespace CSharpGeral.Leetcode._1849
{
    public static class SplitString
    {

        //meu nao funfa
        public static bool Split(string str)
        {
            //1. verificar se o primeiro item é maior do que o proximo
            StringBuilder stringBuilder = new StringBuilder();
            int indexWithFirstNumber = -1;
            int indexPrimeiroZeroDepoisNumero = -1;
            int numerosDeZero = 0;
            for (int i = 0; i < str.Length; i++)
            {
                //remove 0 a esquerda
                if (str[i].ToString() != "0" || indexWithFirstNumber != -1)
                {
                    indexWithFirstNumber = i;
                    stringBuilder.Append(str[i]);
                    if (str[i].ToString() == "0")
                    {
                        if (indexPrimeiroZeroDepoisNumero == -1)
                        {
                            indexPrimeiroZeroDepoisNumero = i;
                        }
                        numerosDeZero += 1;
                    }
                }
            }

            //90089
            int stringBuilderLength = stringBuilder.Length;
            int halfLength = stringBuilderLength / 2;
            int resto = stringBuilderLength % 2;

            if (numerosDeZero > resto)
            {
                stringBuilder.Remove(indexPrimeiroZeroDepoisNumero - 1, 1);
            }

            List<int> values = [];
            int aux = 0;
            StringBuilder strAux = new();
            for (int i = 0; i < stringBuilder.Length; i++)
            {
                if (aux <= halfLength / 2)
                {
                    aux++;
                    strAux.Append(stringBuilder[i].ToString());
                    strAux.Append(stringBuilder[i + 1].ToString());
                    values.Add(int.Parse(strAux.ToString()));
                    strAux.Clear();
                    i = i + 2;
                    continue;
                }
                aux = 0;
            }

            Console.WriteLine(stringBuilder);

            return false;
        }


        //certo
        //backtracking tree
        //forca bruta


        public static bool Split2(string s)
        {
            // Remove leading zeros
            s = s.TrimStart('0');
            //se for somente 0 retorna falso
            if (s.Length == 0) return false;

            //Itera sobre a string para tentar gerar o primeiro número.
            //se a string for 1234 o for vai em 1234/2 = 2 + 1 = 3. O numero vai ser no maximo com 3 digitos
            //O mais 1 é pra garantir os casos que a string for par
            for (int i = 1; i <= s.Length / 2 + 1; i++)
            {
                long firstNumber = long.Parse(s.Substring(0, i));
                if (CanSplit(s, i, firstNumber))
                {
                    return true;
                }
            }
            return false;
        }

        private static bool CanSplit(string s, int startIndex, long prevNumber)
        {
            //Verifica se o startIndex (índice atual na string) chegou ao final da string (s.Length).
            // Se o startIndex for igual ao comprimento da string, significa que toda a string foi processada com sucesso e os
            // números decrescentes consecutivos foram encontrados.
            // Portanto, retornamos true.
            if (startIndex == s.Length) return true;


            //O que faz?: Inicia um loop para tentar gerar o próximo número a partir da string,
            //começando do índice startIndex + 1 até o final da string.

            //Por quê?: Precisamos tentar todas as possíveis divisões da string a partir do startIndex
            //para encontrar o próximo número decrescente.
            for (int i = startIndex + 1; i <= s.Length; i++)
            {
                long currentNumber = long.Parse(s.Substring(startIndex, i - startIndex));
                if (currentNumber == prevNumber - 1)
                {
                    if (CanSplit(s, i, currentNumber))
                    {
                        return true;
                    }
                }
                else if (currentNumber > prevNumber)
                {
                    break;
                }
            }
            return false;
        }
    }
}
