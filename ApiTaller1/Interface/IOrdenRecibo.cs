using ApiTaller1.Model.dto;
using ormdb.Models.Database;

namespace ApiTaller1.Interface
{
    public interface IOrdenRecibo
    {
        //se define los metodos que se van a implementar en la clase OrdenRecibo

        IEnumerable<OrdenReciboRevisada> ConsultaOrdenesRevisadas { get; }

        IEnumerable<OrdenReciboRevisada> ConsultaOrdenRevisada(string ruc);

        OrdenReciboRevisada? ConsultaOrdenRevisadaObject(string numorden);

        IEnumerable<DtoORProductosRevisados> ConsultaProductosRevisados { get; }
        IEnumerable<DtoORProductosRevisados> ConsultaProductosRevisadosv2(string ordenrecibo, int idorden);

        IEnumerable<ormdb.Models.DTO.DtoORProductosRevisados> ConsultaProductosRevisadosSP { get; }
        IEnumerable<ormdb.Models.DTO.DtoORProductosRevisados> ConsultaProductosRevisadosSPv2(string NumRecibo);

    }
}
