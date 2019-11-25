﻿using MediatR;
using MyLambdaDotNetCoreProject.Application.Query.Readmodel;
using MyLambdaDotNetCoreProject.Domain.Aggregate.Entity1Aggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLambdaDotNetCoreProject.Application.Query
{
    public class GetEntity1Request : IRequest<IEnumerable<Entity1View>>
    {
        public GetEntity1Request()
        {
        }

        public GetEntity1Request(string id)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
        }

        public string Id { get; set; }
    }
}
