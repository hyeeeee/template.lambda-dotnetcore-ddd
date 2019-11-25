﻿using MyLambdaDotNetCoreProject.Domain.Aggregate.Entity1Aggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLambdaDotNetCoreProject.Infrastructure.Repository
{
    public class Entity1Repository : IEntity1Repository
    {
        void IEntity1Repository.Create(Entity1 item) => throw new NotImplementedException();

        void IEntity1Repository.Update(Entity1 item) => throw new NotImplementedException();

        async Task<IEnumerable<Entity1>> IEntity1Repository.RetrieveAsync() =>  _mockData;

        async Task<Entity1> IEntity1Repository.RetrieveAsync(string id) => _mockData.FirstOrDefault(o => o.Id == id);
        

        readonly static IEnumerable<Entity1> _mockData = new Entity1[]
        {
            new Entity1("entity1-1"),
            new Entity1("entity1-2")
        };
    }
}
