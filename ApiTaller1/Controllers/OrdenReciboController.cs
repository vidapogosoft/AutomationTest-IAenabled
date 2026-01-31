using Microsoft.AspNetCore.Mvc;

using ApiTaller1.Interface;

namespace ApiTaller1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdenReciboController : ControllerBase
    {
        private readonly IOrdenRecibo _ior;

        public OrdenReciboController(IOrdenRecibo ior)
        {
            _ior = ior;
        }

        // GET: api/<OrdenReciboController>
        [HttpGet("ORRevisadas")]
        public IActionResult GetORRevisadas()
        {
            return Ok(_ior.ConsultaOrdenesRevisadas);
        }

        // GET api/<OrdenReciboController>/5
        [HttpGet("ByNumero/{numrecibo}")]
        public IActionResult GetObject(string numrecibo)
        {
            return Ok(_ior.ConsultaOrdenRevisadaObject(numrecibo));
        }

        [HttpGet("ORProductosRevisados")]
        public IActionResult ConsultaProductosRevisados()
        {
            return Ok(_ior.ConsultaProductosRevisados);
        }

        [HttpGet("ORProductosRevisados/{ordenrecibo}/{idorden}")]
        public IActionResult ConsultaProductosRevisadosv2(string ordenrecibo, int idorden)
        {
            return Ok(_ior.ConsultaProductosRevisadosv2(ordenrecibo, idorden));
        }

        [HttpGet("ORProductosRevisadosSP")]
        public IActionResult ConsultaProductosRevisadosSP()
        {
            return Ok(_ior.ConsultaProductosRevisadosSP);
        }

        [HttpGet("ORProductosRevisadosSP/{NumRecibo}")]
        public IActionResult ConsultaProductosRevisadosSPv2(string NumRecibo)
        {
            return Ok(_ior.ConsultaProductosRevisadosSPv2(NumRecibo));
        }

        // POST api/<OrdenReciboController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<OrdenReciboController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OrdenReciboController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
