using System.Net;

namespace WebApplication9.Models
{
    public class Response
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool isExitoso { get; set; } = true;
        public List<string> ErrorMessages { get; set; }
        public object Resultado { get; set; }
    }
}
