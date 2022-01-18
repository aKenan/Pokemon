using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Adecco.Pokemon.BuildingBlocks.Infrastructure.Extensions
{
    public static class Extensions
    {
        public static string GetQueryParameters(this Dictionary<string, string> parameters)
        {
            var query = HttpUtility.ParseQueryString(string.Empty);

            foreach (var parameter in parameters)
            {
                query[parameter.Key] = parameter.Value;
            }

            return query.ToString();
        }

        public static string GetRequestUrl(string baseAddress, string route, string queryParameters)
        {
            return $"{baseAddress}/{route}?{queryParameters}";
        }
    }
}
