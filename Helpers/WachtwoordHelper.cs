using System;
using System.Security.Cryptography;
using System.Text;

namespace E3_Barroc_Intens.Helpers
{
    public static class WachtwoordHelper
    {

        //Stack overflow

        private const int Iteraties = 100000;
        private const int SaltLengte = 16;
        private const int HashLengte = 32;

        public static string Hash(string wachtwoord)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(SaltLengte);
            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(wachtwoord), salt, Iteraties, HashAlgorithmName.SHA256, HashLengte);

            return $"{Iteraties}.{Convert.ToBase64String(salt)}.{Convert.ToBase64String(hash)}";
        }

        public static bool Controleer(string wachtwoord, string opgeslagenHash)
        {
            string[] delen = opgeslagenHash.Split('.');
            if (delen.Length != 3) return false;

            int iteraties = int.Parse(delen[0]);
            byte[] salt = Convert.FromBase64String(delen[1]);
            byte[] verwacht = Convert.FromBase64String(delen[2]);

            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(wachtwoord), salt, iteraties, HashAlgorithmName.SHA256, verwacht.Length);

            return CryptographicOperations.FixedTimeEquals(hash, verwacht);
        }
    }
}