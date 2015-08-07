using System.Web;
using System.Web.Mvc;

namespace Hanusoft_Website_Official
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}