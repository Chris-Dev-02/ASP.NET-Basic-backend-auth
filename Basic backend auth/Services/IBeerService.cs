using BasicBackendAuthentication.Models;

namespace BasicBackendAuthentication.Services
{
    public interface IBeerService
    {
        public Task<List<Beer>> Get();
    }
}
