using System.Web;
using System.Web.Mvc;

namespace Obligatorio_programacion_3_de_nuevo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
