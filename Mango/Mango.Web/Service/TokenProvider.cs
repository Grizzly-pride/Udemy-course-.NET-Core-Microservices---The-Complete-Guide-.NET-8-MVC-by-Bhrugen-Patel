﻿using Mango.Web.Service.IService;
using Mango.Web.Utility;
using Newtonsoft.Json.Linq;


namespace Mango.Web.Service
{
    public class TokenProvider : ITokenProvider
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public TokenProvider(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;               
        }

        public void ClearToken()
            => _contextAccessor.HttpContext?.Response.Cookies.Delete(SD.TokenCookie);

        public string GetToken() 
            => _contextAccessor.HttpContext.Request.Cookies.TryGetValue(SD.TokenCookie, out string? token) 
                ? token
                : string.Empty;
       
        public void SetToken(string token)
            => _contextAccessor.HttpContext?.Response.Cookies.Append(SD.TokenCookie, token);
    }
}