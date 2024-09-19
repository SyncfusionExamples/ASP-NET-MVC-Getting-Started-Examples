using System.Web;
using System.Web.Mvc;

namespace PDFViewerSample
{
    public class JsonMaxLengthAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var jsonResult = filterContext.Result as JsonResult;
            if (jsonResult != null)
            {
                jsonResult.MaxJsonLength = int.MaxValue;  // Set maximum length
            }
            base.OnActionExecuting(filterContext);
        }
    }
}
