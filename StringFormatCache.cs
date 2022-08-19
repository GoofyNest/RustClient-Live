public static class StringFormatCache // TypeDefIndex: 10767
{	// Fields
	private static Dictionary<StringFormatCache.Key1, string> dict1; // 0x0
	private static Dictionary<StringFormatCache.Key2, string> dict2; // 0x8
	private static Dictionary<StringFormatCache.Key3, string> dict3; // 0x10
	private static Dictionary<StringFormatCache.Key4, string> dict4; // 0x18

	// Methods

	// RVA: 0x79BDE0 Offset: 0x79B1E0 VA: 0x18079BDE0
	public static string Get(string format, string value1) { }

	// RVA: 0x79BF20 Offset: 0x79B320 VA: 0x18079BF20
	public static string Get(string format, string value1, string value2) { }

	// RVA: 0x79C0B0 Offset: 0x79B4B0 VA: 0x18079C0B0
	public static string Get(string format, string value1, string value2, string value3) { }

	// RVA: 0x79BAA0 Offset: 0x79AEA0 VA: 0x18079BAA0
	public static string Get(string format, string value1, string value2, string value3, string value4) { }

	// RVA: 0x79C250 Offset: 0x79B650 VA: 0x18079C250
	private static void .cctor() { }

}

private struct StringFormatCache.Key1 : IEquatable<StringFormatCache.Key1> // TypeDefIndex: 10768
{	// Fields
	public string format; // 0x0
	public string value1; // 0x8

	// Methods

	// RVA: 0xF5940 Offset: 0xF4D40 VA: 0x1800F5940
	public void .ctor(string format, string value1) { }

	// RVA: 0xF58E0 Offset: 0xF4CE0 VA: 0x1800F58E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xF57D0 Offset: 0xF4BD0 VA: 0x1800F57D0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xF5880 Offset: 0xF4C80 VA: 0x1800F5880 Slot: 4
	public bool Equals(StringFormatCache.Key1 other) { }

}

private struct StringFormatCache.Key2 : IEquatable<StringFormatCache.Key2> // TypeDefIndex: 10769
{	// Fields
	public string format; // 0x0
	public string value1; // 0x8
	public string value2; // 0x10

	// Methods

	// RVA: 0xF5B60 Offset: 0xF4F60 VA: 0x1800F5B60
	public void .ctor(string format, string value1, string value2) { }

	// RVA: 0xF5AE0 Offset: 0xF4EE0 VA: 0x1800F5AE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xF5980 Offset: 0xF4D80 VA: 0x1800F5980 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xF5A50 Offset: 0xF4E50 VA: 0x1800F5A50 Slot: 4
	public bool Equals(StringFormatCache.Key2 other) { }

}

private struct StringFormatCache.Key3 : IEquatable<StringFormatCache.Key3> // TypeDefIndex: 10770
{	// Fields
	public string format; // 0x0
	public string value1; // 0x8
	public string value2; // 0x10
	public string value3; // 0x18

	// Methods

	// RVA: 0xF5DE0 Offset: 0xF51E0 VA: 0x1800F5DE0
	public void .ctor(string format, string value1, string value2, string value3) { }

	// RVA: 0xF5D30 Offset: 0xF5130 VA: 0x1800F5D30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xF5C50 Offset: 0xF5050 VA: 0x1800F5C50 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xF5BC0 Offset: 0xF4FC0 VA: 0x1800F5BC0 Slot: 4
	public bool Equals(StringFormatCache.Key3 other) { }

}

private struct StringFormatCache.Key4 : IEquatable<StringFormatCache.Key4> // TypeDefIndex: 10771
{	// Fields
	public string format; // 0x0
	public string value1; // 0x8
	public string value2; // 0x10
	public string value3; // 0x18
	public string value4; // 0x20

	// Methods

	// RVA: 0xF6140 Offset: 0xF5540 VA: 0x1800F6140
	public void .ctor(string format, string value1, string value2, string value3, string value4) { }

	// RVA: 0xF6060 Offset: 0xF5460 VA: 0x1800F6060 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xF5F70 Offset: 0xF5370 VA: 0x1800F5F70 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xF6020 Offset: 0xF5420 VA: 0x1800F6020 Slot: 4
	public bool Equals(StringFormatCache.Key4 other) { }

}

