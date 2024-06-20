using System.Security.Cryptography;

namespace WebAppForDocker.RSATools
{
    public class RSAExtensions
    {
        public RSA GeneratePrivateKey()
        {
            var key = File.ReadAllText(@"../private_key.pem");
            var rsa = RSA.Create();

            rsa.ImportFromPem(key);

            return rsa;
        }
    }
}
