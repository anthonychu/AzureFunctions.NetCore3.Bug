using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;

namespace FunctionNetCore2
{
    public static class Runner
    {
        [FunctionName("RunNetCore2")]
        public static async Task<string> RunNetCore2Async(
            [HttpTrigger(AuthorizationLevel.Anonymous, "POST", Route = "netcore2/{id}")]
            CustomRouteParameter parameter,
            HttpRequest request,
            CancellationToken cancellationToken)
        {
            using (var reader = new StreamReader(request.Body, Encoding.UTF8))
            {
                return await reader.ReadToEndAsync();
            }
        }
    }
}
