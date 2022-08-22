public class NameTable : XmlNameTable // TypeDefIndex: 1990
{	private NameTable.Entry[] entries; // 0x10
	private int count; // 0x18
	private int mask; // 0x1C
	private int hashCodeRandomizer; // 0x20


	public void .ctor() { }

	public override string Add(string key) { }

	public override string Add(char[] key, int start, int len) { }

	public override string Get(string value) { }

	private string AddEntry(string str, int hashCode) { }

	private void Grow() { }

	private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length) { }

}

private class NameTable.Entry // TypeDefIndex: 1991
{	internal string str; // 0x10
	internal int hashCode; // 0x18
	internal NameTable.Entry next; // 0x20


	internal void .ctor(string str, int hashCode, NameTable.Entry next) { }

}

