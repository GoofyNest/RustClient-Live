public class NameTable : XmlNameTable // TypeDefIndex: 1990
{	// Fields
	private NameTable.Entry[] entries; // 0x10
	private int count; // 0x18
	private int mask; // 0x1C
	private int hashCodeRandomizer; // 0x20

	// Methods

	// RVA: 0xF5AA50 Offset: 0xF59E50 VA: 0x180F5AA50
	public void .ctor() { }

	// RVA: 0xF5A370 Offset: 0xF59770 VA: 0x180F5A370 Slot: 6
	public override string Add(string key) { }

	// RVA: 0xF5A4F0 Offset: 0xF598F0 VA: 0x180F5A4F0 Slot: 5
	public override string Add(char[] key, int start, int len) { }

	// RVA: 0xF5A6F0 Offset: 0xF59AF0 VA: 0x180F5A6F0 Slot: 4
	public override string Get(string value) { }

	// RVA: 0xF5A0F0 Offset: 0xF594F0 VA: 0x180F5A0F0
	private string AddEntry(string str, int hashCode) { }

	// RVA: 0xF5A860 Offset: 0xF59C60 VA: 0x180F5A860
	private void Grow() { }

	// RVA: 0xF5A9C0 Offset: 0xF59DC0 VA: 0x180F5A9C0
	private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length) { }

}

private class NameTable.Entry // TypeDefIndex: 1991
{	// Fields
	internal string str; // 0x10
	internal int hashCode; // 0x18
	internal NameTable.Entry next; // 0x20

	// Methods

	// RVA: 0xF59AC0 Offset: 0xF58EC0 VA: 0x180F59AC0
	internal void .ctor(string str, int hashCode, NameTable.Entry next) { }

}

