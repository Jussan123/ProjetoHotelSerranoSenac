using System.Security.Cryptography;
using System.Text;

namespace ProjetoHotelSerranoSenac.Controllers
{
    public class Login
    {
        public static bool GetLogin(string email, string senha)
        {
            Models.Funcionario funcionario = Controllers.Funcionario.GetFuncionarioByEmail(email);
            string hashSenha = GenerateHashCode(StringToInt(senha)).ToString();

            return funcionario.Senha == hashSenha;
        }

        public static int StringToInt(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                int result = BitConverter.ToInt32(hashBytes, 0);
                return result;
            }
        }

        public static int GenerateHashCode(int hashValue)
        {
            unchecked 
            {
                int hash = (int)2166136261; 
                hash = (hash * 16777619) ^ hashValue; 
                return hash;
            }
        }

        public static byte[] Encrypt(string data, byte[] key) // AES Algorithm
        {
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(data);
                        }
                        return msEncrypt.ToArray();
                    }
                }
            }
        }
    }
}