using System.IO;
using Xunit;

namespace xunit1
{
    public class Class4 : IClassFixture<ArchivoPruebaFixture>
    {

        private readonly ArchivoPruebaFixture _fixture;

        public Class4(ArchivoPruebaFixture fixture) 
        {
            _fixture = fixture;
        }

        [Fact]
        public void PruebaDeLectura() 
        {
            //Arrange
            var contenido = File.ReadAllText(_fixture.RutaDelArchivo);

            //Assert
            Assert.Equal("Contenido Inicial", contenido);

        }

        [Fact]
        public void PruebaDeEscritura()
        {
            //Arrange
            var NuevoContenido = "Nuevo Contenido";
            
            File.WriteAllText(_fixture.RutaDelArchivo, NuevoContenido);

            //Act
            var contenidoLeido = File.ReadAllText(_fixture.RutaDelArchivo);


            //Assert
            Assert.Equal(NuevoContenido, contenidoLeido);

        }

    }
}
