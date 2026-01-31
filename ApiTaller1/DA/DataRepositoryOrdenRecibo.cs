using ApiTaller1.Interface;
using ApiTaller1.Model.dto;
using Microsoft.EntityFrameworkCore;
using ormdb.Models.Database;

namespace ApiTaller1.DA
{
    public class DataRepositoryOrdenRecibo
    {
        public List<OrdenReciboRevisada> ConsultaOrdenesRevisada()
        {
            using (var ctx =  new OrdenreciboContext())
            {
                return ctx.OrdenReciboRevisadas.ToList();
            }

        }

        public List<OrdenReciboRevisada> ConsultaOrdenRevisada(string ruc)
        {
            using (var ctx = new OrdenreciboContext())
            {
                return ctx.OrdenReciboRevisadas.Where(a=> a.RucProveedor == ruc).ToList();
            }
        }

        public OrdenReciboRevisada? ConsultaOrdenRevisadaObject(string numorden)
        {
            using (var ctx = new OrdenreciboContext())
            {
                return ctx.OrdenReciboRevisadas.Where(a => a.NumOrdenRecibo == numorden).FirstOrDefault();
            }
        }

        public List<DtoORProductosRevisados> ConsultaProductosRevisados()
        {
            using (var ctx = new OrdenreciboContext())
            {

                var query = (
                    
                    from orr in ctx.OrdenReciboRevisadas
                    join orrp in ctx.OrdenReciboProductosRevisados 
                    on orr.IdOrdenRecibo equals orrp.IdOrdenRecibo

                    select new DtoORProductosRevisados()
                    {
                        IdOR = orr.IdOrdenRecibo,
                        NumOrdenRecibo = orr.NumOrdenRecibo,
                        CodigoCedis = orr.CodigoCedis,
                        Cedis = orr.Cedis,
                        RucProveedor = orr.RucProveedor,
                        Proveedor = orr.Proveedor,
                        SkuProducto = orrp.SkuProducto,
                        DescripcionProducto = orrp.DescripcionProducto,
                        Ubicacion = orrp.Ubicacion,
                        UxC = orrp.UxC,
                        PalletsPeq = orrp.PalletsPeq,
                        PalletsGran = orrp.PalletsGran,
                        CantidadRevisada = orrp.CantidadRevisada,
                        CantidadCompra = orrp.CantidadCompra,
                        FechaFabricacion = orrp.FechaFabricacion,
                        FechaVencimiento = orrp.FechaVencimiento

                    }).ToList();

                return query;
            }

        }


        public List<DtoORProductosRevisados> ConsultaProductosRevisadosv2(string ordenrecibo, int idorden)
        {
            using (var ctx = new OrdenreciboContext())
            {

                var query = (

                    from orr in ctx.OrdenReciboRevisadas
                    join orrp in ctx.OrdenReciboProductosRevisados
                    on orr.IdOrdenRecibo equals orrp.IdOrdenRecibo
                    where orr.NumOrdenRecibo == ordenrecibo && orr.IdOrdenRecibo == idorden

                    select new DtoORProductosRevisados()
                    {
                        IdOR = orr.IdOrdenRecibo,
                        NumOrdenRecibo = orr.NumOrdenRecibo,
                        CodigoCedis = orr.CodigoCedis,
                        Cedis = orr.Cedis,
                        RucProveedor = orr.RucProveedor,
                        Proveedor = orr.Proveedor,
                        SkuProducto = orrp.SkuProducto,
                        DescripcionProducto = orrp.DescripcionProducto,
                        Ubicacion = orrp.Ubicacion,
                        UxC = orrp.UxC,
                        PalletsPeq = orrp.PalletsPeq,
                        PalletsGran = orrp.PalletsGran,
                        CantidadRevisada = orrp.CantidadRevisada,
                        CantidadCompra = orrp.CantidadCompra,
                        FechaFabricacion = orrp.FechaFabricacion,
                        FechaVencimiento = orrp.FechaVencimiento

                    }).ToList();

                return query;
            }

        }

        public List<ormdb.Models.DTO.DtoORProductosRevisados> ConsultaProductosRevisadosSP()
        {
            using (var ctx = new OrdenreciboContext())
            {
                return ctx.Resultado.FromSqlRaw("ConsultaProductosRevisados").ToList();
            }
        }

        public List<ormdb.Models.DTO.DtoORProductosRevisados> ConsultaProductosRevisadosSPv2(string NumRecibo)
        {
            using (var ctx = new OrdenreciboContext())
            {
                return ctx.Resultado.FromSqlRaw("ConsultaProductosRevisadosv2 {0}", NumRecibo).ToList();
            }
        }


    }
}
