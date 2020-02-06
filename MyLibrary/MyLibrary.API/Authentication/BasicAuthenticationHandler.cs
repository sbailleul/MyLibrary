﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Library.API.Helpers;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Library.API.Authentication
{
    public class BasicAuthenticationHandler: AuthenticationHandler<AuthenticationSchemeOptions>
    {
        public BasicAuthenticationHandler(IOptionsMonitor<AuthenticationSchemeOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock) : base(options, logger, encoder, clock)
        {
        }

        protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey(ConstHeaderNames.Authorization))
            {
                return Task.FromResult(AuthenticateResult.Fail("Missing authorization header"));
            }

            try
            {
                var authenticationHeader = AuthenticationHeaderValue.Parse(Request.Headers[ConstHeaderNames.Authorization]);
                var credentialBytes = Convert.FromBase64String(authenticationHeader.Parameter);
                var credentials = Encoding.UTF8.GetString(credentialBytes).Split(':');
                var username = credentials[0];
                var password = credentials[1];

                if (username != "Weak" || password != "Weak")
                    return Task.FromResult(AuthenticateResult.Fail("Invalid credentials"));

                var claims = new[] {new Claim(ClaimTypes.NameIdentifier, username)};
                var identity = new ClaimsIdentity(claims, Scheme.Name);
                var principal = new ClaimsPrincipal(identity);
                var ticket = new AuthenticationTicket(principal, Scheme.Name);
                return Task.FromResult(AuthenticateResult.Success(ticket));
            }
            catch
            {
                return Task.FromResult(AuthenticateResult.Fail("Invalid authorization header"));
            }
        }
    }
}
