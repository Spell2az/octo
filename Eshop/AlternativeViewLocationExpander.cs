using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Razor;

namespace Eshop
{
    public class AlternativeViewLocationExpander : IViewLocationExpander
    {
        private const string ValueKey = "alt";

        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            context.Values.TryGetValue(ValueKey, out var value);

            if (string.IsNullOrWhiteSpace(value))
            {
                return viewLocations;
            }

            return ExpandViewLocationsCore(viewLocations, value);
        }

        private IEnumerable<string> ExpandViewLocationsCore(IEnumerable<string> viewLocations, string value)
        {
            foreach (var location in viewLocations)
            {
                yield return location.Replace("{0}", value + "/{0}");
                yield return location;
            }
        }

        public void PopulateValues(ViewLocationExpanderContext context)
        {
            context.Values[ValueKey] = context.ActionContext.RouteData.Values[ValueKey]?.ToString();
        }
    }
}