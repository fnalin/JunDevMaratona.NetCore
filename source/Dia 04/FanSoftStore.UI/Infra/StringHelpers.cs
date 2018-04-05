using System;
using System.Security.Cryptography;
using System.Text;

namespace FanSoftStore.UI.Infra
{
    public static class StringHelpers
    {

        public static string Encrypt(this string senha)
        {

            /*
             Uma vez transformado um texto puro numa hash não há como voltar
             Você deve fazer o mesmo caminho e ver se a senha bate
             */

            //salt => acrescentando uma hash que só o meu sistema sabe
            var salt = "|FFF120DB44774806A51AF58C9580EEE68FE6CA7D65284701AC783328C5360266";

            //Transformar a string num byte[]
            var arrayBytes = Encoding.UTF8.GetBytes(senha + salt);

            byte[] hashBytes;
            using (var sha = SHA512.Create())
            {
                hashBytes = sha.ComputeHash(arrayBytes);
            }

            //Transformando a hash para string64
            return Convert.ToBase64String(hashBytes);
        }
    }
}
