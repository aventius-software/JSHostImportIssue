using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace RazorClassLibrary;

[SupportedOSPlatform("browser")]
public partial class Test
{
    [JSImport("someFunc", "Test")]
    internal static partial string GetValueFromJSFunc();
}