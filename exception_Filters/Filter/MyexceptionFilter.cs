using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace exception_Filters.Filter
{
    public class MyexceptionFilter: ExceptionFilterAttribute, IExceptionFilter 
    {
        public override void OnException(ExceptionContext context) {

            Console.WriteLine(context.RouteData.Values["Controller"].ToString());
            Console.WriteLine(context.RouteData.Values["action"].ToString());
            
            Console.WriteLine(context.Exception.Message);

          //  context.Result = new OkObjectResult("done");
            context.Result = new RedirectResult("home/error");
        }
    }
}
