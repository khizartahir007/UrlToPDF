using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Saving;
using IronPdf;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using iTextSharp.tool.xml.html;
using iTextSharp.tool.xml.parser;
using iTextSharp.tool.xml.pipeline.css;
using iTextSharp.tool.xml.pipeline.end;
using iTextSharp.tool.xml.pipeline.html;
using Microsoft.AspNetCore.Mvc;
using OpenQA.Selenium.Chrome;
using PDf.Models;
using System;
using System.Diagnostics;
using System.Net;
using System.Text;

namespace PDf.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            //string url = "https://cip.urban-digital.co.il:8002/1852";
            string pdfFilePath = "example.pdf";
            //WebRequest request = WebRequest.Create("https://cip.urban-digital.co.il:8002/1852");
            //WebResponse response = request.GetResponse();
            //Stream data = response.GetResponseStream();
            //string html = String.Empty;
            //using (StreamReader sr = new StreamReader(data))
            //{
            //    html = sr.ReadToEnd();
            //}
            //var renderer = new ChromePdfRenderer();

            //// Create a PDF from a URL or local file path
            //var pdf = renderer.RenderUrlAsPdf("https://cip.urban-digital.co.il:8002/1852");

            //// Export to a file or Stream
            //pdf.SaveAs("url.pdf");

            Url url = new Url("https://cip.urban-digital.co.il:8002/1852");

            // Initialize PdfSaveOptions 
            var options = new PdfSaveOptions();

            // Convert the HTML code to PDF
            Converter.ConvertHTML(url, options, "URLtoPDF.pdf");
            //using (var client = new HttpClient())
            //{
            //    var response = await client.GetAsync("https://cip.urban-digital.co.il:8002/1851/widjet/(widjet:TrafficLayer)");
            //    var pageContent = await response.Content.ReadAsStringAsync();
            //    Console.WriteLine(pageContent);
            //}
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}