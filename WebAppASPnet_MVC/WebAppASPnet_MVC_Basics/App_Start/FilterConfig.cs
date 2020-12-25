using System.Web;
using System.Web.Mvc;

namespace WebAppASPnet_MVC_Basics
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
