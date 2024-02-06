using System.Runtime.InteropServices;
#if WINDOWS
namespace Kiln.Common {
    public static class Bootstrapper {
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetDllDirectory(string lpPathName);
        public static void StartFNA() { 
            if(Environment.OSVersion.Platform == PlatformID.Win32NT) {
                SetDllDirectory(Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    Environment.Is64BitProcess ? "x64" : "x86"
                    ));
            }
            Environment.SetEnvironmentVariable("FNA_GRAPHICS_ENABLE_HIGHDPI", "1");
        }    
    }
}
#endif
