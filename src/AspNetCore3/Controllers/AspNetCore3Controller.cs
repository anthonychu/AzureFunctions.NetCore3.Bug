using System.IO;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

namespace AspNetCore3.Controllers
{
    [ApiController]
    public class AspNetCoreController : ControllerBase
    {
        [HttpPost]
        [Route("aspnetcore3/{id}")]
        public async Task<string> Post([FromRoute] CustomRouteParameter parameter)
        {
            using (var reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                return await reader.ReadToEndAsync();
            }
        }
    }
}
