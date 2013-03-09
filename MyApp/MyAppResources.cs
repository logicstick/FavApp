using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace FavApp.MyApp
{
    class MyAppResources : CefSharp.ISchemeHandler
    {
        public bool ProcessRequest(CefSharp.IRequest request, ref string mimeType, ref System.IO.Stream stream)
        {
            if (request.Url.StartsWith("bq://") || request.Url.ToString().StartsWith("sp://") || !request.Url.ToString().Contains("://"))
            { 
            }
            return false;
        }
    }
}
