using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMA_Sim
{
    class myRandom
    {
        private bool _hasDeviate;
        private double _storedDeviate;
        private readonly Random _random;

        public myRandom(Random random = null)
        {
            _random = random ?? new Random();
        }
        public double NextPoissonNoEven(double lamda)
        {
            double cdf = _random.NextDouble();
            return -Math.Log(cdf) / lamda;
        }

        public double NextGaussian(double mu = 0, double sigma = 1)
        {
            if (sigma <= 0)
                return mu;

            if (_hasDeviate)
            {
                _hasDeviate = false;
                return _storedDeviate * sigma + mu;
            }

            double v1, v2, rSquared;
            do
            {
                // two random values between -1.0 and 1.0
                v1 = 2 * _random.NextDouble() - 1;
                v2 = 2 * _random.NextDouble() - 1;
                rSquared = v1 * v1 + v2 * v2;
                // ensure within the unit circle
            } while (rSquared >= 1 || rSquared == 0);

            // calculate polar tranformation for each deviate
            var polar = Math.Sqrt(-2 * Math.Log(rSquared) / rSquared);
            // store first deviate
            _storedDeviate = v2 * polar;
            _hasDeviate = true;
            // return second deviate
            return v1 * polar * sigma + mu;
        }
    }
}
