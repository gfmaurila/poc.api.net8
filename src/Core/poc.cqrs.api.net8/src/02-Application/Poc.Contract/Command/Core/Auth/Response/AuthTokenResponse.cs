﻿using poc.core.api.net8;

namespace Poc.Contract.Command.Core.Auth.Response;

public class AuthTokenResponse : BaseResponse
{
    public AuthTokenResponse(string token)
    {
        Token = token;
    }
    public string Token { get; }
}
