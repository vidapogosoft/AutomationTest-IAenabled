

using System.Linq;

namespace xunit1
{
    public class EsPalindromo
    {
        public bool VerificaPalabra(string texto)
        {

            if(string.IsNullOrEmpty(texto))
            {
                return false;
            }

            var textoLimpio = new string(texto.Where(char.IsLetterOrDigit).ToArray());
            var textoInvertido = new string(textoLimpio.Reverse().ToArray());


            return textoLimpio == textoInvertido;
        }

    }
}
