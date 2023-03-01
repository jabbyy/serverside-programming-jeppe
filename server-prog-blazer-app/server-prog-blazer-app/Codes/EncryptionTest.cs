using Microsoft.AspNetCore.DataProtection;
namespace server_prog_blazer_app.Codes
{

    public class EncryptionTest
    {
        private readonly IDataProtector _dataProtection;

        public EncryptionTest(IDataProtectionProvider protector)
        {
            _dataProtection = protector.CreateProtector("server-prog-blazer-app.codes.EncryptionTest.JeppeMunk");
        }
        public string Protect(string valueToEncrypt) => _dataProtection.Protect(valueToEncrypt);
        public string UnProtect(string valueToDecrypt) => _dataProtection.Unprotect(valueToDecrypt);
    }
}
 