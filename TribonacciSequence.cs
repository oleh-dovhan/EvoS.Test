using MathNet.Numerics.LinearAlgebra;

namespace EvoS.Test
{
    static class TribonacciSequence
    {
        private static readonly Vector<double> initial;
        private static readonly Matrix<double> M;


        static TribonacciSequence()
        {
            initial = Vector<double>.Build.DenseOfArray(new double[] { 1, 1, 1 });
            M = Matrix<double>.Build.DenseOfArray(new double[,]
            {
                { 1, 1, 1 },
                { 1, 0, 0 },
                { 0, 1, 0 },
            });
        }

        public static double[] GetPart(int n, int k)
        {
            if (n <= 0 || n > k) return new double[0];

            var part = new double[k - n + 1];

            var Mn = M.Power(n - 1);

            var start = Mn.Multiply(initial).AsArray();
            for (int i = 0; i < start.Length && i < part.Length; ++i)
            {
                part[i] = start[start.Length - i - 1];
            }

            for (int i = start.Length; i < part.Length; ++i)
            {
                part[i] = part[i - 1] + part[i - 2] + part[i - 3];
            }

            return part;
        }
    }
}