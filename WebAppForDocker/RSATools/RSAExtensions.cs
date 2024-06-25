using System.Security.Cryptography;

namespace WebAppForDocker.RSATools
{
    public class RSAExtensions
    {
        public RSA GeneratePrivateKey()
        {
            var key = File.ReadAllText(@"../Keys/private_key.pem");
            var rsa = RSA.Create();

            rsa.ImportFromPem(key);

            return rsa;
        }

        public RSA GeneratePublicKey()
        {
            var key = File.ReadAllText(@"../Keys/public_key.pem");
            var rsa = RSA.Create();

            rsa.ImportFromPem(key);

            return rsa;
        }
    }
}
