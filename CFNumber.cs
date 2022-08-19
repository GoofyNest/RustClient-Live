internal class CFNumber : CFObject // TypeDefIndex: 2515
{	// Methods

	// RVA: 0x120CF00 Offset: 0x120C300 VA: 0x18120CF00
	private static extern bool CFNumberGetValue(IntPtr handle, IntPtr type, out int value) { }

	// RVA: 0x120CE20 Offset: 0x120C220 VA: 0x18120CE20
	public static int AsInt32(IntPtr handle) { }

}

