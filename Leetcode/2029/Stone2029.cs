namespace CSharpGeral.Leetcode._2029
{
    public static class Stone2029
    {
        public static bool Stones()
        {
            int[] stones = { 5, 1, 2, 4, 3 };

            int somaDosValores = 0;

            /*
             0- Alice
             1- Bob
             */
            int lastPlayed = 0;
            for (int i = 0; i < stones.Length; i++)
            {
                somaDosValores += stones[i];
                lastPlayed = i % 2 == 0 ? 0 : 1;
                if (somaDosValores % 3 == 0) return lastPlayed == 0 ? true : false;
            }
            if (somaDosValores % 3 != 0) return false;
            return false;
        }
    }
}
