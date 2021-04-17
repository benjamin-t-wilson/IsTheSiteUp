using System.Threading.Tasks;

namespace IsTheSiteUp.Interfaces
{
    public interface IHttpClientFactory
    {
        Task<bool> IsGetRequestSuccessful(string url);
    }
}