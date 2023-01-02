using Microsoft.AspNetCore.Mvc.Filters;
using EnvironMentApi.Constants;

namespace EnvironMentApi.Filters
{
    public class ServiceContext : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var routedata = context.HttpContext.GetRouteData();
            if (routedata != null) 
            {
                var institutionId = routedata.Values["InstitutionId"];
                var ProductId = routedata.Values["ProductId"];
            }
        }
    }
}
