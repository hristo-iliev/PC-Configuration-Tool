using Microsoft.AspNetCore.Http;
using PCConfiguration.Core;

namespace PCConfiguration.Web
{
    public interface ISessionStorageHandler
    {
        public Cart GetCardFromSessionStorage(ISession session);

        public void SetCardToSessionStorage(ISession session, Cart cart);
    }
}
