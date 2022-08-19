internal static class NativeNetProtect // TypeDefIndex: 7154
{	// Fields
	private static IntPtr Instance; // 0x11C0B

	// Methods

	// RVA: 0x22E1750 Offset: 0x22E0B50 VA: 0x1822E1750
	private static extern uint dotProtectMessage_RawPtr(IntPtr Instance, IntPtr Input, uint InputLength, IntPtr Output, ref uint OutputLength) { }

	// RVA: 0x22E1810 Offset: 0x22E0C10 VA: 0x1822E1810
	private static extern uint dotUnprotectMessage_RawPtr(IntPtr Instance, IntPtr Input, uint InputLength, IntPtr Output, ref uint OutputLength) { }

	// RVA: 0x22E16C0 Offset: 0x22E0AC0 VA: 0x1822E16C0
	private static extern uint dotGetProtectMessageOutputLength(IntPtr Instance, uint InputLength) { }

	// RVA: 0x22E12F0 Offset: 0x22E06F0 VA: 0x1822E12F0
	public static void SetInstance(IntPtr NetProtectInstance) { }

	// RVA: 0x22E0F30 Offset: 0x22E0330 VA: 0x1822E0F30
	public static bool ProtectMessage(MemoryStream Input, long InputOffset, MemoryStream Output, long OutputOffset) { }

	// RVA: 0x22E1350 Offset: 0x22E0750 VA: 0x1822E1350
	public static bool UnprotectMessage(MemoryStream Input, long InputOffset, MemoryStream Output, long OutputOffset) { }

	// RVA: 0x22E1680 Offset: 0x22E0A80 VA: 0x1822E1680
	private static void .cctor() { }

}

