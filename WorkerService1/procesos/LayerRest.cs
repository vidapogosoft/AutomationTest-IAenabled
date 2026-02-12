using WorkerService1.entidades;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WorkerService1.procesos
{
    public class LayerRest
    {

        HttpClient client;

        public List<DTOOrdenReciboRevisada> ListORR;

        public LayerRest()
        {
            client = new HttpClient();
    
        }
        //Definir mis metodos de consuo del rest

        public async Task<List<DTOOrdenReciboRevisada>> ConsumirServicio()
        {
            //Implementar la logica de consumo del servicio REST
            //var uri = new Uri("http://localhost:58470/api/OrdenRecibo/ORRevisadas");
            //https://localhost/tallergdf1/api/OrdenRecibo/ORRevisadas
             
            var uri = new Uri("https://localhost/tallergdf1/api/OrdenRecibo/ORRevisadas");

            var responseget = await client.GetAsync(uri);

            if(responseget.IsSuccessStatusCode)
            {
                //lectura del contenido
                var contenget = await responseget.Content.ReadAsStringAsync();

                //serializar el contenido a la lista de objetos
                ListORR = JsonConvert.DeserializeObject<List<DTOOrdenReciboRevisada>>(contenget);

            }

            return ListORR;

        }



    }
}
