using catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace catalog.API.Data
{
    public interface ICatalogcontext
    {
        IMongoCollection<products> Products { get; }
    }
}
