using Microsoft.AspNetCore.Mvc.Filters;
using EnvironMentApi.Constants;
using Microsoft.AspNetCore.Mvc;

namespace EnvironMentApi.Filters
{
    public class ServiceContext : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var routedata = context.HttpContext.GetRouteData();
            if (routedata != null)
            {
                var institutionId = routedata.Values["InstitutionId"];
                var ProductId = routedata.Values["ProductId"];
            }
            //if (!context.ModelState.IsValid)
            //{
            //    context.Result = new BadRequestObjectResult(context.ModelState);
            //}
        }
        //public void OnActionExecuted(ActionExecutedContext context)
        //{
        //    var routedata = context.HttpContext.GetRouteData();
        //    if (routedata != null)
        //    {
        //        var institutionId = routedata.Values["InstitutionId"];
        //        var ProductId = routedata.Values["ProductId"];
        //    }
        //}

        //public void OnActionExecuting(ActionExecutingContext context)
        //{
        //    var routedata = context.HttpContext.GetRouteData();
        //    if (routedata != null)
        //    {
        //        var institutionId = routedata.Values["InstitutionId"];
        //        var ProductId = routedata.Values["ProductId"];
        //    }
        //}
    }
}
