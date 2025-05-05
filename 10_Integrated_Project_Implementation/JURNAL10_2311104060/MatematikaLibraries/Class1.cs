namespace MatematikaLibraries
{
    public class Matematika
    {
        // A. FPB
        public static int FPB(int input1, int input2)
        {
            while (input2 != 0)
            {
                int temp = input2;
                input2 = input1 % input2;
                input1 = temp;
            }
            return input1;
        }

        // B. KPK
        public static int KPK(int input1, int input2)
        {
            return (input1 * input2) / FPB(input1, input2);
        }

        // C. Turunan
        public static string Turunan(int[] persamaan)
        {
            List<string> hasil = new List<string>();
            for (int i = 0; i < persamaan.Length - 1; i++)
            {
                int pangkat = persamaan.Length - i - 1;
                int koef = persamaan[i] * pangkat;

                if (koef == 0) continue;

                string suku = koef.ToString();
                if (pangkat - 1 > 1)
                    suku += $"x^{pangkat - 1}";
                else if (pangkat - 1 == 1)
                    suku += "x";

                hasil.Add(suku);
            }
            return string.Join(" + ", hasil);
        }

        // D. Integral
        public static string Integral(int[] persamaan)
        {
            List<string> hasil = new List<string>();
            for (int i = 0; i < persamaan.Length; i++)
            {
                int pangkat = persamaan.Length - i;
                double koef = (double)persamaan[i] / pangkat;

                string suku = $"{koef}x^{pangkat}";
                hasil.Add(suku);
            }
            hasil.Add("C");
            return string.Join(" + ", hasil);
        }
    }
}
