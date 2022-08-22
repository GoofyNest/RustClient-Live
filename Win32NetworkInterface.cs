internal class Win32NetworkInterface // TypeDefIndex: 3082
{	private static Win32_FIXED_INFO fixedInfo; // 0x0
	private static bool initialized; // 0x58

	public static Win32_FIXED_INFO FixedInfo { get; }


	private static extern int GetNetworkParams(IntPtr ptr, ref int size) { }

	public static Win32_FIXED_INFO get_FixedInfo() { }

}

