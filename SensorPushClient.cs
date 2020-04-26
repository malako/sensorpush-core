using Mrc.SensorPushCore.Api;
using Mrc.SensorPushCore.Client;
using Mrc.SensorPushCore.Model;
using System;

namespace Mrc.SensorPushCore
{
    public class SensorPushClient : ApiApi
    {
        string format;

        /// <summary>
        /// Create a SensorPush client. This saves you a few lines of code instead of using the generated "ApiApi" directly.
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <param name="format">json/csv</param>
        public SensorPushClient(string username, string password, string format = "json") : base ()
        {
            Configuration.Username = username;
            Configuration.Password = password;
            this.format = format;
            Authorize();
        }

        private void Authorize()
        {
            var auth = OauthAuthorizePost(new AuthorizeRequest(Configuration.Username, Configuration.Password));
            Configuration.AccessToken = AccessToken(new AccessTokenRequest(auth.Authorization)).Accesstoken;
            Configuration.AddDefaultHeader("Authorization", Configuration.AccessToken);
        }

        /// <summary>
        /// Lists all gateways. This service will return an inventory of all registered gateways for this account.
        /// </summary>
        /// <exception cref="Mrc.SensorPushCore.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Gateways</returns>
        public Gateways Gateways()
        {
            return Gateways(new GatewaysRequest(format));
        }

        public Sensors Sensors(bool active = true)
        {
            return Sensors(new SensorsRequest(active, format));
        }
    }
}
