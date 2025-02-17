﻿using System;
using System.Text;

namespace Core.Utilities.Security.Hashing
{
	public class HashingHelper
	{
		public HashingHelper()
		{
		}

		public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)//PAswordun hashini ve saltını oluştrucak
		{
			using (var hmac=new System.Security.Cryptography.HMACSHA512())//Disposible pattern nedir?
			{
				passwordSalt = hmac.Key;
				passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));// string değeri byte çeviriyor
			}
		}
		public static bool VerifyPasswordHash(string password,  byte[] passwordHash, byte[] passwordSalt)
		{
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
				for (int i = 0; i < computedHash.Length; i++)
				{
					if (computedHash[i] != passwordHash[i])
					{
						return false;

					}
				}
			return true;
            }
        }
	}
}

