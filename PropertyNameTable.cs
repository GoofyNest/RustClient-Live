internal class PropertyNameTable // TypeDefIndex: 5919
{	// Fields
	private static readonly int HashCodeRandomizer; // 0x0
	private int _count; // 0x10
	private PropertyNameTable.Entry[] _entries; // 0x18
	private int _mask; // 0x20

	// Methods

	// RVA: 0x18064C0 Offset: 0x18058C0 VA: 0x1818064C0
	private static void .cctor() { }

	// RVA: 0x1806500 Offset: 0x1805900 VA: 0x181806500
	public void .ctor() { }

	// RVA: 0x1806130 Offset: 0x1805530 VA: 0x181806130
	public string Get(char[] key, int start, int length) { }

	// RVA: 0x1805F90 Offset: 0x1805390 VA: 0x181805F90
	public string Add(string key) { }

	// RVA: 0x1805D10 Offset: 0x1805110 VA: 0x181805D10
	private string AddEntry(string str, int hashCode) { }

	// RVA: 0x1806360 Offset: 0x1805760 VA: 0x181806360
	private void Grow() { }

	// RVA: 0xF5A9C0 Offset: 0xF59DC0 VA: 0x180F5A9C0
	private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length) { }

}

private class PropertyNameTable.Entry // TypeDefIndex: 5920
{	// Fields
	internal readonly string Value; // 0x10
	internal readonly int HashCode; // 0x18
	internal PropertyNameTable.Entry Next; // 0x20

	// Methods

	// RVA: 0xF59AC0 Offset: 0xF58EC0 VA: 0x180F59AC0
	internal void .ctor(string value, int hashCode, PropertyNameTable.Entry next) { }

}

