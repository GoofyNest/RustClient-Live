public class NameTable : XmlNameTable // TypeDefIndex: 1990
{
	private NameTable.Entry[] entries;
	private int count;
	private int mask;
	private int hashCodeRandomizer;


	public void .ctor() { }

	public override string Add(string key) { }

	public override string Add(char[] key, int start, int len) { }

	public override string Get(string value) { }

	private string AddEntry(string str, int hashCode) { }

	private void Grow() { }

	private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length) { }

}

private class NameTable.Entry // TypeDefIndex: 1991
{
	internal string str;
	internal int hashCode;
	internal NameTable.Entry next;


	internal void .ctor(string str, int hashCode, NameTable.Entry next) { }

}

