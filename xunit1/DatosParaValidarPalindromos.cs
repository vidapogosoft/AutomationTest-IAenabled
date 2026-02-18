using System.Collections;
using System.Collections.Generic;

namespace xunit1
{
    public class DatosParaValidarPalindromos : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            //devolver cada conjunto de datos
            yield return new object[] { "ana", true };
            yield return new object[] { "reconocer", true };
            yield return new object[] { "oso", true };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
