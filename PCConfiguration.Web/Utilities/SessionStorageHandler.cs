using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using PCConfiguration.Core;
using PCConfiguration.Web.Properties;

namespace PCConfiguration.Web
{
    public class SessionStorageHandler : ISessionStorageHandler
    {
        public Cart GetCartFromSessionStorage(ISession session)
        {
            Cart cart;
            var value = session.GetString(Resources.CART_KEY);
            if (value == null)
            {
                cart = new Cart();
            }
            else
            {
                cart = JsonConvert.DeserializeObject<Cart>(value);
            }

            return cart;
        }

        public void SetCartToSessionStorage(ISession session, Cart cart)
        {
            session.SetString(Resources.CART_KEY, JsonConvert.SerializeObject(cart));
        }
    }
}
