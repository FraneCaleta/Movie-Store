using System.Web.Mvc;

namespace PMF_Movie_Store
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute()); //error page when exception
            filters.Add(new AuthorizeAttribute()); // obvezna autentikacija svugdje
            filters.Add(new RequireHttpsAttribute());
        }
    }
}
