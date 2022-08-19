public static class Numlock // TypeDefIndex: 12024
{	// Fields
	private const byte VK_NUMLOCK = 144;
	private const uint KEYEVENTF_EXTENDEDKEY = 1;
	private const int KEYEVENTF_KEYUP = 2;
	private const int KEYEVENTF_KEYDOWN = 0;

	// Properties
	public static bool IsOn { get; }

	// Methods

	// RVA: 0x4BF100 Offset: 0x4BE500 VA: 0x1804BF100
	private static extern short GetKeyState(int keyCode) { }

	// RVA: 0x4BF2B0 Offset: 0x4BE6B0 VA: 0x1804BF2B0
	private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo) { }

	// RVA: 0x4BF230 Offset: 0x4BE630 VA: 0x1804BF230
	public static bool get_IsOn() { }

	// RVA: 0x4BF180 Offset: 0x4BE580 VA: 0x1804BF180
	public static void TurnOn() { }

}

