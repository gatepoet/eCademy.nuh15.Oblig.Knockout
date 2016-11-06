using System.Web;
using System.Web.Mvc;

namespace eCademy.Oblig.Knockout
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
