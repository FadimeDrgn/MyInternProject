﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.JWT
{
    public class AccessToken
    {
        //anlamsız karakterlerden oluşan anahtar değeri
        public string Token { get; set; }
        //Token'ın bitiş zamanını verdiğimiz değer
        public DateTime Expiration { get; set; }
    }
}
