using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace FileLib
{
    public class FileUtil
    {
        public static Task SaveAs(string filename, byte[] data)
            => JSRuntime.Current.InvokeAsync<object>(
                "saveAsFile",
                filename,
                Convert.ToBase64String(data));
    }
}

