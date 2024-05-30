using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    public string Index()
    {
        return Index();
    }
    //
    //GET: /HelloWorld/Welcome/
    /*
    public string welcome(string name, int numTimes = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
    }
    */
    public string Welcome(string name, int ID = 3000)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
    }

}

