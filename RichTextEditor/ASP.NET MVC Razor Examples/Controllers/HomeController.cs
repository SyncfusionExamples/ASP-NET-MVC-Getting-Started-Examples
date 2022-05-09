using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RichTextEditorSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.image = new[] {
                "Replace", "Align", "Caption", "Remove", "InsertLink", "OpenImageLink", "-",
                "EditImageLink", "RemoveImageLink", "Display", "AltText", "Dimension"
            };
            List<string> tools = new List<string>() {
                "Bold", "Italic", "Underline", "StrikeThrough",
                "FontName", "FontSize", "FontColor", "BackgroundColor",
                "LowerCase", "UpperCase", "|",
                "Formats", "Alignments", "OrderedList", "UnorderedList",
                "Outdent", "Indent", "|",
                "CreateLink", "Image", "CreateTable", "|", "ClearFormat", "Print",
                "SourceCode", "FullScreen", "|", "Undo", "Redo"
            };
            return View(tools);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
    public class RichTextEditorValue
    {
        public string text { get; set; }
        public ActionResult Save(RichTextEditorValue value)
        {
            //Get the RichTextEditorValue value here
            string RTEValue = value.text;
            return View(RTEValue);
        }

        private ActionResult View(string rTEValue)
        {
            throw new NotImplementedException();
        }
    }
}