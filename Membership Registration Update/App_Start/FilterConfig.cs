using System.Web;
using System.Web.Mvc;

namespace Membership_Registration_Update
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
