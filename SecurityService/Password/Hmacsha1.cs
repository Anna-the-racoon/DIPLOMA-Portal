using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace SecurityService.Password
{
    public class Hmacsha1 : IEncryptor
    {
        public string Execute(string password)
        {
            var salt = System.Text.Encoding.Unicode.GetBytes("QmH%j4#JXR");
            var hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));
            return hashed;
        }
    }
}