using System.Web.Mvc;

namespace bigfoot.technology.Areas.bigfoottechnologynepal
{
    public class bigfoottechnologynepalAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "bigfoottechnologynepal";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "bigfoottechnologynepal_default",
                "bigfoottechnologynepal/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}