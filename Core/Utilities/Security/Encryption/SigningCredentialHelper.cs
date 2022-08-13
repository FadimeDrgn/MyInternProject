﻿using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Encryption
{
    public class SigningCredentialHelper
    {
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
        {
            //algoritma olarak hmacsha512, anahtar olarakta ssecurityKey kullan
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512);
        }
    }
}
