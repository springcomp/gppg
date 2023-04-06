using System;
using System.Reflection;

namespace QUT.GPGen {
    internal static class Shims {
        public static string MachineName
            => Environment.GetEnvironmentVariable("COMPUTERNAME") ?? Environment.GetEnvironmentVariable("HOSTNAME");
    }
}
