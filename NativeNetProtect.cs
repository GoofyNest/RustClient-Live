internal static class NativeNetProtect // TypeDefIndex: 7154
{
	private static IntPtr Instance; 


private static extern uint dotProtectMessage_RawPtr(IntPtr Instance, IntPtr Input, uint InputLength, IntPtr Output, ref uint OutputLength) { }

private static extern uint dotUnprotectMessage_RawPtr(IntPtr Instance, IntPtr Input, uint InputLength, IntPtr Output, ref uint OutputLength) { }

private static extern uint dotGetProtectMessageOutputLength(IntPtr Instance, uint InputLength) { }

public static void SetInstance(IntPtr NetProtectInstance) { }

public static bool ProtectMessage(MemoryStream Input, long InputOffset, MemoryStream Output, long OutputOffset) { }

public static bool UnprotectMessage(MemoryStream Input, long InputOffset, MemoryStream Output, long OutputOffset) { }

private static void .cctor() { }

}

