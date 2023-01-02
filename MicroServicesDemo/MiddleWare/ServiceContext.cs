using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.AspNetCore.Mvc.Filters;

namespace InstitutionApi.MiddleWare
{
    public class ServiceContext : ActionFilterAttribute
    {
        private readonly HttpContextAccessor _contextAccessor;
        public ServiceContext(HttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        //public override void OnResultExecuting(HttpContextAccessor context )
        //{
        //   // var product = context.HttpContext.GetRouteData();
        //}
    }
}
