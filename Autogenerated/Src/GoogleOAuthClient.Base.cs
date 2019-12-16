using System;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using Terrasoft.Core;
using Terrasoft.Social.OAuth;

namespace Terrasoft.Configuration
{
	/// <summary>
	/// Represents an Google OAuth client.
	/// </summary>
	public class GoogleOAuthClient : OAuthClient
	{
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="userLogin"></param>
		public GoogleOAuthClient(string userLogin, UserConnection userConnection) 
			: base(userLogin, userConnection) {
		}

		/// <summary>
		/// Returns authenticator for the Google OAuth client.
		/// </summary>
		/// <returns><see cref="Terrasoft.Social.OAuth.IOAuthAuthenticator"/> instance.</returns>
		protected override IOAuthAuthenticator GetAuthenticator(UserConnection userConnection) {
			return new GoogleOAuthAuthenticator(userConnection);
		}
	}
}

