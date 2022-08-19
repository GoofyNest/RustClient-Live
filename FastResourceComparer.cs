internal sealed class FastResourceComparer : IComparer, IEqualityComparer, IComparer<string>, IEqualityComparer<string> // TypeDefIndex: 481
{	// Fields
	internal static readonly FastResourceComparer Default; // 0x12FF1

	// Methods

	// RVA: 0xFE1A70 Offset: 0xFE0E70 VA: 0x180FE1A70 Slot: 6
	public int GetHashCode(object key) { }

	// RVA: 0xFE19D0 Offset: 0xFE0DD0 VA: 0x180FE19D0 Slot: 9
	public int GetHashCode(string key) { }

	// RVA: 0xFE1B30 Offset: 0xFE0F30 VA: 0x180FE1B30
	internal static int HashFunction(string key) { }

	// RVA: 0xFE1850 Offset: 0xFE0C50 VA: 0x180FE1850 Slot: 4
	public int Compare(object a, object b) { }

	// RVA: 0xFE18F0 Offset: 0xFE0CF0 VA: 0x180FE18F0 Slot: 7
	public int Compare(string a, string b) { }

	// RVA: 0xFE19B0 Offset: 0xFE0DB0 VA: 0x180FE19B0 Slot: 8
	public bool Equals(string a, string b) { }

	// RVA: 0xFE1910 Offset: 0xFE0D10 VA: 0x180FE1910 Slot: 5
	public bool Equals(object a, object b) { }

	// RVA: 0xFE15B0 Offset: 0xFE09B0 VA: 0x180FE15B0
	public static int CompareOrdinal(string a, byte[] bytes, int bCharLength) { }

	// RVA: 0xFE1740 Offset: 0xFE0B40 VA: 0x180FE1740
	public static int CompareOrdinal(byte[] bytes, int aCharLength, string b) { }

	// RVA: 0xFE1690 Offset: 0xFE0A90 VA: 0x180FE1690
	internal static int CompareOrdinal(byte* a, int byteLen, string b) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xFE1B90 Offset: 0xFE0F90 VA: 0x180FE1B90
	private static void .cctor() { }

}

