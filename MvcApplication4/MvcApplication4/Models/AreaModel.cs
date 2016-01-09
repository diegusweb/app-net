using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication4.Models
{
    public class AreaModel
    {
        DataEmpresaDataContext context = new DataEmpresaDataContext();

        public List<area> ListarAreas() {
            List<area> lista = new List<area>();

            var consulta = context.PR_LISTAR_AREA();

            foreach (var area in consulta)
            {
                area a = new area();
                a.are_cod = area.are_cod;
                a.are_des = area.are_des;

                lista.Add(a);
            }

            return lista;
        }

        public area buscarArea(int codigo) {
            area a = new area();

            try
            {
                var con = context.PR_BUSCAR_AREA(codigo);

                foreach (var area in con)
                {
                    a.are_cod = area.are_cod;
                    a.are_des = area.are_des;
                }
            }
            catch (Exception)
            {
                
                throw;
            }

            return a;
        }

        public string insertaArea(area a)
        {
            string res = String.Empty;
            try
            {
                context.PR_INSERTAR_AREA(a.are_des);
                res = "OK";
            }
            catch (Exception ex)
            {
                res = ex.Message;
            }
            return res;
        }

        public string ActualizarArea(area a)
        {
            string res = String.Empty;
            try
            {
                context.PR_ACTUALIZAR_AREA(a.are_cod, a.are_des);
                res = "OK";
            }
            catch (Exception ex)
            {
                res = ex.Message;
            }
            return res;
        }

        public string EliminarArea(int codigo)
        {
            string res = String.Empty;
            try
            {
                context.PR_ELIMINAR_AREA(codigo);
            }
            catch (Exception es)
            {

                res = es.Message;
            }
            return res;
        }
    }
}