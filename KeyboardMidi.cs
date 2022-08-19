public static class KeyboardMidi // TypeDefIndex: 12111
{	// Fields
	[ClientVar] // RVA: 0xDBD80 Offset: 0xDB180 VA: 0x1800DBD80
	public static string midikeymap; // 0x0
	private static Dictionary<string, Dictionary<int, KeyCode[]>> MidiLookup; // 0x8

	// Methods

	[ClientVar] // RVA: 0xDBDC0 Offset: 0xDB1C0 VA: 0x1800DBDC0
	// RVA: 0x4BB9C0 Offset: 0x4BADC0 VA: 0x1804BB9C0
	public static void Reload() { }

	// RVA: 0x4BB3B0 Offset: 0x4BA7B0 VA: 0x1804BB3B0
	private static Dictionary<int, KeyCode[]> Init(string instrument) { }

	// RVA: 0x4BBA30 Offset: 0x4BAE30 VA: 0x1804BBA30
	private static KeyCode[] StringToKeycodeArray(string val) { }

	// RVA: 0x4BB8D0 Offset: 0x4BACD0 VA: 0x1804BB8D0
	public static bool IsMidiKeyDown(int midi, string instrumentName) { }

	// RVA: 0x4BBC50 Offset: 0x4BB050 VA: 0x1804BBC50
	private static void .cctor() { }

}

private sealed class KeyboardMidi.<>c // TypeDefIndex: 12112
{	// Fields
	public static readonly KeyboardMidi.<>c <>9; // 0x0
	public static Func<string, KeyCode> <>9__4_0; // 0x8
	public static Func<KeyCode, bool> <>9__4_1; // 0x10

	// Methods

	// RVA: 0x4CF040 Offset: 0x4CE440 VA: 0x1804CF040
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x4CEAE0 Offset: 0x4CDEE0 VA: 0x1804CEAE0
	internal KeyCode <StringToKeycodeArray>b__4_0(string x) { }

	// RVA: 0x4CEBA0 Offset: 0x4CDFA0 VA: 0x1804CEBA0
	internal bool <StringToKeycodeArray>b__4_1(KeyCode x) { }

}

