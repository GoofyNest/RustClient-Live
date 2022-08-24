internal class CFUrl : CFObject // TypeDefIndex: 2520
{

public void .ctor(IntPtr handle, bool own) { }

private static extern IntPtr CFURLCreateWithString(IntPtr allocator, IntPtr str, IntPtr baseURL) { }

public static CFUrl Create(string absolute) { }

}

