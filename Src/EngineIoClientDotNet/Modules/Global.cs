﻿using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace Quobject.EngineIoClientDotNet.Modules
{
    public static class Global
    {
        public static string EncodeURIComponent(string str)
        {
            //http://stackoverflow.com/a/4550600/1109316
            return Uri.EscapeDataString(str);
        }

        public static string DecodeURIComponent(string str)
        {
            return HttpUtility.UrlDecode(str);
        }

        public static string CallerName([CallerMemberName]string caller = "", [CallerLineNumber]int number = 0, [CallerFilePath]string path = "")
        {
            Uri u = new Uri(path);
            var s = path.Split('\\');
            var fileName = s.LastOrDefault();

            return string.Format("{0}:{1}#{2}", fileName, caller, number);
        }                 

    }
}
