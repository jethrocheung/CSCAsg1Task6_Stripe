using System.Web;
using System.Web.Mvc;

namespace CSCAsg1Task6_Stripe_AlternateSolution
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
