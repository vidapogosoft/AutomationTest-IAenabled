using System;
using System.IO;

namespace xunit1
{
    public class ArchivoPruebaFixture : IDisposable
    {
        public string RutaDelArchivo {  get; set; }

        public ArchivoPruebaFixture() 
        {
                
            RutaDelArchivo = Path.GetTempFileName();
            File.WriteAllText(RutaDelArchivo, "Contenido Inicial");
            Console.WriteLine(RutaDelArchivo);
            
        }


        public void Dispose()
        {
            File.Delete(RutaDelArchivo);
            Console.WriteLine(RutaDelArchivo);
        }

    }
}
