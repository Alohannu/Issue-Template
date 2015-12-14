﻿using System;
using System.Net.Sockets;
using System.Reflection;

#if DNX
using System.Reflection;
#endif

namespace RethinkDb.Driver.Utils
{
    internal static class ExtensionsForType
    {
#if DNX
        public static bool IsSubclassOf(this Type type, Type other)
        {
            return type.GetTypeInfo().IsSubclassOf(other);
        }
#endif

        public static bool IsGenericType(this Type type)
        {
#if DNX
            return type.GetTypeInfo().IsGenericType;
#else
            return type.IsGenericType;
#endif
        }

        public static Type BaseType(this Type type)
        {
#if DNX
            return type.GetTypeInfo().BaseType;
#else
            return type.BaseType;
#endif
        }
    }

    internal static class ExtensionsForTcpClient
    {
        public static void Shutdown(this TcpClient tcp)
        {
#if DNXCORE50
            tcp.Dispose();
#else
            tcp.Close();
#endif   
        }
    }
}