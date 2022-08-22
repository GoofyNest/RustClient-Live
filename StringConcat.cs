public struct StringConcat // TypeDefIndex: 2430
{	private string s1; // 0x0
	private string s2; // 0x8
	private string s3; // 0x10
	private string s4; // 0x18
	private string delimiter; // 0x20
	private List<string> strList; // 0x28
	private int idxStr; // 0x30

	internal int Count { get; }


	public void Clear() { }

	internal int get_Count() { }

	public string GetResult() { }

	internal void ConcatNoDelimiter(string s) { }

}

