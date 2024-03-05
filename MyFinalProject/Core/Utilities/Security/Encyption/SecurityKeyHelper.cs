using System;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Core.Utilities.Security.Encyption
{
	public class SecurityKeyHelper
	{
		public static SecurityKey CreateSecurityKey(string securityKey)//appsettings de oluşturduğumuz gibi
		{
			return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
		} 
	}
}

