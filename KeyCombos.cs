public static class KeyCombos // TypeDefIndex: 8230
{	// Methods

	// RVA: 0x1069910 Offset: 0x1068D10 VA: 0x181069910
	public static bool TryParse(ref string name, out List<KeyCode> keys) { }

	// RVA: 0x10697D0 Offset: 0x1068BD0 VA: 0x1810697D0
	public static void RegisterButton(string name, List<KeyCode> keys) { }

	// RVA: 0x1069790 Offset: 0x1068B90 VA: 0x181069790
	private static bool IsFunctionKey(KeyCode keyCode) { }

	// RVA: 0x10697B0 Offset: 0x1068BB0 VA: 0x1810697B0
	private static bool IsMouseButton(KeyCode keyCode) { }

}

private sealed class KeyCombos.<>c // TypeDefIndex: 8231
{	// Fields
	public static readonly KeyCombos.<>c <>9; // 0x0
	public static Func<KeyCode, string> <>9__0_0; // 0x8
	public static Func<string, string> <>9__0_1; // 0x10

	// Methods

	// RVA: 0x1075490 Offset: 0x1074890 VA: 0x181075490
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1074F70 Offset: 0x1074370 VA: 0x181074F70
	internal string <TryParse>b__0_0(KeyCode k) { }

	// RVA: 0x1075000 Offset: 0x1074400 VA: 0x181075000
	internal string <TryParse>b__0_1(string s) { }

}

private sealed class KeyCombos.<>c__DisplayClass1_0 // TypeDefIndex: 8232
{	// Fields
	public List<KeyCode> keys; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x10750B0 Offset: 0x10744B0 VA: 0x1810750B0
	internal bool <RegisterButton>b__0() { }

}

