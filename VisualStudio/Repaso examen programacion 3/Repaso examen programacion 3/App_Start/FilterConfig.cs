using System.Web;
using System.Web.Mvc;

namespace Repaso_examen_programacion_3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
