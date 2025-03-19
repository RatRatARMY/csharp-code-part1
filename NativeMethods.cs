namespace Pro.A
{
    public partial class NativeMethods
    {
        [LibraryImport("libc", EntryPoint = "getpid")]
        [SupportedOSPlatform("linux")]
        public static partial int GetPid();
        [LibraryImport("libc", EntryPoint = "getppid")]
        [SupportedOSPlatform("linux")]
        public static partial int GetPpid();
        [LibraryImport("libc", EntryPoint = "getlogin")]
        [SupportedOSPlatform("linux")]
        public static partial int GetLogin();
        [LibraryImport("user32.dll", EntryPoint = "MessageBoxA", StringMarshalling = StringMarshalling.Utf16)]
        [SupportedOSPlatform("windows")]
        public static partial int MsgBox(nint hWnd, string text = "", string caption = "", uint mode = 0);
    }
}