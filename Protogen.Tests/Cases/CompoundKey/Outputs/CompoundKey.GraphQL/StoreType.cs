/// <auto-generated>
/// This file was automatically generated using Protogen.
/// </auto-generated>
using System;
using System.Linq;
using GraphQL;
using GraphQL.Types;
using CompoundKey.Models;

namespace CompoundKey.GraphQL
{
    /// <summary>
    /// 
    /// </summary>
    public class StoreType : ObjectGraphType<Store>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Store"/> class.
        /// </summary>
        public StoreType()
        {
            Field(
                typeof(long).GetGraphTypeFromType(false),
                "id",
                @"",
                resolve: ctx => ctx.Source.Id
            );
            Field(
                typeof(string).GetGraphTypeFromType(false),
                "name",
                @"",
                resolve: ctx => ctx.Source.Name
            );
        }
    }
}
