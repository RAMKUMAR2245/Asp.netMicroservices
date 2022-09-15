using catalog.API.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace catalog.API.Data
{
    public class Catalogcontext : ICatalogcontext
    {
        public Catalogcontext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:Connectionstring"));
            var databse = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:DatabaseName"));

            Products = databse.GetCollection<products>(configuration.GetValue<string>("DatabaseSettings:CollectionName"));
            CatalogContextSeed.seedData(Products);
        }
        public IMongoCollection<products> Products { get; }
    }
}
