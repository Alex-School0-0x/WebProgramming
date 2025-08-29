using Microsoft.AspNetCore.DataProtection;
using System.Security.Cryptography;

namespace WebProgramming.Codes;

public class SymetricEncryption
{
    private readonly IDataProtector _key;

    public SymetricEncryption(IDataProtectionProvider key) =>    
        _key = key.CreateProtector(new RSACryptoServiceProvider().ToXmlString(false));
    
    public string Encrypt(string plainText) => _key.Protect(plainText);
    public string Decrypt(string textToDecrypt) => _key.Unprotect(textToDecrypt);
}
