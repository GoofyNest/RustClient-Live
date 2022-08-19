internal static class ValidateNames // TypeDefIndex: 2000
{	// Fields
	private static XmlCharType xmlCharType; // 0x13480

	// Methods

	// RVA: 0xE4A630 Offset: 0xE49A30 VA: 0x180E4A630
	internal static int ParseNmtoken(string s, int offset) { }

	// RVA: 0xE4A540 Offset: 0xE49940 VA: 0x180E4A540
	internal static int ParseNmtokenNoNamespaces(string s, int offset) { }

	// RVA: 0xE4A3D0 Offset: 0xE497D0 VA: 0x180E4A3D0
	internal static int ParseNameNoNamespaces(string s, int offset) { }

	// RVA: 0xE4A1A0 Offset: 0xE495A0 VA: 0x180E4A1A0
	internal static bool IsNameNoNamespaces(string s) { }

	// RVA: 0xE4A220 Offset: 0xE49620 VA: 0x180E4A220
	internal static int ParseNCName(string s, int offset) { }

	// RVA: 0xE4A370 Offset: 0xE49770 VA: 0x180E4A370
	internal static int ParseNCName(string s) { }

	// RVA: 0xE4A8D0 Offset: 0xE49CD0 VA: 0x180E4A8D0
	internal static int ParseQName(string s, int offset, out int colonOffset) { }

	// RVA: 0xE4A700 Offset: 0xE49B00 VA: 0x180E4A700
	internal static void ParseQNameThrow(string s, out string prefix, out string localName) { }

	// RVA: 0xE4AB10 Offset: 0xE49F10 VA: 0x180E4AB10
	internal static void ThrowInvalidName(string s, int offsetStartChar, int offsetBadChar) { }

	// RVA: 0xE49FC0 Offset: 0xE493C0 VA: 0x180E49FC0
	internal static Exception GetInvalidNameException(string s, int offsetStartChar, int offsetBadChar) { }

	// RVA: 0xE4A9C0 Offset: 0xE49DC0 VA: 0x180E4A9C0
	internal static void SplitQName(string name, out string prefix, out string lname) { }

	// RVA: 0xE4ACE0 Offset: 0xE4A0E0 VA: 0x180E4ACE0
	private static void .cctor() { }

}

