namespace AljabarLibrarys
{
    public class Aljabar
    {
        public static double[] AkarPersamaanKuadrat(double[] persamaan)
        {
            if (persamaan.Length != 3)
                throw new ArgumentException("Parameter harus terdiri dari 3 elemen: a, b, c");

            double a = persamaan[0];
            double b = persamaan[1];
            double c = persamaan[2];

            double diskriminan = b * b - 4 * a * c;

            if (diskriminan < 0)
                throw new ArgumentException("Akar imajiner tidak didukung.");

            double akar1 = (-b + Math.Sqrt(diskriminan)) / (2 * a);
            double akar2 = (-b - Math.Sqrt(diskriminan)) / (2 * a);

            return new double[] { akar1, akar2 };
        }

        // Fungsi untuk menghitung hasil kuadrat dari persamaan berpangkat 1
        public static double[] HasilKuadrat(double[] persamaan)
        {
            if (persamaan.Length != 2)
                throw new ArgumentException("Parameter harus terdiri dari 2 elemen: a dan b");

            double a = persamaan[0];
            double b = persamaan[1];

            double hasilA = a * a;
            double hasilTengah = 2 * a * b;
            double hasilB = b * b;

            return new double[] { hasilA, hasilTengah, hasilB };
        }
    }
}

