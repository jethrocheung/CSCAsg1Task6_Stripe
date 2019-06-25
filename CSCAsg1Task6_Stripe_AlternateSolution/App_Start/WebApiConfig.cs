using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Stripe;


namespace CSCAsg1Task6_Stripe_AlternateSolution
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            StripeConfiguration.ApiKey = "sk_test_WY2FprMXBfRq39p1I1efl5dq00aPwFXMnA";

            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
