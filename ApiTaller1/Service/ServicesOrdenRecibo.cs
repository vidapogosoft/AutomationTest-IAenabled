using ApiTaller1.DA;
using ApiTaller1.Interface;
using ApiTaller1.Model.dto;
using ormdb.Models.Database;

namespace ApiTaller1.Service
{
    public class ServicesOrdenRecibo : IOrdenRecibo
    {
        public DataRepositoryOrdenRecibo data = new DataRepositoryOrdenRecibo();

        public IEnumerable<OrdenReciboRevisada> ConsultaOrdenesRevisadas
        {
            get { return data.ConsultaOrdenesRevisada(); }
        }

        public IEnumerable<OrdenReciboRevisada> ConsultaOrdenRevisada(string ruc)
        {
            return data.ConsultaOrdenRevisada(ruc);
        }

        public OrdenReciboRevisada? ConsultaOrdenRevisadaObject(string numorden)
        {
            return data.ConsultaOrdenRevisadaObject(numorden);
        }

        public IEnumerable<DtoORProductosRevisados> ConsultaProductosRevisados
        {
            get { return data.ConsultaProductosRevisados(); }
        }

        public IEnumerable<DtoORProductosRevisados> ConsultaProductosRevisadosv2(string ordenrecibo, int idorden)
        {
           return data.ConsultaProductosRevisadosv2(ordenrecibo, idorden);
        }

        public IEnumerable<ormdb.Models.DTO.DtoORProductosRevisados> ConsultaProductosRevisadosSP
        {
            get { return data.ConsultaProductosRevisadosSP(); }
        }
    }
}
