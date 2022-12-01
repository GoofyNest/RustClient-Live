public static class Numlock // TypeDefIndex: 13842
{
	private const byte VK_NUMLOCK = 144;
	private const uint KEYEVENTF_EXTENDEDKEY = 1;
	private const int KEYEVENTF_KEYUP = 2;
	private const int KEYEVENTF_KEYDOWN = 0;

	public static bool IsOn { get; }


	private static extern short GetKeyState(int keyCode) { }

	private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo) { }

	public static bool get_IsOn() { }

	public static void TurnOn() { }

}

