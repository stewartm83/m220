﻿using Microsoft.Extensions.Configuration;

namespace M220NLessons
{
    public static class Constants
    {
        public static string BadMongoDbConnectionUri = "mongodb://localhost:27011/"; // Used only to force a timeout
        public static string LocalMongoDbConnectionUri = "mongodb://localhost:27017/"; // Used only to force a timeout

        public static string MongoDbConnectionUri()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true)
                .AddJsonFile($"appsettings.development.json", optional: true)
                .AddEnvironmentVariables()
                .Build();

            return configuration.GetValue<string>("MongoUri");

        }
    }
}
