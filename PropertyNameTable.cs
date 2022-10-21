internal class PropertyNameTable // TypeDefIndex: 5924
{
	private static readonly int HashCodeRandomizer; 
	private int _count; 
	private PropertyNameTable.Entry[] _entries; 
	private int _mask; 


	private static void .cctor() { }

	public void .ctor() { }

	public string Get(char[] key, int start, int length) { }

	public string Add(string key) { }

	private string AddEntry(string str, int hashCode) { }

	private void Grow() { }

	private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length) { }

}

private class PropertyNameTable.Entry // TypeDefIndex: 5925
{
	internal readonly string Value; 
	internal readonly int HashCode; 
	internal PropertyNameTable.Entry Next; 


	internal void .ctor(string value, int hashCode, PropertyNameTable.Entry next) { }

}

