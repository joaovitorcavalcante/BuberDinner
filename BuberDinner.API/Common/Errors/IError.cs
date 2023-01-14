using System.Net;

namespace BuberDinner.API.Common.Errors;
public interface IError
{
    public HttpStatusCode StatusCode { get; }
    public string ErrorMessage { get; set; }
}

