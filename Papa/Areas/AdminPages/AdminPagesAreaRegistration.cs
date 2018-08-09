using System.Web.Mvc;

namespace Papa.Areas.AdminPages
{
    public class AdminPagesAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "AdminPages";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "AdminPages_default",
                "AdminPages/{controller}/{action}/{id}",
                new { action = "Index", Controller ="Deafault", id = UrlParameter.Optional }
            );
        }
    }
}