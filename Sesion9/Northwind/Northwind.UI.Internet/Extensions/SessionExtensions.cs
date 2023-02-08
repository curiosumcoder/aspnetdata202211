﻿using System.Text.Json;

namespace Northwind.UI.Internet.Extensions
{
    public static class SessionExtensions
    {
        public static void SetObject<T>(this ISession session, string key, T value) where T : class
        {
            string json = JsonSerializer.Serialize(value);
            byte[] serializedResult = System.Text.Encoding.UTF8.GetBytes(json);

            session.Set(key, serializedResult);
        }

        public static T? GetObject<T>(this ISession session, string key) where T : class
        {
            T? result = default(T);
            byte[]? requestEntriesBytes = new byte[0];

            if (session.TryGetValue(key, out requestEntriesBytes))
            {
                if (requestEntriesBytes != null && requestEntriesBytes.Length > 0)
                {
                    string json = System.Text.Encoding.UTF8.GetString(requestEntriesBytes);
                    result = JsonSerializer.Deserialize<T>(json);
                }
            }

            return result;
        }
    }
}
