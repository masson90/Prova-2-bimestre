using System.Web;
using System.Web.Mvc;

namespace Prova_2_bimestre
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
