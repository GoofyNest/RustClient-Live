internal static class ValidateNames // TypeDefIndex: 2000
{	private static XmlCharType xmlCharType; // 0x13480


	internal static int ParseNmtoken(string s, int offset) { }

	internal static int ParseNmtokenNoNamespaces(string s, int offset) { }

	internal static int ParseNameNoNamespaces(string s, int offset) { }

	internal static bool IsNameNoNamespaces(string s) { }

	internal static int ParseNCName(string s, int offset) { }

	internal static int ParseNCName(string s) { }

	internal static int ParseQName(string s, int offset, out int colonOffset) { }

	internal static void ParseQNameThrow(string s, out string prefix, out string localName) { }

	internal static void ThrowInvalidName(string s, int offsetStartChar, int offsetBadChar) { }

	internal static Exception GetInvalidNameException(string s, int offsetStartChar, int offsetBadChar) { }

	internal static void SplitQName(string name, out string prefix, out string lname) { }

	private static void .cctor() { }

}

