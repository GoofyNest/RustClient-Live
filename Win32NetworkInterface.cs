internal class Win32NetworkInterface // TypeDefIndex: 3082
{	// Fields
	private static Win32_FIXED_INFO fixedInfo; // 0x0
	private static bool initialized; // 0x58

	// Properties
	public static Win32_FIXED_INFO FixedInfo { get; }

	// Methods

	// RVA: 0x13442E0 Offset: 0x13436E0 VA: 0x1813442E0
	private static extern int GetNetworkParams(IntPtr ptr, ref int size) { }

	// RVA: 0x1344370 Offset: 0x1343770 VA: 0x181344370
	public static Win32_FIXED_INFO get_FixedInfo() { }

}

