﻿using Ardalis.Result;
using MediatR;
using Poc.Contract.Query.MKT.Post.QueriesModel;

namespace Poc.Contract.Query.MKT.Post.Request;

public class GetPostQuery : IRequest<Result<List<PostQueryModel>>>
{
    public GetPostQuery()
    {
    }
}
