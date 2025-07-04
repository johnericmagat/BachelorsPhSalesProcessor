﻿using System.Diagnostics;
using System.Reflection;

namespace BachelorsPhSalesProcessor.Helper
{
    public static class GetVersionHelper
    {
        public static string GetVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);

            string versionNumber = fileVersionInfo.FileVersion.ToString();
            return versionNumber;
        }
    }
}
