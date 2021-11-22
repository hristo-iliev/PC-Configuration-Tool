using Microsoft.AspNetCore.Http;
using PCConfiguration.Core;

namespace PCConfiguration.Web
{
    public interface ISessionStorageHandler
    {
        public Cart GetCartFromSessionStorage(ISession session);

        public void SetCartToSessionStorage(ISession session, Cart cart);
    }
}
