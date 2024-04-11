﻿using poc.core.api.net8;

namespace Poc.Contract.Command.MKT.Post.Response;

public class CreatePostResponse : BaseResponse
{
    public CreatePostResponse(Guid id) => Id = id;

    public Guid Id { get; }
}
