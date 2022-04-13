using System.Web;
using System.Web.Mvc;

namespace Localization_with_dynamic_culture
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
