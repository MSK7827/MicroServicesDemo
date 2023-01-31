using Microsoft.AspNetCore.Mvc.Filters;

namespace SorApi.ServiceContext
{
    public class SorServiceContext : ActionFilterAttribute
    {
        private readonly IHttpContextAccessor _contextAccessor;
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var routedata = context.HttpContext.GetRouteData();
            if (routedata != null)
            {
                var institutionId = routedata.Values["InstitutionId"];
                var EnvironMentId = routedata.Values["EnvironMentId"];
                var ProductId = routedata.Values["ProductId"];

            }

        }
    }
}
