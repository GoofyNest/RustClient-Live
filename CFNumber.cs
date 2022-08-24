internal class CFNumber : CFObject // TypeDefIndex: 2515
{

private static extern bool CFNumberGetValue(IntPtr handle, IntPtr type, out int value) { }

public static int AsInt32(IntPtr handle) { }

}

