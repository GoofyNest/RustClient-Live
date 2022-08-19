public class StringPool // TypeDefIndex: 10772
{	// Fields
	private static Dictionary<uint, string> toString; // 0x0
	private static Dictionary<string, uint> toNumber; // 0x8
	private static bool initialized; // 0x10
	public static uint closest; // 0x14

	// Methods

	// RVA: 0x79C6B0 Offset: 0x79BAB0 VA: 0x18079C6B0
	private static void Init() { }

	// RVA: 0x79C4A0 Offset: 0x79B8A0 VA: 0x18079C4A0
	public static string Get(uint i) { }

	// RVA: 0x79C5C0 Offset: 0x79B9C0 VA: 0x18079C5C0
	public static uint Get(string str) { }

	// RVA: 0x79C360 Offset: 0x79B760 VA: 0x18079C360
	public static uint Add(string str) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

