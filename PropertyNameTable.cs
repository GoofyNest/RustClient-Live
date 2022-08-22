internal class PropertyNameTable // TypeDefIndex: 5919
{	private static readonly int HashCodeRandomizer; // 0x0
	private int _count; // 0x10
	private PropertyNameTable.Entry[] _entries; // 0x18
	private int _mask; // 0x20


	private static void .cctor() { }

	public void .ctor() { }

	public string Get(char[] key, int start, int length) { }

	public string Add(string key) { }

	private string AddEntry(string str, int hashCode) { }

	private void Grow() { }

	private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length) { }

}

private class PropertyNameTable.Entry // TypeDefIndex: 5920
{	internal readonly string Value; // 0x10
	internal readonly int HashCode; // 0x18
	internal PropertyNameTable.Entry Next; // 0x20


	internal void .ctor(string value, int hashCode, PropertyNameTable.Entry next) { }

}

