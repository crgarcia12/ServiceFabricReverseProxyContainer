using System.Collections;
using System.Web.Http;

namespace GreenApp.Controllers
{
    public class EnvironmentVariablesController : ApiController
    {
        // GET: api/EnvironmentVariables
        public IDictionary Get()
        {
            return System.Environment.GetEnvironmentVariables();
        }
    }
}
