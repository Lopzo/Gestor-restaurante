using System.Web;
using System.Web.Mvc;

namespace Gestor_de_restaurante.net
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
