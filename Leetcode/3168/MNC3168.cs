namespace CSharpGeral.Leetcode._3168
{
    public static class MNC3168
    {
        public static int calculate(string s)
        {
            if (s.Length == 0) return 0;
            if (s.Length == 1 && s[0].ToString() == "E") return 1;
            if (s.Length == 1 && s[0].ToString() == "L") return 0;


            int PeopleintheWaitingRoom = 0;
            int maxNumPessoasSala = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].ToString() == "E")
                {
                    PeopleintheWaitingRoom++;
                    if (PeopleintheWaitingRoom > maxNumPessoasSala) maxNumPessoasSala = PeopleintheWaitingRoom;
                };
                if (s[i].ToString() == "L")
                {
                    PeopleintheWaitingRoom--;
                };
            }
            return maxNumPessoasSala;
        }
    }
}
