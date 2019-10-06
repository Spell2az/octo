using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Controller;

namespace Eshop
{
    public class CustomViewLocationExpander : IViewLocationExpander
    {
        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            var updatedViewLocations = viewLocations.ToList();
            updatedViewLocations.Add("/Views/{0}.cshtml");
            updatedViewLocations.Add("/Views/Shared/{0}.cshtml");

            return updatedViewLocations;
        }

        public void PopulateValues(ViewLocationExpanderContext context)
        {
            Console.WriteLine(context);
        }
    }
}