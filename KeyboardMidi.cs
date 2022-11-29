public static class KeyboardMidi // TypeDefIndex: 13913
{
	[ClientVar] 
	public static string midikeymap; 
	private static Dictionary<string, Dictionary<int, KeyCode[]>> MidiLookup; 


	[ClientVar] 
	public static void Reload() { }

	private static Dictionary<int, KeyCode[]> Init(string instrument) { }

	private static KeyCode[] StringToKeycodeArray(string val) { }

	public static bool IsMidiKeyDown(int midi, string instrumentName) { }

	private static void .cctor() { }

}

private sealed class KeyboardMidi.<>c // TypeDefIndex: 13914
{
	public static readonly KeyboardMidi.<>c <>9; 
	public static Func<string, KeyCode> <>9__4_0; 
	public static Func<KeyCode, bool> <>9__4_1; 


	private static void .cctor() { }

	public void .ctor() { }

	internal KeyCode <StringToKeycodeArray>

	internal bool <StringToKeycodeArray>

}

