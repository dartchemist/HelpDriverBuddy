namespace HelpDriverBuddy.Service.ClientLibrary.Config
{
    using System;
    using System.Collections.Generic;
    using AutoMapper;

    public static class AutoMapperConfig
    {
        public static void RegisterMappings(params KeyValuePair<Type,Type>[] types)
        {
            foreach (var kv in types)
            {
                Mapper.CreateMap(kv.Key, kv.Value);
                Mapper.CreateMap(kv.Value, kv.Key);
            }
        }

        public static void RegisterOneWayMappings(params KeyValuePair<Type, Type>[] types)
        {
            foreach (var kv in types)
            {
                Mapper.CreateMap(kv.Key, kv.Value);
            }
        }
    }
}