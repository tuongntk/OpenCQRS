﻿using Microsoft.Azure.Documents;
using Microsoft.Extensions.Options;
using OpenCqrs.Store.CosmosDB.Sql.Configuration;
using OpenCqrs.Store.CosmosDB.Sql.Documents;

namespace OpenCqrs.Store.CosmosDB.Sql.Repositories
{
    internal class CommandRepository : BaseDocumentRepository<CommandDocument>
    {
        public CommandRepository(IDocumentClient documentClient, IOptions<DomainDbConfiguration> settings) 
            : base(settings.Value.CommandCollectionId, documentClient, settings)
        {
        }
    }
}